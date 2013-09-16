# Verkligheten

(
Det är inte så att data är det ena eller det andra.
Jämför:
	Ett kalkylblad är typiskt kantigt - som en lista i en RDB.  
	Men när den listar ut vilka fält som påverkar vilka är det typiskt en graf.
)

## Det mesta operativa vi gör är grafbaserat.

Kan tänkas det mesta vi gör är operativt.  
En läkare vill inte veta vilka mediciner en patient har av alla 10000 mediciner som har skrivits ut detta året.  
Hen vill veta bara denna patienten.  
Hens tid är dyr. Patientens tid är viktig. Svarstider är viktigt. Det skall inte ta längre tid att hitta egenskaper hos en patient för att det är fler patienter på sjukhuset.  

Typiskt GDB

I en GDB utgår man från en nod och traverserar till andra noder; man har ett (litet) stycke data och hittar mer data utifrån det.

(
RDB är typiskt _alla_ mediciner och sedan minskar man datamängden
..med GDB lägger vi till data i svaret istf filtrera bort..
)

## Temporalt är saker som inte förändrar sig över tiden (bestämde jag precis)

Data som är fixerade i tiden. Exempelvis kvitton. Eller recept för en läkare.  
Ett kvitto är utställt till någon oavsett om denna flyttar senare.  
Vi har fler; loggar av alla typer (kvitton är änna en log-post).

Typiskt DDB.

DDBer är inte begränsade till temporal data - det var ett exempel på användningsområde.  

I en DDB har man något som ger tillbaka en klump med data.  

## Administrativit och ekonomiskt - typiskt listbaserat

En gg i månaden, vid den magiska eller natulrlagbeskaffade sista-dagen-i-månaden, skall vi hämta ut data från många ställen.  
Då är inte svarstid lika kritisk.

Typiskt RDB.

I en RDB har man mycket data och reducerar det.

(
Eventuellt kommer vi/jag i framtiden inte tycka detta.
)

# Frågor eller kommentarer på detta?

//

TODO:Flytta.

## blanda modeller, använd rätt verktyg

Typiskt faller vi tillbaka på RDB för att vi 1gg i månaden, tryggt på kontoret, i en säker miljö, med tillåtna fördröjningar
skall få det enkelt.

