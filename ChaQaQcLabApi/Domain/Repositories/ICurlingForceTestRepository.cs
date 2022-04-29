namespace ChaQaQcLabApi.Domain.Repositories;

public interface ICurlingForceTestRepository
{
    Task<QueryResult<CurlingForceTest>> GetAllAsync(TimeQuery query);
    Task<QueryResult<CurlingForceTest>> GetByProductIdAsync(string productId, TimeQuery query);
    Task AddAsync(Product product, Tester tester, CurlingForceTest test);
}
