using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Campaigns.Commands;
using SoloRPG.Domain.Campaigns.Entities;
using SoloRPG.Domain.Campaigns.Services;

namespace SoloRPG.Api.Controllers;

[ApiController]
[Route("api/campaigns")]
public class CampaignsController(CampaignsService campaignsService, DbContext dbContext) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCampaignCommand command, CancellationToken cancellationToken)
    {
        var campaign = await campaignsService.CreateCampaignAsync(command, cancellationToken);
        if (campaign is null)
            return BadRequest("Couldn't create the campaign");
        return Ok(campaign);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute] Guid id)
    {
        var campaign = await dbContext.Set<Campaign>().Include(campaign => campaign.Story).FirstOrDefaultAsync(campaign => campaign.Id == id);
        return campaign is not null ? Ok(campaign) : NotFound();
    }
}
