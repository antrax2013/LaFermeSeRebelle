namespace LaFermeSeRebelle.Logging;

/// <summary>
/// Fournisseur de logs pour les canards.
/// Encapsule la logique de génération des messages spécifiques aux canards.
/// </summary>
public sealed class CanardLogProvider : ILogProvider
{
    public string GenerateLogEvasion(string nomAnimal) =>
        $"Le canard {nomAnimal} a pris son envol et a passé la clôture avec élégance.";

    public string GenerateLogEchec(string nomAnimal) =>
        $"Le canard {nomAnimal} a battu des ailes… puis s'est souvenu qu'il préférait marcher.";
}
