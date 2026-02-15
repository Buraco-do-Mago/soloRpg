using SoloRPG.Domain.Sheets.Dtos;

namespace SoloRPG.Domain.Sheets.Commands;

public class CreateSheetCommand
{
    public required string Class { get; set; }
    public required Attributes Attributes { get; set; }
}
