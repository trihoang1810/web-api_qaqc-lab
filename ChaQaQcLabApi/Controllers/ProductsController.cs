namespace ChaQaQcLabApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : Controller
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductsController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    //[HttpGet]
    //public async Task<IActionResult> GetAllAsync([FromQuery] TimeQueryViewModel query)
    //{
    //    var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
    //    var result = await _productService.GetAllAsync(resource);

    //    return Ok(_mapper.Map<QueryResult<Product>, QueryResult<ProductViewModel>>(result));
    //}
}
