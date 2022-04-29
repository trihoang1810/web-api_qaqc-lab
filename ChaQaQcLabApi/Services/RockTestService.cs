namespace ChaQaQcLabApi.Services;

public class RockTestService : IRockTestService
{
    private readonly IRockTestRepository _rockTestRepository;
    private readonly IProductRepository _productRepository;
    private readonly ITesterRepository _testerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RockTestService(IRockTestRepository rockTestRepository, IProductRepository productRepository, ITesterRepository testerRepository, IUnitOfWork unitOfWork)
    {
        _rockTestRepository = rockTestRepository;
        _productRepository = productRepository;
        _testerRepository = testerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<QueryResult<RockTest>> GetAllAsync(TimeQuery query)
    {
        return await _rockTestRepository.GetAllAsync(query);
    }

    public async Task<Response<QueryResult<RockTest>>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _rockTestRepository.GetByProductIdAsync(productId, query);

        if (tests is null)
        {
            var error = Error.NotFound("Product", productId);
            return new Response<QueryResult<RockTest>>(error);
        }

        return new Response<QueryResult<RockTest>>(tests);
    }
    public async Task<Response<RockTest>> PostAsync(RockTest resource)
    {
        try
        {
            var product = await _productRepository.GetByIdAsync(resource.ProductId);
            if (product is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<RockTest>(error);
            }

            var tester = await _testerRepository.GetByIdAsync(resource.EmployeeId);
            if (tester is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<RockTest>(error);
            }

            await _rockTestRepository.AddAsync(product, tester, resource);
            await _unitOfWork.CompleteAsync();
            return new Response<RockTest>(resource);
        }
        catch (Exception ex)
        {
            var error = Error.Unexpected(ex.Message);
            return new Response<RockTest>(error);
        }
    }
}
