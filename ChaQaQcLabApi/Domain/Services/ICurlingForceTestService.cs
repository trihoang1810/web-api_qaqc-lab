namespace ChaQaQcLabApi.Domain.Services;

public interface ICurlingForceTestService
{
    Task<QueryResult<CurlingForceTest>> GetAllAsync(TimeQuery query);
    Task<Response<QueryResult<CurlingForceTest>>> GetByProductIdAsync(string productId, TimeQuery query);
    Task<Response<CurlingForceTest>> PostAsync(CurlingForceTest test, string employeeId);
}
