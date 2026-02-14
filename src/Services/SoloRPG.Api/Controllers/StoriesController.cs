using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Stories.Commands;
using SoloRPG.Domain.Stories.Entities;
using SoloRPG.Domain.Stories.Services;

namespace SoloRPG.Api.Controllers;

[ApiController]
[Route("api/stories")]
public class StoriesController(StoryService storyService, DbContext dbContext) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateStoryCommand command, CancellationToken cancellationToken)
    {
        var createdStory = await storyService.CreateStoryAsync(command, cancellationToken);
        if (createdStory.Id is null)
            return BadRequest("Failed to create story.");
        return Ok(createdStory);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var story = await dbContext
            .Set<Story>()
            .Include(s => s.Chapters)
            .ThenInclude(c => c.Scenes)
            .FirstOrDefaultAsync(s => s.Id == id, cancellationToken);

        if (story is null)
            return NotFound();

        return Ok(story);
    }
}
