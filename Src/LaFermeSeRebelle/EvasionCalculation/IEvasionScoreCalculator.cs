namespace LaFermeSeRebelle.EvasionCalculation;

using LaFermeSeRebelle.Characteristics;

/// <summary>
/// Calcule le score d'évasion d'un animal en fonction de ses caractéristiques.
/// Respecte le Single Responsibility Principle (responsabilité : calcul de score).
/// Strategy Pattern : chaque espèce d'animal a sa propre stratégie de calcul.
/// </summary>
public interface IEvasionScoreCalculator
{
    /// <summary>
    /// Calcule le score d'évasion basé sur les caractéristiques de l'animal.
    /// </summary>
    decimal CalculerScore(IAnimalCharacteristics characteristics);
}
