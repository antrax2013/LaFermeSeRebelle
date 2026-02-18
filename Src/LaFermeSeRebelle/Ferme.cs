using LaFermeSeRebelle.Animals;

namespace LaFermeSeRebelle;

public class Ferme(int Cloture, IEnumerable<IAnimalDeLaFerme> Animaux)
{
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
