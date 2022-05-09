namespace ChaQaQcLabApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SoftCloseTestsController : Controller
{
    private readonly ISoftCloseTestService _softCloseTestService;
    private readonly IMapper _mapper;

    public SoftCloseTestsController(ISoftCloseTestService softCloseTestService, IMapper mapper)
    {
        _softCloseTestService = softCloseTestService;
        _mapper = mapper;
    }

    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetByProductIdAsync(string productId, [FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _softCloseTestService.GetByProductIdAsync(productId, resource);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok(_mapper.Map<QueryResult<SoftCloseTest>, QueryResult<SoftCloseTestViewModel>>(result.Resource));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _softCloseTestService.GetAllAsync(resource);

        return Ok(_mapper.Map<QueryResult<SoftCloseTest>, QueryResult<SoftCloseTestViewModel>>(result));
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(SaveSoftCloseTestViewModel resource)
    {
        var test = _mapper.Map<SaveSoftCloseTestViewModel, SoftCloseTest>(resource);

        var result = await _softCloseTestService.PostAsync(test, resource.EmployeeId);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok("Soft Close Test posted successfully");
    }
}
