namespace SoloRPG.Domain.Rules;

public static class DiceService
{
    private static readonly Random _random = new();

    public static int RollD20()
    {
        return _random.Next(1, 21);
    }

    public static DiceRollResult Test(int bonus, int difficulty)
    {
        int roll = RollD20();
        int total = roll + bonus;

        return new DiceRollResult
        {
            Roll = roll,
            Total = total,
            Success = total >= difficulty,
            Degree = roll switch
            {
                20 => "critico",
                1 => "falha_critica",
                _ when total >= difficulty => "sucesso",
                _ => "falha"
            }
        };
    }
}