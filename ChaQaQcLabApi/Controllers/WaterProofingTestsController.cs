namespace ChaQaQcLabApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WaterProofingTestsController : Controller
{
    private readonly IWaterProofingTestService _waterProofingTestService;
    private readonly IMapper _mapper;

    public WaterProofingTestsController(IWaterProofingTestService waterProofingTestService, IMapper mapper)
    {
        _waterProofingTestService = waterProofingTestService;
        _mapper = mapper;
    }

    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetByProductIdAsync(string productId, [FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _waterProofingTestService.GetByProductIdAsync(productId, resource);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok(_mapper.Map<QueryResult<WaterProofingTest>, QueryResult<WaterProofingTestViewModel>>(result.Resource));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] TimeQueryViewModel query)
    {
        var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
        var result = await _waterProofingTestService.GetAllAsync(resource);

        return Ok(_mapper.Map<QueryResult<WaterProofingTest>, QueryResult<WaterProofingTestViewModel>>(result));
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(SaveWaterProofingTestViewModel resource)
    {
        var test = _mapper.Map<SaveWaterProofingTestViewModel, WaterProofingTest>(resource);

        var result = await _waterProofingTestService.PostAsync(test);

        if (!result.Success)
        {
            return BadRequest(result.Error);
        }

        return Ok("Water Proofing Test posted successfully");
    }
}
