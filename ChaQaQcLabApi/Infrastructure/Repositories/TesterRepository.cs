namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class TesterRepository : BaseRepository, ITesterRepository
{
    public TesterRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Tester>> GetAllAsync()
    {
        return await _context.Testers
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Tester> GetByIdAsync(string id)
    {
        return await _context.Testers
            .FirstOrDefaultAsync(e => e.EmployeeId == id);
    }
}
