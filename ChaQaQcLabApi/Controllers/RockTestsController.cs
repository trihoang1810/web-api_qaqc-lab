namespace ChaQaQcLabApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RockTestsController : Controller
{
    private readonly IRockTestService _rockTestService;
    private readonly IMapper _mapper;

    public RockTestsController(IRockTestService rockTestService, IMapper mapper)
    {
        _rockTestService = rockTestService;
        _mapper = mapper;
    }

    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetByProductIdAsync(string productId, [FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _rockTestService.GetByProductIdAsync(productId, resource);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok(_mapper.Map<QueryResult<RockTest>, QueryResult<RockTestViewModel>>(result.Resource));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _rockTestService.GetAllAsync(resource);

        return Ok(_mapper.Map<QueryResult<RockTest>, QueryResult<RockTestViewModel>>(result));
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(SaveRockTestViewModel resource)
    {
        var test = _mapper.Map<SaveRockTestViewModel, RockTest>(resource);

        var result = await _rockTestService.PostAsync(test);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok("Rock Test posted successfully");
    }
}
