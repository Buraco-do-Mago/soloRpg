using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Stories.Entities;

public class Chapter : IEntity
{
    public Guid? Id { get; set; }
    public int Number { get; set; }
    public string? Name { get; set; }
    public required string Description { get; set; }
    public required string Prompt { get; set; }
    public required List<Scene> Scenes { get; set; }
}
