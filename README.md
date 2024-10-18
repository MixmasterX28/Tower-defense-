# Eye of Evil tower defense

eye of evil is een drie lane tower defense waar je zelf de towers moet besturen en zelf met je muis kan aanvallen.
de game is endless dus het doel is om zo lang mogelijk levend te blijven en goed oplet op je cooldowns.

![Gamecap1](/TDfinal1.PNG)
![Gamecap2](/TDfinal2.PNG)

## Dry srp

[Mijn endless spawner](Tower%20defense%20Actual/Assets/Scripts/Enemies/EnemySpawner.cs)
 is SRP En DRY omdat de script alleen controle heeft over het inspawnen van nieuwe enemies,
ook zijn er geen repeats in de code door de InvokeRepeating die de hele tijd de code herhaalt om een endless enemy spawner te maken.

## Mappen structuur:

[ROOT Folder](https://github.com/MixmasterX28/Tower-defense-/tree/sprint2/Tower%20defense%20Actual)
 hier is de structuur van mijn mappen. Ik heb de mappen ingedeeld zodat ik makkelijk scripts, prefabs en textures kan vinden wanneer ik ze nodig heb.
 de mappen zijn ingedeeld per main mechanic en misc zijn voor objecten die niet precies ergens passen.

## builds:

Builds zijn als volgt:

Sprint 1: Unfinished protoype nog bezig met de pathfinding en enemies
Sprint 2: Finished Prototype met pathfinding en enemies

Eyes of Evil final build: de final build van mijn tower defense met alles uitgewerkt

## game design onderbouwing

** Game bevat torens die kunnen mikken en schieten op een bewegend doel **

Mijn torens kunnen niet mikken en schieten, in plaats daarvan hebben de toren een soort van AoE pulse aanval die damage kan doen tegen meerdere mensen.
ik heb een cooldown system gemaakt voor de toren om wat strategie te implementeren van wanneer je de torens kan gebruiken.
ik heb ook een player een soort van "Mobile tower" gegeven zodat ze zelf kunnen meedoen met enemies vermoorden om hun basis te verdedigen.

** je game bevat vernietigbare vijanden die 1 of meerdere paden volgen **

ik heb 1 enemy type die snel en eindeloze achter elkaar spawnen met snelle movement speed, deze enemies verdelen zich even door 3 verschillende paden die ze kunnen volgen.
de enemies die door het midden gaan zijn veel sneller bij de basis en zijn een prioriteit om te vermoorden en de enemies aan de zij kanten nemen langer om bij de basis te komen.

** je game bevat een wave systeem... **

De game heeft geen wave systeem, inplaats daarvan is het een endless systeem waar maar 1 enemy type in zit

** Een “health” systeem waarmee je levens kunt verliezen als vijanden hun doel bereiken en zodoende het spel kunt verliezen **

de enemies en de nexus (Basis van de player) hebben allebij een health systeem. de enemies hebben 100 health en als de health op is gaan ze dood en verwdijnen ze,
de basis heeft 3 health points en elke keer als een enemy de basis aanraakt dan gaan er een leven vanaf. als er 0 leven zijn dan gaat de game naar een game over screen.

[Game Over](/GameOver.PNG)