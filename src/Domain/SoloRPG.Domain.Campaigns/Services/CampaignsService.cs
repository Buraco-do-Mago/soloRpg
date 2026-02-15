using BumaSoft.DependencyWizard.Services;
using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Campaigns.Commands;
using SoloRPG.Domain.Campaigns.Entities;
using SoloRPG.Domain.Stories.Entities;

namespace SoloRPG.Domain.Campaigns.Services;

[Service]
public class CampaignsService(DbContext dbContext)
{
    public async Task<Campaign?> CreateCampaignAsync(CreateCampaignCommand createCampaignCommand, CancellationToken cancellationToken)
    {
        var story = await dbContext
            .Set<Story>()
            .FirstOrDefaultAsync(story => story.Id == createCampaignCommand.StoryId, cancellationToken);
        if (story is null)
            return null;

        var campaign = new Campaign
        {
            Story = story,
            CreatedAt = DateTime.UtcNow
        };
        
        await dbContext.AddAsync(campaign, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        return campaign;
    }
}
