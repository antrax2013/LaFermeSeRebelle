namespace LaFermeSeRebelle.Animals;

using LaFermeSeRebelle.Characteristics;
using LaFermeSeRebelle.EvasionCalculation;
using LaFermeSeRebelle.Logging;

/// <summary>
/// Représente une chèvre de la ferme.
/// Responsabilité unique : orchestrer les composants d'une chèvre (nom, caractéristiques, calcul, logs).
/// </summary>
public sealed class Chevre(string Nom, int Vitesse, int HauteurDeSaut, int Motivation)
    : AAnimalDeLaFerme(
        Nom,
        new AnimalCharacteristics(Vitesse, HauteurDeSaut, Motivation),
        EvasionScoreCalculatorFactory.CreerCalculateurChevre(),
        LogProviderFactory.CreerLogsChevre()), IAnimalDeLaFerme
{
}
