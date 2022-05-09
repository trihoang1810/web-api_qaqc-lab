namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class CurlingForceTestRepository : BaseRepository, ICurlingForceTestRepository
{
    public CurlingForceTestRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<QueryResult<CurlingForceTest>> GetAllAsync(TimeQuery query)
    {
        var tests = await _context.CurlingForceTests
            .Include(c => c.Samples)
                .ThenInclude(c => c.Tester)
            .Include(c => c.Product)
            .Where(c => 
                c.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                c.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(c => c.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItem = tests.Count;

        return new QueryResult<CurlingForceTest>
        {
            Items = tests,
            TotalItems = totalItem,
        };
    }

    public async Task<QueryResult<CurlingForceTest>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _context.CurlingForceTests
            .Include(c => c.Samples)
                .ThenInclude(c => c.Tester)
            .Include(c => c.Product)
            .Where(c =>
                c.ProductId == productId &&
                c.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                c.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(c => c.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItems = tests.Count;

        return new QueryResult<CurlingForceTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task AddAsync(Product product, Tester tester, CurlingForceTest curlingForceTest)
    {
        curlingForceTest.Product = product;
        foreach (CurlingForceTestSample sample in curlingForceTest.Samples)
        {
            sample.Tester = tester;
        }
        await _context.AddRangeAsync(curlingForceTest);
    }
}
