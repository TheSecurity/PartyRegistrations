using Microsoft.AspNetCore.Mvc;
using PartyRegistrations.Api.Models;
using PartyRegistrations.Api.Services;

namespace PartyRegistrations.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PartiesController : ControllerBase
{
    private readonly PartyService _partyService;

    public PartiesController(PartyService partyService)
    {
        _partyService = partyService;
    }

    [HttpGet("")]
    public IEnumerable<Party> GetParties(DateTime? dateFrom)
    {
        var parties = _partyService.GetParties(dateFrom);
        return parties;
    }

    [HttpPost("")]
    public IActionResult CreateParty(PartyUpdateModel model)
    {
        _partyService.AddParty(model.Name, model.Date);
        return Ok();
    }

    [HttpGet("{id}")]
    public ActionResult<Party?> GetParty(Guid id)
    {
        var party = _partyService.GetParty(id);

        if (party is null)
        {
            return NotFound();
        }

        return party;
    }

}
