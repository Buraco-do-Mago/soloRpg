using SoloRPG.Domain.Personagens.Dtos;

namespace SoloRPG.Application.Comandos;

public class CriarPersonagemComando
{
    public required string Nome { get; set; }
    public required string Classe { get; set; }
    public required Atributos Atributos { get; set; }
}
