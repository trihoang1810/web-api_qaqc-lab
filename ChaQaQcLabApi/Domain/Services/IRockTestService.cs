namespace ChaQaQcLabApi.Domain.Services;

public interface IRockTestService
{
    Task<QueryResult<RockTest>> GetAllAsync(TimeQuery query);
    Task<Response<QueryResult<RockTest>>> GetByProductIdAsync(string productId, TimeQuery query);
    Task<Response<RockTest>> PostAsync(RockTest test);
}
