using SoloRPG.Domain.Sheets.Entities;
using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Characters.Entities;

public class Character : IEntity
{
    public Guid? Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Backstory { get; set; }
    public required Sheet Sheet { get; set; }
}
