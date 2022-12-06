using Microsoft.AspNetCore.Mvc;

namespace Lasmart.DotService.Backend;

[Route("api/[controller]")]
[ApiController]
public class DotController : ControllerBase
{
    readonly IDotRepository _dotRepository;

    public DotController(IDotRepository dotRepository)
    {
        _dotRepository = dotRepository;
    }

    [HttpGet]
    public ActionResult<List<Dot>> Get()
    {
        return Ok(_dotRepository.GetDots());
    }
}