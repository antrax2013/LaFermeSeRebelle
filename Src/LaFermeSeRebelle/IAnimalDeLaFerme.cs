namespace LaFermeSeRebelle;

public interface IAnimalDeLaFerme
{
    string LogDEchec { get; }
    string LogDEvasion { get; }

    string Nom { get; }

    decimal CalculerLeScoreDEvasion();
}