namespace LaFermeSeRebelle.Animals;

using LaFermeSeRebelle.Characteristics;
using LaFermeSeRebelle.EvasionCalculation;
using LaFermeSeRebelle.Logging;
using LaFermeSeRebelle.Validation;

/// <summary>
/// Représente un poulet de la ferme.
/// Responsabilité unique : orchestrer les composants d'un poulet (nom, caractéristiques, calcul, logs).
/// </summary>
public sealed class Poulet(string Nom, int Vitesse, int HauteurDeSaut, int Motivation)
    : AAnimalDeLaFerme(
        Nom,
        ValidateAndCreateCharacteristics(Vitesse, HauteurDeSaut, Motivation),
        EvasionScoreCalculatorFactory.CreerCalculateurPoulet(),
        LogProviderFactory.CreerLogsPoulet()), IAnimalDeLaFerme
{
    private static IAnimalCharacteristics ValidateAndCreateCharacteristics(int vitesse, int hauteurDeSaut, int motivation)
    {
        var characteristics = new AnimalCharacteristics(vitesse, hauteurDeSaut, motivation);
        var validator = CharacteristicsValidatorFactory.CreerValidateurPoulet();
        validator.Validate(characteristics);
        return characteristics;
    }
}
