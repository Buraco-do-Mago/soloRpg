using Microsoft.EntityFrameworkCore;

namespace SoloRPG.Domain.Sheets.Dtos;

[Owned]
public class Skill
{
    public required string Name { get; set; }
    public int Bonus { get; set; }
}
