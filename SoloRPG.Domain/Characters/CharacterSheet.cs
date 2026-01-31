using SoloRPG.Domain.Rules;

namespace SoloRPG.Domain.Characters;

public class CharacterSheet
{
    public Guid Id { get; set; }
    public string PlayerId { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;
    public string Class { get; set; } = string.Empty;
    public int Level { get; set; } = 1;

    public Attributes Attributes { get; set; } = new();
    public List<Skill> Skills { get; set; } = new();

    public int MaxHP { get; set; }
    public int CurrentHP { get; set; }

    public int Defesa { get; set; }
    public int Mana { get; set; }

    public List<Condition> Conditions { get; set; } = new();
}