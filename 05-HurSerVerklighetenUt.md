## operativt

Kan tänkas det mesta vi gör är operativt.  
En läkare vill inte veta vilka mediciner en patient har av alla 10000 mediciner som har skrivits ut detta året. 
Hen vill veta bara denna patienten.

Typiskt GDB

(RDB är typiskt _alla_ mediciner och sedan minskar man datamängden)
..med GDB lägger vi till data i svaret istf filtrera bort..

## temporalt

Data som är fixerade i tiden. Exempelvis kvitton.  
Ett kvitto är utställt till någon oavsett om denna flyttar senare.  
Vi har fler; loggar av alla typer (kvitton är änna en log-post).

Typiskt DDB.


## administrativit och ekonomiskt

En gg i månaden, vid den magiska eller natulrlagbeskaffade sista-dagen-i-månaden, skall vi hämta ut data från många ställen.  
Då är inte svarstid lika kritisk.

Typiskt RDB.


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

