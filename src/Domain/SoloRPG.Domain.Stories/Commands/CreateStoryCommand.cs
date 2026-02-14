namespace SoloRPG.Domain.Stories.Commands;

public class CreateStoryCommand
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Prompt { get; set; }
    public required List<Chapter> Chapters { get; set; }
}

public class Chapter
{
    public int Number { get; set; }
    public string? Name { get; set; }
    public required string Description { get; set; }
    public required string Prompt { get; set; }
    public required List<Scene> Scenes { get; set; }
}

public class Scene
{
    public int Number { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public required string Prompt { get; set; }
}
