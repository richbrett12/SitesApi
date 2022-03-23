using Campsites.Services;

namespace Campsites.Controllers;

public class CampsitesController : ControllerBase
{
    private readonly SitesService _service;

    public CampsitesController(SitesService service)
    {
        _service = service;
    }

    [HttpGet("sites")]
    public async Task<ActionResult> GetSites()
    {
        var response = await _service.GetAsync();
        return Ok(new { data = response });
    }
}