using SoloRPG.Domínio.Regras.Enumerados;

namespace SoloRPG.Domínio.Regras.Dtos;

public class ResultadoDoTesteDeRolagemDeDados
{
    public int ResultadoDoDado { get; set; }
    public int TotalComBônus { get; set; }
    public int Dificuldade { get; set; }
    public TipoDeResultadoDoTesteDeRolagemDeDados Tipo { get; set; }
}
