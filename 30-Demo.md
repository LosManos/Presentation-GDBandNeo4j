# Demo

## Setup

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

CREATE (n:Person { name : 'Adam' }) return n;
MATCH a:Person, b:Person Where a.name='Ola' and b.name='Adam' CREATE a-[r:FRIEND]->b Return r;
MATCH a:Person, b:Person Where a.name='Ola' and b.name='Adam' CREATE b-[r:FRIEND]->a Return r;
CREATE (n:Person { name : 'Cecilia' }) return n;
MATCH a:Person, b:Person Where a.name='Ola' and b.name='Cecilia' CREATE a-[r:FRIEND]->b Return r;
MATCH a:Person, b:Person Where a.name='Ola' and b.name='Cecilia' CREATE b-[r:FRIEND]->a Return r;

## Vänner till Ola

start n=node( 305 ) return n.name
start o=node( 305 ) match o-[:FRIEND]->p return o, p;
start o=node( 305 ) match o-[:FRIEND]->p-[:FRIEND]->o return o, p;
start o=node(305) match o-[:FRIEND]->p-[r?:FRIEND]->o where r is null return o, p;

