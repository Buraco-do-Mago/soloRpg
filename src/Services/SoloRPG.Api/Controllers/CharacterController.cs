using Microsoft.AspNetCore.Mvc;
using SoloRPG.Domain.Sheets.Commands;
using SoloRPG.Domain.Sheets.Services;

namespace SoloRPG.Api.Controllers;

[ApiController]
[Route("api/character")]
public class CharacterController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] CreateSheetCommand command)
    {
        var playerId = Guid.NewGuid();
        var character = SheetCreationService.CreateSheet(playerId, command);
        return Ok(character);
    }
}
