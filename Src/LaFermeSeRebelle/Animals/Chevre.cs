namespace LaFermeSeRebelle.Animals;

using LaFermeSeRebelle.Characteristics;
using LaFermeSeRebelle.EvasionCalculation;
using LaFermeSeRebelle.Logging;
using LaFermeSeRebelle.Validation;

/// <summary>
/// Représente une chèvre de la ferme.
/// Responsabilité unique : orchestrer les composants d'une chèvre (nom, caractéristiques, calcul, logs).
/// </summary>
public sealed class Chevre(string Nom, int Vitesse, int HauteurDeSaut, int Motivation)
    : AAnimalDeLaFerme(
        Nom,
        ValidateAndCreateCharacteristics(Vitesse, HauteurDeSaut, Motivation),
        EvasionScoreCalculatorFactory.CreerCalculateurChevre(),
        LogProviderFactory.CreerLogsChevre()), IAnimalDeLaFerme
{
    private static IAnimalCharacteristics ValidateAndCreateCharacteristics(int vitesse, int hauteurDeSaut, int motivation)
    {
        var characteristics = new AnimalCharacteristics(vitesse, hauteurDeSaut, motivation);
        var validator = CharacteristicsValidatorFactory.CreerValidateurChevre();
        validator.Validate(characteristics);
        return characteristics;
    }
}

