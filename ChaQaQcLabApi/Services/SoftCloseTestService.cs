namespace ChaQaQcLabApi.Services;

public class SoftCloseTestService : ISoftCloseTestService
{
    private readonly ISoftCloseTestRepository _softCloseTestRepository;
    private readonly IProductRepository _productRepository;
    private readonly ITesterRepository _testerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public SoftCloseTestService(ISoftCloseTestRepository softCloseTestRepository, IProductRepository productRepository, ITesterRepository testerRepository, IUnitOfWork unitOfWork)
    {
        _softCloseTestRepository = softCloseTestRepository;
        _productRepository = productRepository;
        _testerRepository = testerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<QueryResult<SoftCloseTest>> GetAllAsync(TimeQuery query)
    {
        return await _softCloseTestRepository.GetAllAsync(query);
    }

    public async Task<Response<QueryResult<SoftCloseTest>>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _softCloseTestRepository.GetByProductIdAsync(productId, query);

        if (tests is null)
        {
            var error = Error.NotFound("Product", productId);
            return new Response<QueryResult<SoftCloseTest>>(error);
        }

        return new Response<QueryResult<SoftCloseTest>>(tests);
    }
    public async Task<Response<SoftCloseTest>> PostAsync(SoftCloseTest resource)
    {
        try
        {
            var product = await _productRepository.GetByIdAsync(resource.ProductId);
            if (product is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<SoftCloseTest>(error);
            }

            var tester = await _testerRepository.GetByIdAsync(resource.EmployeeId);
            if (tester is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<SoftCloseTest>(error);
            }

            await _softCloseTestRepository.AddAsync(product, tester, resource);
            await _unitOfWork.CompleteAsync();
            return new Response<SoftCloseTest>(resource);
        }
        catch (Exception ex)
        {
            var error = Error.Unexpected(ex.Message);
            return new Response<SoftCloseTest>(error);
        }
    }
}
