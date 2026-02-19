namespace LaFermeSeRebelle.Animals;

using LaFermeSeRebelle.Characteristics;
using LaFermeSeRebelle.EvasionCalculation;
using LaFermeSeRebelle.Logging;
using LaFermeSeRebelle.Validation;

/// <summary>
/// Représente un canard de la ferme.
/// Responsabilité unique : orchestrer les composants d'un canard (nom, caractéristiques, calcul, logs).
/// </summary>
public sealed class Canard(string Nom, int Vitesse, int HauteurDeSaut, int Motivation)
    : AAnimalDeLaFerme(
        Nom,
        ValidateAndCreateCharacteristics(Vitesse, HauteurDeSaut, Motivation),
        EvasionScoreCalculatorFactory.CreerCalculateurCanard(),
        LogProviderFactory.CreerLogsCanard()), IAnimalDeLaFerme
{
    private static IAnimalCharacteristics ValidateAndCreateCharacteristics(int vitesse, int hauteurDeSaut, int motivation)
    {
        var characteristics = new AnimalCharacteristics(vitesse, hauteurDeSaut, motivation);
        var validator = CharacteristicsValidatorFactory.CreerValidateurCanard();
        validator.Validate(characteristics);
        return characteristics;
    }
}
