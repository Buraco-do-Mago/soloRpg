using SoloRPG.Application.Comandos;
using SoloRPG.Domain.Personagens.Entidades;

namespace SoloRPG.Application.Services;

public class ServiçoDeCriaçãoDeFicha
{
    public static Ficha CriarFicha(Guid playerId, CriarPersonagemComando comando)
    {
        int vidaMáxima = 20 + (comando.Atributos.Constituição * 2);
        return new Ficha
        {
            PlayerId = playerId,
            Nome = comando.Nome,
            Classe = comando.Classe,
            Atributos = comando.Atributos,
            VidaMáxima = vidaMáxima,
            VidaAtual = vidaMáxima,
            Defesa = 10 + comando.Atributos.Destreza,
            Mana = 10
        };
    }
}
