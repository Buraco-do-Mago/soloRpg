namespace SoloRPG.Domain.Rules;

public class DiceRollResult
{
    public int Roll { get; set; }
    public int Total { get; set; }
    public bool Success { get; set; }
    public string Degree { get; set; } = string.Empty;
}