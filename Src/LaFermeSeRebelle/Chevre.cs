namespace LaFermeSeRebelle;

public sealed class Chevre(string Nom, int Vitesse, int HauteurDeSaut, int Motivation) : AAnimalDeLaFerme(Nom), IAnimalDeLaFerme
{
    public override string LogDEvasion { get => $"La chèvre {Nom} a franchi la clôture en lançant un regard de défi."; }

    public override string LogDEchec { get => $"La chèvre {Nom} a voulu sauter, mais a été distraite par une feuille appétissante."; }

    public override decimal CalculerLeScoreDEvasion()
    {
        return Vitesse * 0.8m + HauteurDeSaut * 0.5m + Motivation;
    }
}
