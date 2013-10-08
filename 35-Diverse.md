# Diverse

5 minuter.

## Några snabba

Skrivet i java

I Java-världen kan man köra inprocess och ha APi-anrop

neo4jspring

Annars rest-anrop

Version 2 på gång.

Open source

Svenskt

## Schema kontra osäkra modeller

Bra eller dåligt.  
Det finns ingen orsak, jag ser, att man inte kan ha en RDB utan schema och en DDB med schema.  
Skall man ha schema i databasen eller i ett lager över? - RDB är eventuellt för monolitisk.

## Vi är så himla vana vid RDB - VANA

Vi är så himla vana vid RDB att vi glömmer att det finns andra sätt att tänka.  
Innan SQL blev lingua franca pratade man på olika sätt med olika databaser.
Innan RDB vann databaskriget var det inte säkert att det var RDB man skulle använda.
En gång i tiden *ryser* fanns det något som hette DBA och de styrde med järnhand och sadism över datalagring och därmed alla andra. Idag har vi spridit ut denna kunskap mellan andra professioner som utvecklare, devops, arkitekter och sysops.

## ACID kontra BASE -  ACID KONTRA BASE

Behöver vi verkligen ACID?  
Transationer  - det finns många typer. Ta t.ex. när du köper en bok på Amazon. När du har beställt din bok är den inte på posten, den är kanske inte ens tryckt. Men du kan önska pengarna tillbaka långt senare. Denna transaktionen ligger inte öppen i en RDB utan är implementerad på ett helt annat sätt.
Loggning - visst skall CreatedBy- och ModifiedBy-fälten peka på en användare men är det kritiskt? I en medicinjournal - ja. I ett projekts todo-lista - knappast.

## Relationer

Idag är relationer en integrerad del av en RDB. Man kan istället tänka på databasen som ett gäng listor (med schema) och sedan har man ett abstraktionslager/plugin/modul ovanpå detta som är relationerna. Jämför MySQL där transaktioner inte ingick (ingår det idag?) i MySQL utan var ett tillägg.  

Man kan tänka sig att om man drar gränsen för databasen ovanför O/RMen är sättet man navigerar i RDB och GDB ganska lika. *Ganska lika*. Om man vill.
