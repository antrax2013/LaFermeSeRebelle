namespace LaFermeSeRebelle.Animals;

using LaFermeSeRebelle.Characteristics;
using LaFermeSeRebelle.EvasionCalculation;
using LaFermeSeRebelle.Logging;

/// <summary>
/// Classe abstraite de base pour tous les animaux de la ferme.
/// Responsabilité unique : représenter l'identité d'un animal et orchestrer ses composants.
/// Respecte le Liskov Substitution Principle (LSP) et le Single Responsibility Principle (SRP).
/// </summary>
public abstract class AAnimalDeLaFerme(
    string nom,
    IAnimalCharacteristics characteristics,
    IEvasionScoreCalculator scoreCalculator,
    ILogProvider logProvider) : IAnimalDeLaFerme
{
    /// <summary>
    /// Caractéristiques physiques et mentales de l'animal.
    /// </summary>
    protected IAnimalCharacteristics Characteristics { get; } = characteristics;

    /// <summary>
    /// Calculateur de score d'évasion spécifique à l'espèce.
    /// </summary>
    protected IEvasionScoreCalculator ScoreCalculator { get; } = scoreCalculator;

    /// <summary>
    /// Fournisseur de logs pour cet animal.
    /// </summary>
    protected ILogProvider LogProvider { get; } = logProvider;

    /// <summary>
    /// Nom unique de l'animal.
    /// </summary>
    public string Nom { get; init; } = nom;

    /// <summary>
    /// Message de log en cas d'échec d'évasion.
    /// </summary>
    public string LogDEchec => LogProvider.GenerateLogEchec(Nom);

    /// <summary>
    /// Message de log en cas de succès d'évasion.
    /// </summary>
    public string LogDEvasion => LogProvider.GenerateLogEvasion(Nom);

    /// <summary>
    /// Calcule le score d'évasion en utilisant le calculateur approprié.
    /// </summary>
    public decimal CalculerLeScoreDEvasion() => ScoreCalculator.CalculerScore(Characteristics);
}
