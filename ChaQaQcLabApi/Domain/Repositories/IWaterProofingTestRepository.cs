namespace ChaQaQcLabApi.Domain.Repositories;

public interface IWaterProofingTestRepository
{
    Task<QueryResult<WaterProofingTest>> GetAllAsync(TimeQuery query);
    Task<QueryResult<WaterProofingTest>> GetByProductIdAsync(string productId, TimeQuery query);
    Task AddAsync(Product product, Tester tester, WaterProofingTest test);
}
