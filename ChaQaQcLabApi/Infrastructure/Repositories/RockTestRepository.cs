namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class RockTestRepository : BaseRepository, IRockTestRepository
{
    public RockTestRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<QueryResult<RockTest>> GetAllAsync(TimeQuery query)
    {
        var tests = await _context.RockTests
            .Include(r => r.Samples)
                .ThenInclude(r => r.Tester)
            .Include(r => r.Product)
            .Where(r =>
                r.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                r.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(r => r.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItems = tests.Count;

        return new QueryResult<RockTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task<QueryResult<RockTest>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _context.RockTests
            .Include(r => r.Samples)
                .ThenInclude(r => r.Tester)
            .Include(r => r.Product)
            .Where(r =>
                r.ProductId == productId &&
                r.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                r.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(r => r.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItems = tests.Count;

        return new QueryResult<RockTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task AddAsync(Product product, Tester tester, RockTest rockTest)
    {
        rockTest.Product = product;
        foreach (RockTestSample sample in rockTest.Samples)
        {
            sample.Tester = tester;
        }
        await _context.AddRangeAsync(rockTest);
    }
}
