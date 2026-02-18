namespace LaFermeSeRebelle.Logging;

/// <summary>
/// Fournisseur de logs pour les poulets.
/// Encapsule la logique de génération des messages spécifiques aux poulets.
/// </summary>
public sealed class PouletLogProvider : ILogProvider
{
    public string GenerateLogEvasion(string nomAnimal) =>
        $"Le poulet {nomAnimal} bat des ailes frénétiquement, et est passé au‑delà de la clôture !";

    public string GenerateLogEchec(string nomAnimal) =>
        $"Le poulet {nomAnimal} court, prend son élan et raté.";
}
