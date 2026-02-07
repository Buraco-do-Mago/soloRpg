using SoloRPG.Domínio.Fichas.Dtos;

namespace SoloRPG.Domínio.Fichas.Comandos;

public class CreateSheetCommand
{
    public required string Name { get; set; }
    public required string Class { get; set; }
    public required Attributes Attributes { get; set; }
}
