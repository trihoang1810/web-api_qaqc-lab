namespace ChaQaQcLabApi.Services;

public class WaterProofingTestService : IWaterProofingTestService
{
    private readonly IWaterProofingTestRepository _waterProofingTestRepository;
    private readonly IProductRepository _productRepository;
    private readonly ITesterRepository _testerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public WaterProofingTestService(IWaterProofingTestRepository waterProofingTestRepository, IProductRepository productRepository, ITesterRepository testerRepository, IUnitOfWork unitOfWork)
    {
        _waterProofingTestRepository = waterProofingTestRepository;
        _productRepository = productRepository;
        _testerRepository = testerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<QueryResult<WaterProofingTest>> GetAllAsync(TimeQuery query)
    {
        return await _waterProofingTestRepository.GetAllAsync(query);
    }

    public async Task<Response<QueryResult<WaterProofingTest>>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _waterProofingTestRepository.GetByProductIdAsync(productId, query);

        if (tests is null)
        {
            var error = Error.NotFound("Product", productId);
            return new Response<QueryResult<WaterProofingTest>>(error);
        }

        return new Response<QueryResult<WaterProofingTest>>(tests);
    }
    public async Task<Response<WaterProofingTest>> PostAsync(WaterProofingTest resource)
    {
        try
        {
            var product = await _productRepository.GetByIdAsync(resource.ProductId);
            if (product is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<WaterProofingTest>(error);
            }

            var tester = await _testerRepository.GetByIdAsync(resource.EmployeeId);
            if (tester is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<WaterProofingTest>(error);
            }

            await _waterProofingTestRepository.AddAsync(product, tester, resource);
            await _unitOfWork.CompleteAsync();
            return new Response<WaterProofingTest>(resource);
        }
        catch (Exception ex)
        {
            var error = Error.Unexpected(ex.Message);
            return new Response<WaterProofingTest>(error);
        }
    }
}
