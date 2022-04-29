namespace ChaQaQcLabApi.Domain.Repositories;

public interface IForcedCloseTestRepository
{
    Task<QueryResult<ForcedCloseTest>> GetAllAsync(TimeQuery query);
    Task<QueryResult<ForcedCloseTest>> GetByProductIdAsync(string productId, TimeQuery query);
    Task AddAsync(Product product, Tester tester, ForcedCloseTest test);
}
