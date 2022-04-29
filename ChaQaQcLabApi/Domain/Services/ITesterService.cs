namespace ChaQaQcLabApi.Domain.Services;

public interface ITesterService
{
    Task<IEnumerable<Tester>> GetAllAsync();
    Task<Response<Tester>> GetByIdAsync(string id);
}
