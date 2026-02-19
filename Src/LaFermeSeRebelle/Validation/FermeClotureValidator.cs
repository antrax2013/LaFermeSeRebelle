namespace LaFermeSeRebelle.Validation;

/// <summary>
/// Validateur pour la clôture de la ferme.
/// Règles selon le README :
/// - Hauteur de la clôture : 8 à 14
/// </summary>
public sealed class FermeClotureValidator
{
    private const int MinClotureHeight = 8;
    private const int MaxClotureHeight = 14;

    /// <summary>
    /// Valide que la hauteur de la clôture respecte les règles.
    /// </summary>
    public void Validate(int clotureHeight)
    {
        if (clotureHeight < MinClotureHeight || clotureHeight > MaxClotureHeight)
            throw new ArgumentException(
                $"La hauteur de la clôture doit être entre {MinClotureHeight} et {MaxClotureHeight}, reçu : {clotureHeight}",
                nameof(clotureHeight));
    }
}
