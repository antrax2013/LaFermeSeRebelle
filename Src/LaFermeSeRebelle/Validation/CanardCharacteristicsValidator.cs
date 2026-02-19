namespace LaFermeSeRebelle.Validation;

using LaFermeSeRebelle.Characteristics;

/// <summary>
/// Validateur pour les canards.
/// Règles selon le README :
/// - Vitesse : 4 à 10
/// - Hauteur de Saut : 1 à 6
/// - Motivation : 0 à 2
/// </summary>
public sealed class CanardCharacteristicsValidator : ICharacteristicsValidator
{
    private const int MinVitesse = 4;
    private const int MaxVitesse = 10;
    private const int MinHauteurDeSaut = 1;
    private const int MaxHauteurDeSaut = 6;
    private const int MinMotivation = 0;
    private const int MaxMotivation = 2;

    public void Validate(IAnimalCharacteristics characteristics)
    {
        if (characteristics.Vitesse < MinVitesse || characteristics.Vitesse > MaxVitesse)
            throw new ArgumentException(
                $"La vitesse d'un canard doit être entre {MinVitesse} et {MaxVitesse}, reçu : {characteristics.Vitesse}",
                nameof(characteristics.Vitesse));

        if (characteristics.HauteurDeSaut < MinHauteurDeSaut || characteristics.HauteurDeSaut > MaxHauteurDeSaut)
            throw new ArgumentException(
                $"La hauteur de saut d'un canard doit être entre {MinHauteurDeSaut} et {MaxHauteurDeSaut}, reçu : {characteristics.HauteurDeSaut}",
                nameof(characteristics.HauteurDeSaut));

        if (characteristics.Motivation < MinMotivation || characteristics.Motivation > MaxMotivation)
            throw new ArgumentException(
                $"La motivation d'un canard doit être entre {MinMotivation} et {MaxMotivation}, reçu : {characteristics.Motivation}",
                nameof(characteristics.Motivation));
    }
}
