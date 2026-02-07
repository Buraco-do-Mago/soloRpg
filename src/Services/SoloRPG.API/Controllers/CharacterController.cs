using Microsoft.AspNetCore.Mvc;
using SoloRPG.Application.Services;
using SoloRPG.Domínio.Fichas.Comandos;

namespace SoloRPG.API.Controllers;

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
