using SoloRPG.Domain.Sheets.Commands;
using SoloRPG.Domain.Sheets.Entities;

namespace SoloRPG.Application.Services;

public class SheetCreationService
{
    public static Sheet CreateSheet(Guid playerId, CreateSheetCommand command)
    {
        int maxLife = 20 + (command.Attributes.Constitution * 2);
        return new Sheet
        {
            PlayerId = playerId,
            Name = command.Name,
            Class = command.Class,
            Attributes = command.Attributes,
            MaxLife = maxLife,
            CurrentLife = maxLife,
            Defense = 10 + command.Attributes.Dexterity,
            Mana = 10
        };
    }
}
