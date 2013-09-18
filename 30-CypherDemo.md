# Demo

## Setup, förberedelser

### Visa alla utom 0  
    start n=node(*) where ID(n) >= 1 return n;

### Radera först med relationer och sedan utan.
    start n=node(*) match n-[r]-() where ID(n) >= 1 DELETE n,r;
    start n=node(*) where ID(n) >= 1 delete n;

### Visa alla
    start n=node(*) return n;
    START n=node(*) return count(n);
    START r=rel(*) return count(r);

## Exekvera

    CREATE (n:Person { name : 'Ola' }) return n;
    CREATE (n:Person { name : 'BillG' }) return n;
    MATCH a:Person, b:Person Where a.name='Ola' and b.name='BillG' CREATE a-[r:FRIEND]->b Return r;

    // CREATE (n:Person { name : 'Adam' }) return n;
    // MATCH a:Person, b:Person Where a.name='Ola' and b.name='Adam' CREATE a-[r:FRIEND]->b Return r;
	MATCH o:Person where o.name='Ola' CREATE o-[r:FRIEND {strength:0.5}]->(n:Person{name:'Adam'}) return o,r,n;
    MATCH a:Person, b:Person Where a.name='Ola' and b.name='Adam' CREATE a<-[r:FRIEND]-b Return r;

    MATCH o:Person where o.name='Ola' CREATE o-[r1:FRIEND {strength:0.3}]->(n:Person{name:'Cecilia'})-[r2:FRIEND {strength:0.7}]->o return o,r1,n,r2;
	//CREATE (n:Person { name : 'Cecilia' }) return n;
    //MATCH a:Person, b:Person Where a.name='Ola' and b.name='Cecilia' CREATE a-[r:FRIEND]->b Return r;
    //MATCH a:Person, b:Person Where a.name='Ola' and b.name='Cecilia' CREATE b-[r:FRIEND]->a Return r;

## Vänner till Ola

    start n=node( 305 ) return n.name;
    //start o=node( 305 ) match o-[:FRIEND]->p return o, p;
    match (o:Person)-[:FRIEND]->p where o.name='Ola' return o, p;
    start o=node( 305 ) match o-[:FRIEND]->p-[:FRIEND]->o return o, p;
    start o=node(305) match o-[:FRIEND]->p-[r?:FRIEND]->o where r is null return o, p;

## Vidare

Sätt egenskap på relation.
    start o=node(305) match o-[r:FRIEND]->p where p.name='Adam' set r.strength=0.5 return o,r,p;
    start o=node(305) match p-[r:FRIEND]->o where p.name='Adam' set r.strength=0.5 return o,r,p;
    start o=node(305) match o-[r:FRIEND]->p where p.name='Cecilia' set r.strength=0.7 return o,r,p;
    start o=node(305) match p-[r:FRIEND]->o where p.name='Cecilia' set r.strength=0.3 return o,r,p;

    start o=node( 305) match o-[r1:FRIEND]->p-[r2:FRIEND]->o where has(r1.strength) and has(r2.strength) return o,r1,p,r2;
