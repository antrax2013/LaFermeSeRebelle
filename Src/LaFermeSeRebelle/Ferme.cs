using LaFermeSeRebelle.Animals;
using LaFermeSeRebelle.Validation;

namespace LaFermeSeRebelle;

/// <summary>
/// Représente la ferme et gère les tentatives d'évasion des animaux.
/// Valide la hauteur de la clôture selon les règles du README.
/// </summary>
public class Ferme(int Cloture, IEnumerable<IAnimalDeLaFerme> Animaux)
{
    /// <summary>
    /// Hauteur de la clôture de la ferme (8 à 14).
    /// </summary>
    public int Cloture { get; } = ValidateClotureHeight(Cloture);

    /// <summary>
    /// Les animaux dans la ferme.
    /// </summary>
    public IEnumerable<IAnimalDeLaFerme> Animaux { get; } = Animaux;

    private static int ValidateClotureHeight(int clotureHeight)
    {
        var validator = new FermeClotureValidator();
        validator.Validate(clotureHeight);
        return clotureHeight;
    }

    /// <summary>
    /// Exécute les tentatives d'évasion de tous les animaux.
    /// </summary>
    public IEnumerable<string> TenterEvasions()
    {
        foreach (var animal in Animaux)
        {
            yield return animal.CalculerLeScoreDEvasion() > Cloture ?
                animal.LogDEvasion :
                animal.LogDEchec;
        }
    }
}


