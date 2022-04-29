namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class SoftCloseTestRepository : BaseRepository, ISoftCloseTestRepository
{
    public SoftCloseTestRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<QueryResult<SoftCloseTest>> GetAllAsync(TimeQuery query)
    {
        var tests = await _context.SoftCloseTests
            .Include(s => s.Samples)
            .Include(s => s.SeatLidExpectedOutcome)
            .Include(s => s.SeatRingExpectedOutcome)
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

        return new QueryResult<SoftCloseTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task<QueryResult<SoftCloseTest>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _context.SoftCloseTests
            .Include(s => s.Samples)
            .Include(s => s.SeatLidExpectedOutcome)
            .Include(s => s.SeatRingExpectedOutcome)
            .Include(s => s.Product)
            .Include(s => s.Tester)
            .Where(s =>
                s.ProductId == productId &&
                s.EndDate.CompareTo(query.TimeRange.StartTime.Value) >= 0 &&
                s.EndDate.CompareTo(query.TimeRange.StopTime.Value) <= 0)
            .OrderByDescending(s => s.EndDate)
            .AsNoTracking()
            .Skip((query.Page - 1) * query.ItemsPerPage)
            .Take(query.ItemsPerPage)
            .ToListAsync();

        int totalItems = tests.Count;

        return new QueryResult<SoftCloseTest>
        {
            Items = tests,
            TotalItems = totalItems
        };
    }

    public async Task AddAsync(Product product, Tester tester, SoftCloseTest softCloseTest)
    {
        softCloseTest.Product = product;
        softCloseTest.Tester = tester;
        await _context.AddRangeAsync(softCloseTest);
    }
}
