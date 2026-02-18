using LaFermeSeRebelle.Animals;

namespace LaFermeSeRebelle.Tests;

public class UnitTests
{
    [Test]
    public void CasDemo_Biquette_Se_Sauve()
    {
        // Given
        Ferme ferme = new(
            Cloture: 12,
            Animaux: [
                new Chevre(Nom: "Biquette", Vitesse: 9, HauteurDeSaut: 4, Motivation: 3)
            ]
        );

        // When
        var logs = ferme.TenterEvasions().ToList();

        // Then
        string expectedLog = "La chèvre Biquette a franchi la clôture en lançant un regard de défi.";
        string actualLog = logs.Single();
        Assert.That(actualLog, Is.EqualTo(expectedLog));
    }

    [Test]
    public void Cas1_Paulette_Reussi_A_S_Echapper()
    {
        // Given
        Ferme ferme = new(
            Cloture: 8,
            Animaux: [
                new Chevre(Nom: "Marise", Vitesse: 5, HauteurDeSaut: 6, Motivation: 1),
                new Poulet(Nom: "Paulette", Vitesse: 9, HauteurDeSaut: 4, Motivation: 3),
                new Canard(Nom: "Gedeon", Vitesse: 4, HauteurDeSaut: 5, Motivation: 1),
            ]
        );

        // When
        var logs = ferme.TenterEvasions().ToList();

        // Then
        var expectedLogs = new[] {
            "La chèvre Marise a voulu sauter, mais a été distraite par une feuille appétissante.",
            "Le poulet Paulette bat des ailes frénétiquement, et est passé au‑delà de la clôture !",
            "Le canard Gedeon a battu des ailes… puis s'est souvenu qu'il préférait marcher."
        };
        Assert.That(logs, Is.EquivalentTo(expectedLogs));
    }
}
