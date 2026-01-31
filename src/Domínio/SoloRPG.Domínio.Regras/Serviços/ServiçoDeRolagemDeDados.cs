namespace SoloRPG.Domain.Regras.Serviços;

public static class ServiçoDeRolagemDeDados
{
    private static readonly Random _random = new();

    public static int RolarD20() => _random.Next(1, 21);
}
