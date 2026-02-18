namespace LaFermeSeRebelle.Animals;

using LaFermeSeRebelle.Characteristics;
using LaFermeSeRebelle.EvasionCalculation;
using LaFermeSeRebelle.Logging;

/// <summary>
/// Représente un poulet de la ferme.
/// Responsabilité unique : orchestrer les composants d'un poulet (nom, caractéristiques, calcul, logs).
/// </summary>
public sealed class Poulet(string Nom, int Vitesse, int HauteurDeSaut, int Motivation)
    : AAnimalDeLaFerme(
        Nom,
        new AnimalCharacteristics(Vitesse, HauteurDeSaut, Motivation),
        EvasionScoreCalculatorFactory.CreerCalculateurPoulet(),
        LogProviderFactory.CreerLogsPoulet()), IAnimalDeLaFerme
{
}