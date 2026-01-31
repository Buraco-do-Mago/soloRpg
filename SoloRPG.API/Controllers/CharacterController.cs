using Microsoft.AspNetCore.Mvc;
using SoloRPG.Application.DTOs;
using SoloRPG.Application.Services;

namespace SoloRPG.API.Controllers;

[ApiController]
[Route("api/character")]
public class CharacterController : ControllerBase
{
    private readonly CharacterService _service;

    public CharacterController(CharacterService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateCharacterDto dto)
    {
        string playerId = "PLAYER_TEST"; // depois vem do login

        var character = _service.Create(playerId, dto);
        return Ok(character);
    }
}