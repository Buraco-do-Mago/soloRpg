using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Sheets.Entities;
using SoloRPG.Domain.Stories.Entities;

namespace SoloRPG.Application.Data;

public class Database(DbContextOptions<Database> options) : DbContext(options)
{
    public DbSet<Sheet> Sheets { get; set; }
    public DbSet<Story> Stories { get; set; }
    public DbSet<Chapter> Chapters { get; set; }
    public DbSet<Scene> Scenes { get; set; }
}
