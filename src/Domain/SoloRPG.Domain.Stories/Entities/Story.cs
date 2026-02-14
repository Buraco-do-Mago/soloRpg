using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Stories.Entities;

public class Story : IEntity
{
    public Guid? Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Prompt { get; set; }
    public required List<Chapter> Chapters { get; set; }
}
