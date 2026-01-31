using SoloRPG.Application.DTOs;
using SoloRPG.Domain.Characters;

namespace SoloRPG.Application.Services;

public class CharacterService
{
    public CharacterSheet Create(string playerId, CreateCharacterDto dto)
    {
        var attributes = new Attributes
        {
            Forca = dto.Forca,
            Destreza = dto.Destreza,
            Constituicao = dto.Constituicao,
            Inteligencia = dto.Inteligencia,
            Sabedoria = dto.Sabedoria,
            Carisma = dto.Carisma
        };

        int maxHp = 20 + (attributes.Constituicao * 2);

        return new CharacterSheet
        {
            Id = Guid.NewGuid(),
            PlayerId = playerId,
            Name = dto.Name,
            Class = dto.Class,
            Level = 1,
            Attributes = attributes,
            MaxHP = maxHp,
            CurrentHP = maxHp,
            Defesa = 10 + attributes.Destreza,
            Mana = 10
        };
    }
}