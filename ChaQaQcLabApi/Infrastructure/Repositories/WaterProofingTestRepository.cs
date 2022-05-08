namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class WaterProofingTestRepository : BaseRepository, IWaterProofingTestRepository
{
    public WaterProofingTestRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<QueryResult<WaterProofingTest>> GetAllAsync(TimeQuery query)
    {
        var tests = await _context.WaterProofingTests
            .Include(s => s.Samples)
            .Include(s => s.Product)
            .Include(s => s.Tester)
            .Where(s =>
                s.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                s.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(s => s.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItems = tests.Count;

        return new QueryResult<WaterProofingTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task<QueryResult<WaterProofingTest>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _context.WaterProofingTests
            .Include(s => s.Samples)
            .Include(s => s.Product)
            .Include(s => s.Tester)
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

        return new QueryResult<WaterProofingTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task AddAsync(Product product, Tester tester, WaterProofingTest waterProofingTest)
    {
        waterProofingTest.Product = product;
        waterProofingTest.Tester = tester;
        await _context.AddRangeAsync(waterProofingTest);
    }
}
