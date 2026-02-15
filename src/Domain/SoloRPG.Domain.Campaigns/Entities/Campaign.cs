using SoloRPG.Domain.Stories.Entities;
using SoloRPG.Infra.Interfaces;

namespace SoloRPG.Domain.Campaigns.Entities;

public class Campaign : IEntity
{
    public Guid? Id { get; set; }
    public required Story Story { get; set; }
    public required DateTime CreatedAt { get; set; }
    public List<Session>? Sessions { get; set; }
}
