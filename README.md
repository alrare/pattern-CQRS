## CQRS

El patron _CQRS_ ayuda a separar la lógica del sistema en escrituras y lecturas

<img width="715" alt="image1" src="https://github.com/alrare/pattern-CQRS/blob/main/PatternCQRS-1.drawio.png">

A través de un _API Gateway_ se mantiene un servicio de escritura y varios servicios de lectura (varios pods kubernetes escalamiento vertical u horizontal)

<img width="813" alt="image2" src="https://github.com/alrare/pattern-CQRS/assets/44535383/c62ac2bc-82d9-4f94-801e-11f1ddf894bf">

El uso de _CQRS_ va muy relacionado _Event Sourcing_ en la base de datos de escritura

<img width="843" alt="image3" src="https://github.com/alrare/pattern-CQRS/assets/44535383/bac515e3-2c84-4306-be8b-b3964471d6d3">

1. Lo ideal es que las base de datos esten separadas (escritura lectura)
2. Sincronización de bases de datos (escritura lectura) a través de _Patron Producer Consumer_ con un service bus
3. Se puede utilizar MediatR hace la función de un service bus pero en memoria para proyectos pequeños

### CASO DE USO
1. Creas un producto en la base de datos escritura (genera un evento) en el service bus
2. 
