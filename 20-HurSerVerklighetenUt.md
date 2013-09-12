# Bild

Bild med tre delar. Vänster: en graf, mitten en dokumentdatabasrepresentation och till höger fyrkanter och streck som representerar RDB.
Man kan stå på olika sidor scen och berätta om de olika delarna/sätten att tänka.

# Prat

## operativt

Kan tänkas det mesta vi gör är operativt.  
En läkare vill inte veta vilka mediciner en patient har av alla 10000 mediciner som har skrivits ut detta året.  
Hen vill veta bara denna patienten.  
Hens tid är dyr. Svarstider är viktigt. Det skall inte ta längre tid att hitta egenskaper hos en patient för att det är fler patienter på sjukhuset.  

Typiskt GDB

I en GDB utgår man från en nod och traverserar till andra noder; man har ett (litet) stycke data och hittar mer data utifrån det.

(RDB är typiskt _alla_ mediciner och sedan minskar man datamängden)  
..med GDB lägger vi till data i svaret istf filtrera bort..

## temporalt

Data som är fixerade i tiden. Exempelvis kvitton. Eller recept för en läkare.  
Ett kvitto är utställt till någon oavsett om denna flyttar senare.  
Vi har fler; loggar av alla typer (kvitton är änna en log-post).

Typiskt DDB.

DDBer är inte begränsade till temporal data - det var ett exempel på användningsområde.  

I en DDB har man något som ger tillbaka en klump med data.  

## administrativit och ekonomiskt

En gg i månaden, vid den magiska eller natulrlagbeskaffade sista-dagen-i-månaden, skall vi hämta ut data från många ställen.  
Då är inte svarstid lika kritisk.

Typiskt RDB.

I en RDB har man mycket data och reducerar det.

# Frågor eller kommentarer på detta?

//

TODO:Flytta.
## osäkra modeller/schema
?? Flytta detta till var ??
Om vi får tydligt avgränsade data; dokument, böcker, (inte order för det liknar en transaktion) men vi inte vet hur de ser ut 
eller de är krångliga att modellera eller vi misstänker de kommer ändra sig med tiden.
Det finns ingen orsak, jag ser, att mana inte kan ha en RDB utan schema och en DDB med schema.

.. ACID vs BASE-eventual concictensy .. TODO:Flytta.

## blanda modeller, använd rätt verktyg

Typiskt faller vi tillbaka på RDB för att vi 1gg i månaden, tryggt på kontoret, i en säker miljö, med tillåtna fördröjningar
skall få det enkelt.
