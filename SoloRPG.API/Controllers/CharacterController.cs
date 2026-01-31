using Microsoft.AspNetCore.Mvc;
using SoloRPG.Application.Comandos;
using SoloRPG.Application.Services;

namespace SoloRPG.API.Controllers;

[ApiController]
[Route("api/character")]
public class CharacterController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] CriarPersonagemComando comando)
    {
        var playerId = Guid.NewGuid(); // depois vem do login
        var character = ServiçoDeCriaçãoDeFicha.CriarFicha(playerId,  comando);
        return Ok(character);
    }
}
