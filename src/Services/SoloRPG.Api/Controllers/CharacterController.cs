using Microsoft.AspNetCore.Mvc;
using SoloRPG.Application.Services;
using SoloRPG.Domain.Sheets.Commands;

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
