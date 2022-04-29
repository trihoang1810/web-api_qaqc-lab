namespace ChaQaQcLabApi.Domain.Repositories;

public interface IStaticLoadTestRepository
{
    Task<QueryResult<StaticLoadTest>> GetAllAsync(TimeQuery query);
    Task<QueryResult<StaticLoadTest>> GetByProductIdAsync(string productId, TimeQuery query);
    Task AddAsync(Product product, Tester tester, StaticLoadTest test);
}
