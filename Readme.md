# La ferme se rebelle
Bienvenue dans La ferme se rebelle, un petit kata C# où des poulets nerveux, des canards imprévisibles et des chèvres championnes olympique du saut — tentent de s’échapper.

Chaque animal possède sa propre personnalité, ses propres statistiques et une formule d'évasion unique.

Le fermier dispose d'un système de surveillance, qui loggue chaque tentative.

## Le but du jeu est simple :
Simuler un tour et voir quels animaux parviennent à s’évader.

# Les règles du jeu :
## Les caractèristiques des animaux
### 🐐 Les chèvre — les reines du saut
- Vitesse : 5 à 9
- Hauteur de Saut : 4 à 8
- Motivation : 0 à 3 
- Forumle du score d'évasion : Vitesse * 0.8 + Hauteur de Saut * 0.2 + Motivation
- Logs :

	✔ Succès : "La chèvre {Nom} a franchi la clôture en lançant un regard de défi."

	✖ Echec : "La chèvre {Nom} a voulu sauter, mais a été distraite par une feuille appétissante."

### 🐔 Les poulets — rapide, nerveux, imprévisible
- Vitesse : 4 à 10
- Hauteur de Saut : 1 à 6
- Le Motivation : 0 à 4 
- Forumle du score d'évasion : Vitesse * 0.6 + Hauteur de Saut * 0.2 + FacteurDeMotivation
- Logs : 

  ✔ Succès : "Le poulet {Nom} bat des ailes frénétiquement, et est passé au‑delà de la clôture !" 

  ✖ Echec : "Le poulet {Nom} court, prend son élan et raté."

### 🦆 Les canards — équilibré, parfois surprenant
- Vitesse : 4 à 10
- Hauteur de Saut : 1 à 6
- Le Motivation : 0 à 2 
- Forumle du score d'évasion : Vitesse * 0.4 + Hauteur de Saut * 0.3 + FacteurDeMotivation
- Logs :	
	✔ Succès : "Le canard {Nom} a pris son envol et a passé la clôture avec élégance."

	✖ Echec : "Le canard {Nom} a battu des ailes… puis s’est souvenu qu’il préférait marcher."

## La cloture de la ferme
- La hauteur de la cloture varie de 8 à 14


## 🔁 Déroulement d’un tour
Pour chacun, des animaux de la ferme :
- On calcule son score d'évasion en utilisant sa formule spécifique.
- On compare cette hauteur à la clôture :

  ✔ Succès : si le score d'évasion est supérieur à la hauteur de la clôture, l'animal s'évade.

  ✖ Echec : sinon, il reste dans la ferme.

- On loggue le résultat de chaque tentative.

# Scenarii de Test
## Cas demo : La chèvre Biquette tente sa chance
Clôture : 12
- 🐐 Biquette : Vitesse 8, Hauteur de saut 6, Motivation 3
On obtient le log : 
> "La chèvre Biquette a franchi la clôture en lançant un regard de défi."

## Cas 1 : “Paulette” — réussit à s’échapper
Clôture : 8
- 🐐 Marise, la chèvre : Vitesse 5, Hauteur de saut 6, Motivation 1
- 🐔 Paulette, le poulet : Vitesse 9, Hauteur de saut 4, Motivation 3
- 🦆 Gedeon, le canard : Vitesse 4, Hauteur de saut 5, Motivation 1

On obtient les logs suivants : 
>	"La chèvre Marise a voulu sauter, mais a été distraite par une feuille appétissante."

>	"Le poulet Paulette bat des ailes frénétiquement, et est passé au‑delà de la clôture !"

>	"Le canard Gedeon a battu des ailes… puis s’est souvenu qu’il préférait marcher."


# Objectifs
L'objectif de l'exercice est de proposer une solution la plus robuste, maintenable et évolutive possible car peut-être que dans le futur, d'autres animaux voudront tenter leur chance, ou que les règles d'évasion pourraient changer.

# Auteur
[![build](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/cyril-cophignon-b58b5a5b/)
