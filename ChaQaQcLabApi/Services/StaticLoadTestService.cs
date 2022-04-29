namespace ChaQaQcLabApi.Services;

public class StaticLoadTestService : IStaticLoadTestService
{
    private readonly IStaticLoadTestRepository _staticLoadTestRepository;
    private readonly IProductRepository _productRepository;
    private readonly ITesterRepository _testerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public StaticLoadTestService(IStaticLoadTestRepository staticLoadTestRepository, IProductRepository productRepository, ITesterRepository testerRepository, IUnitOfWork unitOfWork)
    {
        _staticLoadTestRepository = staticLoadTestRepository;
        _productRepository = productRepository;
        _testerRepository = testerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<QueryResult<StaticLoadTest>> GetAllAsync(TimeQuery query)
    {
        return await _staticLoadTestRepository.GetAllAsync(query);
    }

    public async Task<Response<QueryResult<StaticLoadTest>>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _staticLoadTestRepository.GetByProductIdAsync(productId, query);

        if (tests is null)
        {
            var error = Error.NotFound("Product", productId);
            return new Response<QueryResult<StaticLoadTest>>(error);
        }

        return new Response<QueryResult<StaticLoadTest>>(tests);
    }
    public async Task<Response<StaticLoadTest>> PostAsync(StaticLoadTest resource)
    {
        try
        {
            var product = await _productRepository.GetByIdAsync(resource.ProductId);
            if (product is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<StaticLoadTest>(error);
            }

            var tester = await _testerRepository.GetByIdAsync(resource.EmployeeId);
            if (tester is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<StaticLoadTest>(error);
            }

            await _staticLoadTestRepository.AddAsync(product, tester, resource);
            await _unitOfWork.CompleteAsync();
            return new Response<StaticLoadTest>(resource);
        }
        catch (Exception ex)
        {
            var error = Error.Unexpected(ex.Message);
            return new Response<StaticLoadTest>(error);
        }
    }
}
