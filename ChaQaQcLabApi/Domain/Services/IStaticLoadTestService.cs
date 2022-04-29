namespace ChaQaQcLabApi.Domain.Services;

public interface IStaticLoadTestService
{
    Task<QueryResult<StaticLoadTest>> GetAllAsync(TimeQuery query);
    Task<Response<QueryResult<StaticLoadTest>>> GetByProductIdAsync(string productId, TimeQuery query);
    Task<Response<StaticLoadTest>> PostAsync(StaticLoadTest test);
}
