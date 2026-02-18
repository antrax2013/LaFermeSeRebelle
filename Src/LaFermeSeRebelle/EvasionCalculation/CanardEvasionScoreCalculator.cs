namespace LaFermeSeRebelle.EvasionCalculation;

using LaFermeSeRebelle.Characteristics;

/// <summary>
/// Calcule le score d'évasion pour un canard.
/// Formule : Vitesse * 0.4 + Hauteur de Saut * 0.3 + Motivation
/// </summary>
public sealed class CanardEvasionScoreCalculator : IEvasionScoreCalculator
{
    public decimal CalculerScore(IAnimalCharacteristics characteristics) =>
        characteristics.Vitesse * 0.4m + characteristics.HauteurDeSaut * 0.3m + characteristics.Motivation;
}
