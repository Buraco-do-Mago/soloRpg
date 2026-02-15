using Microsoft.EntityFrameworkCore;
using SoloRPG.Domain.Campaigns.Entities;
using SoloRPG.Domain.Characters.Entities;
using SoloRPG.Domain.Chats.Entities;
using SoloRPG.Domain.Sheets.Entities;
using SoloRPG.Domain.Stories.Entities;

namespace SoloRPG.Application.Data;

public class Database(DbContextOptions<Database> options) : DbContext(options)
{
    public DbSet<Sheet> Sheets { get; set; }
    public DbSet<Story> Stories { get; set; }
    public DbSet<Chapter> Chapters { get; set; }
    public DbSet<Scene> Scenes { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Entry> ChatEntries { get; set; }
    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Character> Characters { get; set; }
}
