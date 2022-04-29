namespace ChaQaQcLabApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CurlingForceTestsController : Controller
{
    private readonly ICurlingForceTestService _curlingForceTestService;
    private readonly IMapper _mapper;

    public CurlingForceTestsController(ICurlingForceTestService curlingForceTestService, IMapper mapper)
    {
        _curlingForceTestService = curlingForceTestService;
        _mapper = mapper;
    }

    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetByProductIdAsync(string productId, [FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _curlingForceTestService.GetByProductIdAsync(productId, resource);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok(_mapper.Map<QueryResult<CurlingForceTest>, QueryResult<CurlingForceTestViewModel>>(result.Resource));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _curlingForceTestService.GetAllAsync(resource);

        return Ok(_mapper.Map<QueryResult<CurlingForceTest>, QueryResult<CurlingForceTestViewModel>>(result));
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(SaveCurlingForceTestViewModel resource)
    {
        var test = _mapper.Map<SaveCurlingForceTestViewModel, CurlingForceTest>(resource);
        var productId = resource.ProductId;
        var employeeId = resource.EmployeeId;
        var result = await _curlingForceTestService.PostAsync(test);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok("Curling Force Test posted successfully");
    }
}
