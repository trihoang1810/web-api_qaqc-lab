namespace ChaQaQcLabApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ForcedCloseTestsController : Controller
{
    private readonly IForcedCloseTestService _forcedCloseTestService;
    private readonly IMapper _mapper;

    public ForcedCloseTestsController(IForcedCloseTestService forcedCloseTestService, IMapper mapper)
    {
        _forcedCloseTestService = forcedCloseTestService;
        _mapper = mapper;
    }

    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetByProductIdAsync(string productId, [FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _forcedCloseTestService.GetByProductIdAsync(productId, resource);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok(_mapper.Map<QueryResult<ForcedCloseTest>, QueryResult<ForcedCloseTestViewModel>>(result.Resource));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _forcedCloseTestService.GetAllAsync(resource);

        return Ok(_mapper.Map<QueryResult<ForcedCloseTest>, QueryResult<ForcedCloseTestViewModel>>(result));
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(SaveForcedCloseTestViewModel resource)
    {
        var test = _mapper.Map<SaveForcedCloseTestViewModel, ForcedCloseTest>(resource);

        var result = await _forcedCloseTestService.PostAsync(test, resource.EmployeeId);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok("Forced Close Test posted successfully");
    }
}
