namespace LaFermeSeRebelle.EvasionCalculation;

/// <summary>
/// Factory pour créer les calculateurs de score d'évasion.
/// Centralise la création et la gestion des stratégies de calcul.
/// </summary>
public static class EvasionScoreCalculatorFactory
{
    /// <summary>
    /// Crée un calculateur de score pour une chèvre.
    /// </summary>
    public static IEvasionScoreCalculator CreerCalculateurChevre() => new ChevreEvasionScoreCalculator();

    /// <summary>
    /// Crée un calculateur de score pour un poulet.
    /// </summary>
    public static IEvasionScoreCalculator CreerCalculateurPoulet() => new PouletEvasionScoreCalculator();

    /// <summary>
    /// Crée un calculateur de score pour un canard.
    /// </summary>
    public static IEvasionScoreCalculator CreerCalculateurCanard() => new CanardEvasionScoreCalculator();
}
