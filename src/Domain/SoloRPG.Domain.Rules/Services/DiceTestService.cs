using SoloRPG.Domínio.Regras.Dtos;
using SoloRPG.Domínio.Regras.Enumerados;

namespace SoloRPG.Domínio.Regras.Serviços;

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
