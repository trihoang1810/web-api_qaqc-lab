namespace ChaQaQcLabApi.Services;

public class TesterService : ITesterService
{
    private readonly ITesterRepository _testerRepository;

    public TesterService(ITesterRepository testerRepository)
    {
        _testerRepository = testerRepository;
    }

    public async Task<IEnumerable<Tester>> GetAllAsync()
    {
        return await _testerRepository.GetAllAsync();
    }

    public async Task<Response<Tester>> GetByIdAsync(string id)
    {
        var employee = await _testerRepository.GetByIdAsync(id);

        if (employee is null)
        {
            var error = Error.NotFound("Employee", id);
            return new Response<Tester>(error);
        }

        return new Response<Tester>(employee);
    }
}
