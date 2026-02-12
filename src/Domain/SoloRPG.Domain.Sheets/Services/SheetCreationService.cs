using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Sheets.Commands;
using SoloRPG.Domain.Sheets.Entities;

namespace SoloRPG.Domain.Sheets.Services;

public class SheetCreationService(DbContext dbContext)
{
    public Sheet CreateSheet(Guid playerId, CreateSheetCommand command)
    {
        int maxLife = 20 + (command.Attributes.Constitution * 2);
        var sheet = new Sheet
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
        dbContext.Add(sheet);
        dbContext.SaveChanges();
        return sheet;
    }
}
