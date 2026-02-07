namespace SoloRPG.Domain.Rules.Services;

public static class DiceService
{
    private static readonly Random _random = new();

    public static int RollD20() => _random.Next(1, 21);
}
