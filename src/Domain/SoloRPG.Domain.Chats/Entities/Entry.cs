using SoloRPG.Domain.Characters.Entities;
using SoloRPG.Domain.Chats.Enums;
using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Chats.Entities;

public class Entry : IEntity
{
    public Guid? Id { get; set; }
    public SourceType Source { get; set; }
    public Character? Character { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required string Content { get; set; }
}
