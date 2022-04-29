namespace ChaQaQcLabApi.Domain.Repositories;

public interface ITesterRepository
{
    Task<IEnumerable<Tester>> GetAllAsync();
    Task<Tester> GetByIdAsync(string id);
}
