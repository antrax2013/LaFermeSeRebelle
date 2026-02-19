namespace LaFermeSeRebelle.Validation;

using LaFermeSeRebelle.Characteristics;

/// <summary>
/// Validateur pour les caractéristiques d'un animal.
/// Responsabilité unique : valider que les caractéristiques respectent les règles d'une espèce.
/// </summary>
public interface ICharacteristicsValidator
{
    /// <summary>
    /// Valide les caractéristiques et lève une exception si invalides.
    /// </summary>
    void Validate(IAnimalCharacteristics characteristics);
}
