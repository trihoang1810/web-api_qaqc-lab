namespace ChaQaQcLabApi.Services;

public class CurlingForceTestService : ICurlingForceTestService
{
    private readonly ICurlingForceTestRepository _curlingForceTestRepository;
    private readonly IProductRepository _productRepository;
    private readonly ITesterRepository _testerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CurlingForceTestService(ICurlingForceTestRepository curlingForceTestRepository, IProductRepository productRepository, ITesterRepository testerRepository, IUnitOfWork unitOfWork)
    {
        _curlingForceTestRepository = curlingForceTestRepository;
        _productRepository = productRepository;
        _testerRepository = testerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<QueryResult<CurlingForceTest>> GetAllAsync(TimeQuery query)
    {
        return await _curlingForceTestRepository.GetAllAsync(query);
    }

    public async Task<Response<QueryResult<CurlingForceTest>>> GetByProductIdAsync(string productId, TimeQuery query)
    {
        var tests = await _curlingForceTestRepository.GetByProductIdAsync(productId, query);

        if (tests is null)
        {
            var error = Error.NotFound("Product", productId);
            return new Response<QueryResult<CurlingForceTest>>(error);
        }

        return new Response<QueryResult<CurlingForceTest>>(tests);
    }

    public async Task<Response<CurlingForceTest>> PostAsync(CurlingForceTest resource, string employeeId)
    {
        try
        {
            var product = await _productRepository.GetByIdAsync(resource.ProductId);
            if (product is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<CurlingForceTest>(error);
            }

            var tester = await _testerRepository.GetByIdAsync(employeeId);
            if (tester is null)
            {
                var error = Error.BadRequest("404", "Product not found");
                return new Response<CurlingForceTest>(error);
            }

            await _curlingForceTestRepository.AddAsync(product, tester, resource);
            await _unitOfWork.CompleteAsync();
            return new Response<CurlingForceTest>(resource);
        }
        catch (Exception ex)
        {
            var error = Error.Unexpected(ex.Message);
            return new Response<CurlingForceTest>(error);
        }
    }
}
