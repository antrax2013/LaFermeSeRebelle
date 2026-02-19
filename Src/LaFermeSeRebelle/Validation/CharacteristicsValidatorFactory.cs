namespace LaFermeSeRebelle.Validation;

/// <summary>
/// Factory pour créer les validateurs de caractéristiques.
/// Responsabilité unique : instancier les bons validateurs par espèce.
/// </summary>
public static class CharacteristicsValidatorFactory
{
    /// <summary>
    /// Crée le validateur pour les chèvres.
    /// </summary>
    public static ICharacteristicsValidator CreerValidateurChevre() => new ChevreCharacteristicsValidator();

    /// <summary>
    /// Crée le validateur pour les poulets.
    /// </summary>
    public static ICharacteristicsValidator CreerValidateurPoulet() => new PouletCharacteristicsValidator();

    /// <summary>
    /// Crée le validateur pour les canards.
    /// </summary>
    public static ICharacteristicsValidator CreerValidateurCanard() => new CanardCharacteristicsValidator();
}
