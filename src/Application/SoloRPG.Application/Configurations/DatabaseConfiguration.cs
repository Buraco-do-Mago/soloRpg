using SoloRPG.Application.Enums;

namespace SoloRPG.Application.Configurations;

public class DatabaseConfiguration
{
    public DatabaseType Type { get; set; }
    public required string Connection { get; set; }
}
