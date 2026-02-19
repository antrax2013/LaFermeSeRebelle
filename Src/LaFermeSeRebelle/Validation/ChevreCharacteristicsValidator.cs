namespace LaFermeSeRebelle.Validation;

using LaFermeSeRebelle.Characteristics;

/// <summary>
/// Validateur pour les chèvres.
/// Règles selon le README :
/// - Vitesse : 5 à 9
/// - Hauteur de Saut : 4 à 8
/// - Motivation : 0 à 3
/// </summary>
public sealed class ChevreCharacteristicsValidator : ICharacteristicsValidator
{
    private const int MinVitesse = 5;
    private const int MaxVitesse = 9;
    private const int MinHauteurDeSaut = 4;
    private const int MaxHauteurDeSaut = 8;
    private const int MinMotivation = 0;
    private const int MaxMotivation = 3;

    public void Validate(IAnimalCharacteristics characteristics)
    {
        if (characteristics.Vitesse < MinVitesse || characteristics.Vitesse > MaxVitesse)
            throw new ArgumentException(
                $"La vitesse d'une chèvre doit être entre {MinVitesse} et {MaxVitesse}, reçu : {characteristics.Vitesse}",
                nameof(characteristics.Vitesse));

        if (characteristics.HauteurDeSaut < MinHauteurDeSaut || characteristics.HauteurDeSaut > MaxHauteurDeSaut)
            throw new ArgumentException(
                $"La hauteur de saut d'une chèvre doit être entre {MinHauteurDeSaut} et {MaxHauteurDeSaut}, reçu : {characteristics.HauteurDeSaut}",
                nameof(characteristics.HauteurDeSaut));

        if (characteristics.Motivation < MinMotivation || characteristics.Motivation > MaxMotivation)
            throw new ArgumentException(
                $"La motivation d'une chèvre doit être entre {MinMotivation} et {MaxMotivation}, reçu : {characteristics.Motivation}",
                nameof(characteristics.Motivation));
    }
}
