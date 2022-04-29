namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class BaseRepository
{
    protected readonly ApplicationDbContext _context;
    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }
}
