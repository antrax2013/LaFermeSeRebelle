namespace LaFermeSeRebelle.Tests;

public sealed class Poulet(string Nom, int Vitesse, int HauteurDeSaut, int Motivation) : AAnimalDeLaFerme(Nom), IAnimalDeLaFerme
{
    public override string LogDEchec => throw new NotImplementedException();

    public override string LogDEvasion => throw new NotImplementedException();

    public override decimal CalculerLeScoreDEvasion()
    {
        throw new NotImplementedException();
    }
}