namespace LaFermeSeRebelle;

public abstract class AAnimalDeLaFerme(string Nom) : IAnimalDeLaFerme
{
    public abstract string LogDEchec { get; }
    public abstract string LogDEvasion { get; }
    public string Nom { get; init; } = Nom;

    public abstract decimal CalculerLeScoreDEvasion();
}
