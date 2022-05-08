namespace ChaQaQcLabApi.Domain.Services;

public interface IWaterProofingTestService
{
    Task<QueryResult<WaterProofingTest>> GetAllAsync(TimeQuery query);
    Task<Response<QueryResult<WaterProofingTest>>> GetByProductIdAsync(string productId, TimeQuery query);
    Task<Response<WaterProofingTest>> PostAsync(WaterProofingTest test);
}
