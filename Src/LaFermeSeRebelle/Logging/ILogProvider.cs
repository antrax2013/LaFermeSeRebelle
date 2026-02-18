namespace LaFermeSeRebelle.Logging;

/// <summary>
/// Fournisseur de logs pour les animaux.
/// Respecte le Strategy Pattern et le Single Responsibility Principle.
/// </summary>
public interface ILogProvider
{
    /// <summary>
    /// Génère le message de log en cas d'évasion réussie.
    /// </summary>
    string GenerateLogEvasion(string nomAnimal);

    /// <summary>
    /// Génère le message de log en cas d'échec d'évasion.
    /// </summary>
    string GenerateLogEchec(string nomAnimal);
}
