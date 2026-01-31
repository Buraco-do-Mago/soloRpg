using SoloRPG.Domínio.Fichas.Dtos;

namespace SoloRPG.Domínio.Fichas.Comandos;

public class CriarFichaComando
{
    public required string Nome { get; set; }
    public required string Classe { get; set; }
    public required Atributos Atributos { get; set; }
}
