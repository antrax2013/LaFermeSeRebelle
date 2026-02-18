namespace LaFermeSeRebelle.Logging;

/// <summary>
/// Factory pour créer les fournisseurs de logs adaptés à chaque type d'animal.
/// Centralise la création et la gestion des stratégies de logging.
/// </summary>
public static class LogProviderFactory
{
    /// <summary>
    /// Crée un fournisseur de logs pour une chèvre.
    /// </summary>
    public static ILogProvider CreerLogsChevre() => new ChevreLogProvider();

    /// <summary>
    /// Crée un fournisseur de logs pour un poulet.
    /// </summary>
    public static ILogProvider CreerLogsPoulet() => new PouletLogProvider();

    /// <summary>
    /// Crée un fournisseur de logs pour un canard.
    /// </summary>
    public static ILogProvider CreerLogsCanard() => new CanardLogProvider();
}
