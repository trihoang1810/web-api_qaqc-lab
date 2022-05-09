namespace ChaQaQcLabApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StaticLoadTestsController : Controller
{
    private readonly IStaticLoadTestService _staticLoadTestService;
    private readonly IMapper _mapper;

    public StaticLoadTestsController(IStaticLoadTestService staticLoadTestService, IMapper mapper)
    {
        _staticLoadTestService = staticLoadTestService;
        _mapper = mapper;
    }

    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetByProductIdAsync(string productId, [FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _staticLoadTestService.GetByProductIdAsync(productId, resource);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok(_mapper.Map<QueryResult<StaticLoadTest>, QueryResult<StaticLoadTestViewModel>>(result.Resource));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _staticLoadTestService.GetAllAsync(resource);

        return Ok(_mapper.Map<QueryResult<StaticLoadTest>, QueryResult<StaticLoadTestViewModel>>(result));
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(SaveStaticLoadViewModel resource)
    {
        var test = _mapper.Map<SaveStaticLoadViewModel, StaticLoadTest>(resource);

        var result = await _staticLoadTestService.PostAsync(test, resource.EmployeeId);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok("Static Load Test posted successfully");
    }
}
