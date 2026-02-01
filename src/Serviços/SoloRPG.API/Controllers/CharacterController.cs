using Microsoft.AspNetCore.Mvc;
using SoloRPG.Application.Serviços;
using SoloRPG.Domínio.Fichas.Comandos;

namespace SoloRPG.API.Controllers;

[ApiController]
[Route("api/character")]
public class CharacterController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] CriarFichaComando comando)
    {
        var playerId = Guid.NewGuid(); // depois vem do login
        var character = ServiçoDeCriaçãoDeFicha.CriarFicha(playerId, comando);
        return Ok(character);
    }
}
