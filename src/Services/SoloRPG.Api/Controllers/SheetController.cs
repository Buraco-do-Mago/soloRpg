using Microsoft.AspNetCore.Mvc;
using SoloRPG.Domain.Sheets.Commands;
using SoloRPG.Domain.Sheets.Services;

namespace SoloRPG.Api.Controllers;

[ApiController]
[Route("api/sheets")]
public class SheetController(SheetCreationService sheetCreationService) : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] CreateSheetCommand command)
    {
        var playerId = Guid.NewGuid();
        var character = sheetCreationService.CreateSheet(playerId, command);
        return Ok(character);
    }
}
