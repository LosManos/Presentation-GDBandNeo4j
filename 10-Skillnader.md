# Vad är skillnaden i modellen för en relations-, graf- och dokumentdatabas?  

## RDB

RDB - börjar med den för att "alla" känner till den.

Man utgår från all data i varje lista och filtrerar resultatet. Till slut har man en ny lista med data.

RDB är en sammanslagning av listor och mängdlära.  
Varje tabell är en lista.  
SQL är ett språk baserat på mängdlära. 

En RDB lagrar fyrkantig data. Tänk kalkylblad. Tänk listor.  
Mellan varje lista finns det relationer. De finns eller finns inte, det finns inga Gröna, IsA eller 3%-relationer.  

( SQL är ett mängbaserat språk.  Det finns ingen debugger. )

## GDB

I en GDB utgår man från varje nod.  
Sedan söker man ut mer data från den.

Typiskt:  
1)	Hitta en nod.
2)	Sök ut noder omkring som uppfyller villkor, t.ex. att noden har vissa attribut och att man kan hitta dit via en speciell relation.
3)	Hantera tabellen som kommer tillbaka.

## DDB

Öar av information.
Med länkar emellan.




Det är inte så att data är det ena eller det andra.
Jämför:
(när excel listar ut vilka fält som påverkar vilka använder den en graf)  
(debugger i sql stegar sig igenom steg, den kan inte beskriva mängderna)

## Schema

GDB är schema-lös. Bra eller dåligt.

# Frågor eller kommentarer på detta?

//
En kort förklaring, rätt eller fel, att vi ofta använder "fel" modell när vi lagrar data.
Ofta lagrar vi allt i 1 modell.