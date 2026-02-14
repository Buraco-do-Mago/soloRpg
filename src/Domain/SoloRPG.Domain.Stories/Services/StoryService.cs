using BumaSoft.DependencyWizard.Services;
using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Stories.Commands;
using SoloRPG.Domain.Stories.Entities;

namespace SoloRPG.Domain.Stories.Services;

[Service]
public class StoryService(DbContext dbContext)
{
    public async Task<Story> CreateStoryAsync(CreateStoryCommand command, CancellationToken cancellationToken)
    {
        var story = new Story
        {
            Name = command.Name,
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow,
            Description = command.Description,
            Prompt = command.Prompt,
            Chapters = [.. command.Chapters.Select(c => new Entities.Chapter
            {
                Number = c.Number,
                Name = c.Name,
                Description = c.Description,
                Prompt = c.Prompt,
                Scenes = [.. c.Scenes.Select(s => new Entities.Scene
                {
                    Number = s.Number,
                    Name = s.Name,
                    Description = s.Description,
                    Prompt = s.Prompt
                })]
            })]
        };

        await dbContext.AddAsync(story, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        return story;
    }
}
