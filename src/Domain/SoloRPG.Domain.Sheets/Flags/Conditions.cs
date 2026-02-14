namespace SoloRPG.Domain.Sheets.Flags;

[Flags]
public enum Conditions
{
    Hurt = 0,
    Tired = 1,
    Poisoned = 2,
    Unconscious = 4,
    Dead = 8
}
