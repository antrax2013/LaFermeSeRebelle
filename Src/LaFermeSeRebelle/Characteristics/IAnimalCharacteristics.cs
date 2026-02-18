namespace LaFermeSeRebelle.Characteristics;

/// <summary>
/// Représente les caractéristiques physiques et mentales d'un animal.
/// Respecte le Single Responsibility Principle.
/// </summary>
public interface IAnimalCharacteristics
{
    /// <summary>
    /// Vitesse de l'animal (généralement 0-10).
    /// </summary>
    int Vitesse { get; }

    /// <summary>
    /// Hauteur de saut de l'animal (généralement 0-10).
    /// </summary>
    int HauteurDeSaut { get; }

    /// <summary>
    /// Motivation de l'animal (généralement 0-5).
    /// </summary>
    int Motivation { get; }
}
