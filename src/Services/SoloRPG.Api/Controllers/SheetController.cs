using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Sheets.Commands;
using SoloRPG.Domain.Sheets.Entities;
using SoloRPG.Domain.Sheets.Services;

namespace SoloRPG.Api.Controllers;

[ApiController]
[Route("api/sheets")]
public class SheetController(SheetService sheetService, DbContext dbContext) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateSheetCommand command, CancellationToken cancellationToken)
    {
        var sheet = await sheetService.CreateSheetAsync(command, cancellationToken);
        if (sheet.Id is null)
            return BadRequest("Failed to create character sheet.");
        return Ok(sheet);
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
