namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class WaterProofingTestRepository : BaseRepository, IWaterProofingTestRepository
{
    public WaterProofingTestRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<QueryResult<WaterProofingTest>> GetAllAsync(TimeQuery query)
    {
        var tests = await _context.WaterProofingTests
            .Include(w => w.Samples)
                .ThenInclude(w => w.Tester)
            .Include(w => w.Product)
            .Where(w =>
                w.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                w.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(w => w.EndDate)
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
            .Include(w => w.Samples)
            .Include(w => w.Product)
            .Where(w =>
                w.ProductId == productId &&
                w.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                w.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(w => w.EndDate)
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
        foreach (WaterProofingTestSample sample in waterProofingTest.Samples)
        {
            sample.Tester = tester;
        }
        await _context.AddRangeAsync(waterProofingTest);
    }
}
