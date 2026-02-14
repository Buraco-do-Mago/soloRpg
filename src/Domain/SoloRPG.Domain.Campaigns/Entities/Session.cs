using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Campaigns.Entities;

public class Session : IEntity
{
    public Guid? Id { get; set; }
    public required DateTime StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }
}
