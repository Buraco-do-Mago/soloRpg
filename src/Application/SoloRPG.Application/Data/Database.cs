using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Sheets.Entities;

namespace SoloRPG.Application.Data;

public class Database(DbContextOptions<Database> options) : DbContext(options)
{
    public DbSet<Sheet> Sheets { get; set; }
}
