namespace ChaQaQcLabApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestersController : Controller
{
    private readonly ITesterService _testerService;
    private readonly IMapper _mapper;

    public TestersController(ITesterService testerService, IMapper mapper)
    {
        _testerService = testerService;
        _mapper = mapper;
    }

    //[HttpGet]
    //public async Task<IActionResult> GetAllAsync([FromQuery] TimeQueryViewModel query)
    //{
    //    var resource = _mapper.Map<TimeQueryViewModel, TimeQuery>(query);
    //    var result = await _testerService.GetAllAsync(resource);

    //    return Ok(_mapper.Map<QueryResult<Tester>, QueryResult<TesterViewModel>>(result));
    //}
}
