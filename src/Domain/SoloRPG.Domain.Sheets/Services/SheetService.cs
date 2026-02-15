using BumaSoft.DependencyWizard.Services;
using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Sheets.Commands;
using SoloRPG.Domain.Sheets.Entities;

namespace SoloRPG.Domain.Sheets.Services;

[Service]
public class SheetService(DbContext dbContext)
{
    public async Task<Sheet> CreateSheetAsync(CreateSheetCommand command, CancellationToken cancellationToken)
    {
        int maxLife = 20 + (command.Attributes.Constitution * 2);
        var sheet = new Sheet
        {
            Class = command.Class,
            Attributes = command.Attributes,
            MaxLife = maxLife,
            CurrentLife = maxLife,
            Defense = 10 + command.Attributes.Dexterity,
            Mana = 10
        };
        await dbContext.AddAsync(sheet, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
        return sheet;
    }
}
