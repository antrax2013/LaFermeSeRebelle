namespace LaFermeSeRebelle.Characteristics;

/// <summary>
/// Implémentation des caractéristiques d'un animal.
/// Respecte le Single Responsibility Principle.
/// </summary>
public sealed class AnimalCharacteristics(int vitesse, int hauteurDeSaut, int motivation) : IAnimalCharacteristics
{
    public int Vitesse { get; } = vitesse;

    public int HauteurDeSaut { get; } = hauteurDeSaut;

    public int Motivation { get; } = motivation;
}
