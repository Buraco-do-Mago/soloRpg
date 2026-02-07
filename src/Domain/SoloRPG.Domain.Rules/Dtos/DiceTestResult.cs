using SoloRPG.Domain.Rules.Enums;

namespace SoloRPG.Domain.Rules.Dtos;

public class DiceTestResult
{
    public int Result { get; set; }
    public int TotalWithBonus { get; set; }
    public int Difficulty { get; set; }
    public DiceTestResultType Type { get; set; }
}
