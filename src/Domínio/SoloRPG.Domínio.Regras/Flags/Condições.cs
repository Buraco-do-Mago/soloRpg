namespace SoloRPG.Domínio.Regras.Flags;

[Flags]
public enum Condições
{
    Ferido = 0,
    Cansado = 1,
    Envenenado = 2,
    Inconsciente = 4,
    Morto = 8
}
