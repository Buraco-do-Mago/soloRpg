using SoloRPG.Domínio.Regras.Enumerados;

namespace SoloRPG.Domínio.Regras.Dtos;

public class DiceTestResult
{
    public int Result { get; set; }
    public int TotalWithBonus { get; set; }
    public int Difficulty { get; set; }
    public DiceTestResultType Type { get; set; }
}
