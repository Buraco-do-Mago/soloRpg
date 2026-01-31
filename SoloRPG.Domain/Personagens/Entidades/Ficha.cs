using SoloRPG.Domain.Personagens.Dtos;
using SoloRPG.Domain.Regras.Flags;

namespace SoloRPG.Domain.Personagens.Entidades;

public class Ficha
{
    public Guid? Id { get; private set; }
    public required Guid PlayerId { get; set; }

    public required string Nome { get; set; }
    public required string Classe { get; set; }
    public int Nível { get; private set; } = 1;

    public Atributos Atributos { get; init; } = new();
    public List<Habilidade> Habilidades { get; private set; } = [];

    public int VidaMáxima { get; set; }
    public int VidaAtual { get; set; }

    public int Defesa { get; set; }
    public int Mana { get; set; }

    public Condições Condições { get; private set; } = new();
}
