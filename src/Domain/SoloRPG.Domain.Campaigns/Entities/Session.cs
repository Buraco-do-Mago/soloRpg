using SoloRPG.Domain.Chats.Entities;
using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Campaigns.Entities;

public class Session : IEntity
{
    public Guid? Id { get; set; }
    public required DateTime StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }
    public required Chat MainChat { get; set; }
    public List<Chat>? Chats { get; set; }
}
