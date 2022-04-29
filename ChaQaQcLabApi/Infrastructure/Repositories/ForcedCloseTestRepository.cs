namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class ForcedCloseTestRepository : BaseRepository, IForcedCloseTestRepository
{
    public ForcedCloseTestRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<QueryResult<ForcedCloseTest>> GetAllAsync(TimeQuery query)
    {
        var tests = await _context.ForcedCloseTests
            .Include(f => f.Samples)
            .Include(f => f.ExpectedOutcome)
            .Include(f => f.Product)
            .Include(f => f.Tester)
            .Where(f =>
                f.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                f.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(f => f.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItem = tests.Count;

        return new QueryResult<ForcedCloseTest>
        {
            Items = tests,
            TotalItems = totalItem,
        };
    }

    public async Task<QueryResult<ForcedCloseTest>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _context.ForcedCloseTests
            .Include(f => f.Samples)
            .Include(f => f.ExpectedOutcome)
            .Include(f => f.Product)
            .Include(f => f.Tester)
            .Where(f =>
                f.ProductId == productId &&
                f.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                f.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(f => f.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItems = tests.Count;

        return new QueryResult<ForcedCloseTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task AddAsync(Product product, Tester tester, ForcedCloseTest forcedCloseTest)
    {
        forcedCloseTest.Product = product;
        forcedCloseTest.Tester = tester;
        await _context.AddRangeAsync(forcedCloseTest);
    }
}
