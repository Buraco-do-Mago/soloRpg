using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Sheets.Commands;
using SoloRPG.Domain.Sheets.Entities;
using SoloRPG.Domain.Sheets.Services;

namespace SoloRPG.Api.Controllers;

[ApiController]
[Route("api/sheets")]
public class SheetController(SheetCreationService sheetCreationService, DbContext dbContext) : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] CreateSheetCommand command)
    {
        var playerId = Guid.NewGuid();
        var character = sheetCreationService.CreateSheet(playerId, command);
        return Ok(character);
    }

    [HttpGet("/api/sheets/{id}")]
    public async Task<IActionResult> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        var sheet = await dbContext
            .Set<Sheet>()
            .Include(sheet => sheet.Attributes)
            .Include(sheet => sheet.Skills)
            .FirstOrDefaultAsync(sheet => sheet.Id == id, cancellationToken);
        if (sheet is null)
            return NotFound();
        return Ok(sheet);
    }
}
