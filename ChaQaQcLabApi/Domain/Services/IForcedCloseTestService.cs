namespace ChaQaQcLabApi.Domain.Services;

public interface IForcedCloseTestService
{
    Task<QueryResult<ForcedCloseTest>> GetAllAsync(TimeQuery query);
    Task<Response<QueryResult<ForcedCloseTest>>> GetByProductIdAsync(string productId, TimeQuery query);
    Task<Response<ForcedCloseTest>> PostAsync(ForcedCloseTest test);
}
