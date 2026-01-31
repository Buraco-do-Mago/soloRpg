namespace SoloRPG.Application.DTOs;

public class CreateCharacterDto
{
    public string Name { get; set; } = string.Empty;
    public string Class { get; set; } = string.Empty;

    public int Forca { get; set; }
    public int Destreza { get; set; }
    public int Constituicao { get; set; }
    public int Inteligencia { get; set; }
    public int Sabedoria { get; set; }
    public int Carisma { get; set; }
}