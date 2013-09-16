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
CREATE (n:Person { name : 'Charles' }) return n;
MATCH a:Person, b:Person Where a.name='Ola' and b.name='Charles' CREATE a-[r:FRIEND]->b Return r;
MATCH a:Person, b:Person Where a.name='Ola' and b.name='Charles' CREATE b-[r:FRIEND]->a Return r;
