namespace LaFermeSeRebelle.Animals;

using LaFermeSeRebelle.Characteristics;
using LaFermeSeRebelle.EvasionCalculation;
using LaFermeSeRebelle.Logging;

/// <summary>
/// Représente un canard de la ferme.
/// Responsabilité unique : orchestrer les composants d'un canard (nom, caractéristiques, calcul, logs).
/// </summary>
public sealed class Canard(string Nom, int Vitesse, int HauteurDeSaut, int Motivation)
    : AAnimalDeLaFerme(
        Nom,
        new AnimalCharacteristics(Vitesse, HauteurDeSaut, Motivation),
        EvasionScoreCalculatorFactory.CreerCalculateurCanard(),
        LogProviderFactory.CreerLogsCanard()), IAnimalDeLaFerme
{
}