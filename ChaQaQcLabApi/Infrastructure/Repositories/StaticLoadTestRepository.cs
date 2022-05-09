namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class StaticLoadTestRepository : BaseRepository, IStaticLoadTestRepository
{
    public StaticLoadTestRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<QueryResult<StaticLoadTest>> GetAllAsync(TimeQuery query)
    {
        var tests = await _context.StaticLoadTests
            .Include(s => s.Samples)
                .ThenInclude(s => s.Tester)
            .Include(s => s.Product)
            .Where(s =>
                s.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                s.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(s => s.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItems = tests.Count;

        return new QueryResult<StaticLoadTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task<QueryResult<StaticLoadTest>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _context.StaticLoadTests
            .Include(s => s.Samples)
                .ThenInclude(s => s.Tester)
            .Include(s => s.Product)
            .Where(s =>
                s.ProductId == productId &&
                s.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                s.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(c => c.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItems = tests.Count;

        return new QueryResult<StaticLoadTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task AddAsync(Product product, Tester tester, StaticLoadTest staticLoadTest)
    {
        staticLoadTest.Product = product;
        foreach(StaticLoadTestSample sample in staticLoadTest.Samples)
        {
            sample.Tester = tester;
        }
        await _context.AddRangeAsync(staticLoadTest);
    }
}
