namespace ChaQaQcLabApi.Domain.Repositories;

public interface ISoftCloseTestRepository
{
    Task<QueryResult<SoftCloseTest>> GetAllAsync(TimeQuery query);
    Task<QueryResult<SoftCloseTest>> GetByProductIdAsync(string productId, TimeQuery query);
    Task AddAsync(Product product, Tester tester, SoftCloseTest test);
}
