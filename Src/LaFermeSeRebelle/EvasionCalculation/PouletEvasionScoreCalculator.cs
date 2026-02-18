namespace LaFermeSeRebelle.EvasionCalculation;

using LaFermeSeRebelle.Characteristics;

/// <summary>
/// Calcule le score d'évasion pour un poulet.
/// Formule : Vitesse * 0.6 + Hauteur de Saut * 0.2 + Motivation
/// </summary>
public sealed class PouletEvasionScoreCalculator : IEvasionScoreCalculator
{
    public decimal CalculerScore(IAnimalCharacteristics characteristics) =>
        characteristics.Vitesse * 0.6m + characteristics.HauteurDeSaut * 0.2m + characteristics.Motivation;
}
