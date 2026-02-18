namespace LaFermeSeRebelle.EvasionCalculation;

using LaFermeSeRebelle.Characteristics;

/// <summary>
/// Calcule le score d'évasion pour une chèvre.
/// Formule : Vitesse * 0.8 + Hauteur de Saut * 0.5 + Motivation
/// </summary>
public sealed class ChevreEvasionScoreCalculator : IEvasionScoreCalculator
{
    public decimal CalculerScore(IAnimalCharacteristics characteristics) =>
        characteristics.Vitesse * 0.8m + characteristics.HauteurDeSaut * 0.5m + characteristics.Motivation;
}
