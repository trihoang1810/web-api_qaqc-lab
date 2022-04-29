namespace ChaQaQcLabApi.Infrastructure.Repositories;

public class ProductRepository : BaseRepository, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Product> GetByIdAsync(string id)
    {
        return await _context.Products
            .FirstOrDefaultAsync(e => e.Id == id);
    }
}
