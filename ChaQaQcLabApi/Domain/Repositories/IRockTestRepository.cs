namespace ChaQaQcLabApi.Domain.Repositories;

public interface IRockTestRepository
{
    Task<QueryResult<RockTest>> GetAllAsync(TimeQuery query);
    Task<QueryResult<RockTest>> GetByProductIdAsync(string productId, TimeQuery query);
    Task AddAsync(Product product, Tester tester, RockTest test);
}
