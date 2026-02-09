using SoloRPG.Domain.Rules.Dtos;
using SoloRPG.Domain.Rules.Enums;

namespace SoloRPG.Domain.Rules.Services;

public class DiceTestService
{
    public static DiceTestResult Test(int bonus, int difficulty)
    {
        var result = DiceService.RollD20();
        var resultWithBonus = result + bonus;

        return new DiceTestResult
        {
            Result = result,
            TotalWithBonus = resultWithBonus,
            Difficulty = difficulty,
            Type = result switch
            {
                20 => DiceTestResultType.Critical,
                1 => DiceTestResultType.CriticalFailure,
                _ when resultWithBonus >= difficulty => DiceTestResultType.Success,
                _ => DiceTestResultType.Failure
            }
        };
    }
}
