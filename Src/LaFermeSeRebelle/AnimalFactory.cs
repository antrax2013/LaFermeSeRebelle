using LaFermeSeRebelle.Animals;

namespace LaFermeSeRebelle;

/// <summary>
/// Factory Pattern pour créer les animaux de la ferme.
/// Respecte le principe Single Responsibility (création centralisée).
/// </summary>
public static class AnimalFactory
{
    /// <summary>
    /// Crée une chèvre avec les paramètres spécifiés.
    /// </summary>
    public static Chevre CreerChevre(string nom, int vitesse, int hauteurDeSaut, int motivation) =>
        new(nom, vitesse, hauteurDeSaut, motivation);

    /// <summary>
    /// Crée un poulet avec les paramètres spécifiés.
    /// </summary>
    public static Poulet CreerPoulet(string nom, int vitesse, int hauteurDeSaut, int motivation) =>
        new(nom, vitesse, hauteurDeSaut, motivation);

    /// <summary>
    /// Crée un canard avec les paramètres spécifiés.
    /// </summary>
    public static Canard CreerCanard(string nom, int vitesse, int hauteurDeSaut, int motivation) =>
        new(nom, vitesse, hauteurDeSaut, motivation);
}
