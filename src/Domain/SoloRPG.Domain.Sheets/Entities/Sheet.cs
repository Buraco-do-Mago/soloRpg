using SoloRPG.Domain.Sheets.Dtos;
using SoloRPG.Domain.Sheets.Flags;
using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Sheets.Entities;

public class Sheet : IEntity
{
    public Guid? Id { get; set; }

    public required string Name { get; set; }
    public required string Class { get; set; }
    public int Level { get; private set; } = 1;

    public Attributes Attributes { get; init; } = new();
    public List<Skill> Skills { get; private set; } = [];

    public int MaxLife { get; set; }
    public int CurrentLife { get; set; }

    public int Defense { get; set; }
    public int Mana { get; set; }

    public Conditions Conditions { get; private set; } = new();
}
