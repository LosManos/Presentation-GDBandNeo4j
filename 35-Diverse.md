# Diverse

Skrivet i java

Man kan köra inprocess och ha APi-anrop

neo4jspring

Annars rest-anrop

Version 2 på gång?

Open source

Svenskt

## Schema

Bra eller dåligt.
Det finns ingen orsak, jag ser, att mana inte kan ha en RDB utan schema och en DDB med schema.

## Vi är så himla vana vid RDB

Vi är så himla vana vid RDB att vi glömmer att det finns andra sätt att tänka.  
Innan SQL blev lingua franca pratade man på olika sätt med olika databaser.
Innan RDB vann databaskriget var det inte säkert att det var RDB man skulle använda.
En gång i tiden *ryser* fanns det något som hette DBA och de styrde med järnhand och sadism över datalagring och därmed alla andra. Idag har vi spridit ut denna kunskap mellan andra professioner som utvecklare, devops, arkitekter och sysops.

## Relationer

Idag är relationer en integrerad del av en RDB. Man kan istället tänka på databasen som ett gäng listor (med schema) och sedan har man ett abstraktionslager/plugin/modul ovanpå detta som är relationerna. Jämför MySQL där transaktioner inte ingick (ingår det idag?) i MySQL utan var ett tillägg.  

Man kan tänka sig att om man drar gränsen för databasen ovanför O/RMen är sättet man navigerar i RDB och GDB ganska lika. *Ganska lika*. Om man vill.
