using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Chats.Entities;

public class Chat : IEntity
{
    public Guid? Id { get; set; }
    public required List<Entry> Entries { get; set; }
}
