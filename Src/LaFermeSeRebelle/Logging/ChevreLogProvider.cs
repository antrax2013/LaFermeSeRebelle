namespace LaFermeSeRebelle.Logging;

/// <summary>
/// Fournisseur de logs pour les chèvres.
/// Encapsule la logique de génération des messages spécifiques aux chèvres.
/// </summary>
public sealed class ChevreLogProvider : ILogProvider
{
    public string GenerateLogEvasion(string nomAnimal) =>
        $"La chèvre {nomAnimal} a franchi la clôture en lançant un regard de défi.";

    public string GenerateLogEchec(string nomAnimal) =>
        $"La chèvre {nomAnimal} a voulu sauter, mais a été distraite par une feuille appétissante.";
}
