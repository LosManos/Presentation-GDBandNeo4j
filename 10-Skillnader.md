# Vad är skillnaden i modellen för en relations-, graf- och dokumentdatabas?  

Ha en bild med RDB på ena sidan, GDB på andra och DDB i mitten.
Man kan stå på olika sidor scen och berätta om de olika delarna/sätten att tänka.

## RDB

### Består av listor och relationer. Dessa relationer har inga egenskaper.

RDB - börjar med den för att "alla" känner till den.

En RDB är i grund och botten ett gäng listor som hänger ihop med snören.  
Varje rad i listan kan ha relationer/snören till andra rader i andra listor. Dessa relationer har inga egenskaper. Antingen finns de eller så finns de inte.  De kan inte vara Gröna eller 90% och de har ingen riktning; de har en ägare men det är inte samma sak som riktning.

Så i grund och botten är en RDB ett gäng listor.  
Dessa listor har relationer mellan sig för att binda ihop listor - eller poster, beroende på hur man väljer att tänka.

### Utsökning går ut på att reducera datamängden, det innebär att data du inte är intresserad av påverkar prestanda.

Sedan har vi frågespråket; SQL.
Vi kan alla SQL så jag dröjer mig inte kvar med mer än en observation:  
En utsökning av data går ut på att välja vilka listor man vill hämta data från och sedan reducera dem.
Det innebär t.ex. att stora datamängder tar längre tid att hantera. *Data du inte är intresserad av påverkar prestanda!*

(
En RDB lagrar fyrkantig data. Tänk kalkylblad. Tänk listor.  
SQL är mängdbaserat.  
SQL saknar debugger. Det finns för att stega TSQL och PLSQL etc men själva i själva queryn kan man inte se varifrån data kommer.
)

## DDB

Endast kort, har ingen erfarenhet.

### Öar av information.  

Man kan se varje dokument i databasen som (ett träd med) data.  
Varje sådant dokument (eller träd) kan ha länkar mellan sig.

Ovanstående är inte 100% korrekt men detta föredrag handlar inte om DDB utan om GDB.

Det finns inget schema.

## GDB

### 3 saker består en GDB av.

En GDB består av Noder och Relationer.  
Noder och relationer kan ha egenskaper.
Relationer har en riktning.

Det finns inget schema.

### Nod och Relation, man får välja själv

En person är typiskt en Nod.  
En persons profession kan vara ett attribut *specialitet=ortoped.  
Men personen kan också ha en relation *specialitet* till en nod *Ortoped*.

### Queryspråket utgår från en nod och ökar datamängden.

I en GDB utgår man från en eller flera noder.  
Sedan söker man ut mer data från den.

Typiskt:  
1)	Hitta en nod.  
2)	Sök ut noder omkring som uppfyller villkor, t.ex. att noden har vissa attribut och att man kan hitta dit via en speciell relation.  
3)	Hantera tabellen som kommer tillbaka.  

### Gremlin traverserar noder

Gremlin är ett språk implementerat i flera GDB.  
Det är som ovan, man tar en nod, villkorar relationer, följer dem, hittar nya noder, och fortsätter så tills man har sitt resultat.  
Enkelt att tänka.

### I Cypher beskriver man hur resultatet skall se ut.

Cypher finns bara för Neo4j.  

I Cypher använder man ASCII-grafik för att beskriva hur man kan ta sig från en nod till en annan.
Sedan är det upp till Cypher-motorn att leta upp en lämplig väg; om det finns någon.


# Frågor eller kommentarer på detta?

//
En kort förklaring, rätt eller fel, att vi ofta använder "fel" modell när vi lagrar data.
Ofta lagrar vi allt i 1 modell.