namespace ChaQaQcLabApi.Services;

public class ForcedCloseTestService : IForcedCloseTestService
{
    private readonly IForcedCloseTestRepository _forcedCloseTestRepository;
    private readonly IProductRepository _productRepository;
    private readonly ITesterRepository _testerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ForcedCloseTestService(IForcedCloseTestRepository forcedCloseTestRepository, IProductRepository productRepository, ITesterRepository testerRepository, IUnitOfWork unitOfWork)
    {
        _forcedCloseTestRepository = forcedCloseTestRepository;
        _productRepository = productRepository;
        _testerRepository = testerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<QueryResult<ForcedCloseTest>> GetAllAsync(TimeQuery query)
    {
        return await _forcedCloseTestRepository.GetAllAsync(query);
    }

    public async Task<Response<QueryResult<ForcedCloseTest>>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _forcedCloseTestRepository.GetByProductIdAsync(productId, query);

        if (tests is null)
        {
            var error = Error.NotFound("Product", productId);
            return new Response<QueryResult<ForcedCloseTest>>(error);
        }

        return new Response<QueryResult<ForcedCloseTest>>(tests);
    }
    public async Task<Response<ForcedCloseTest>> PostAsync(ForcedCloseTest resource, string employeeId)
    {
        try
        {
            var product = await _productRepository.GetByIdAsync(resource.ProductId);
            if (product is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<ForcedCloseTest>(error);
            }

            var tester = await _testerRepository.GetByIdAsync(employeeId);
            if (tester is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<ForcedCloseTest>(error);
            }

            await _forcedCloseTestRepository.AddAsync(product, tester, resource);
            await _unitOfWork.CompleteAsync();
            return new Response<ForcedCloseTest>(resource);
        }
        catch (Exception ex)
        {
            var error = Error.Unexpected(ex.Message);
            return new Response<ForcedCloseTest>(error);
        }
    }
}
