using SoloRPG.Domain.Regras.Dtos;
using SoloRPG.Domain.Regras.Enumerados;

namespace SoloRPG.Domain.Regras.Serviços;

public class ServiçoDeTesteDeRolagemDeDados
{
    public static ResultadoDoTesteDeRolagemDeDados RolarTeste(int bônus, int dificuldade)
    {
        var resultadoDoDado = ServiçoDeRolagemDeDados.RolarD20();
        var resultadoDoDadoComBônus = resultadoDoDado + bônus;

        return new ResultadoDoTesteDeRolagemDeDados
        {
            ResultadoDoDado = resultadoDoDado,
            TotalComBônus = resultadoDoDadoComBônus,
            Dificuldade = dificuldade,
            Tipo = resultadoDoDado switch
            {
                20 => TipoDeResultadoDoTesteDeRolagemDeDados.Critico,
                1 => TipoDeResultadoDoTesteDeRolagemDeDados.FalhaCritica,
                _ when resultadoDoDadoComBônus >= dificuldade => TipoDeResultadoDoTesteDeRolagemDeDados.Sucesso,
                _ => TipoDeResultadoDoTesteDeRolagemDeDados.Falha
            }
        };
    }
}
