using SoloRPG.Domínio.Fichas.Comandos;
using SoloRPG.Domínio.Fichas.Entidades;

namespace SoloRPG.Application.Serviços;

public class ServiçoDeCriaçãoDeFicha
{
    public static Ficha CriarFicha(Guid playerId, CriarFichaComando comando)
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
