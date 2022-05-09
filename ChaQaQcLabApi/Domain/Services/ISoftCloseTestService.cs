namespace ChaQaQcLabApi.Domain.Services;

public interface ISoftCloseTestService
{
    Task<QueryResult<SoftCloseTest>> GetAllAsync(TimeQuery query);
    Task<Response<QueryResult<SoftCloseTest>>> GetByProductIdAsync(string productId, TimeQuery query);
    Task<Response<SoftCloseTest>> PostAsync(SoftCloseTest test, string employeeId);
}
