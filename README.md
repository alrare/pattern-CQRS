## CQRS

El patron _CQRS_ ayuda a separar la lógica del sistema en escrituras y lecturas

![Alternate image text](https://github.com/alrare/pattern-CQRS/blob/main/PatternCQRS-1.drawio.png)



A través de un _API Gateway_ se mantiene un servicio de escritura y varios servicios de lectura (varios pods kubernetes escalamiento vertical u horizontal)

![Alternate image text](https://github.com/alrare/pattern-CQRS/blob/main/PatternCQRS-2.drawio.png)



El uso de _CQRS_ va muy relacionado _Event Sourcing_ en la base de datos de escritura

![Alternate image text](https://github.com/alrare/pattern-CQRS/blob/main/PatternCQRS-3.drawio.png)


1. Lo ideal es que las base de datos esten separadas (escritura lectura)
2. Sincronización de bases de datos (escritura lectura) a través de _Patron Producer Consumer_ con un service bus
3. Se puede utilizar MediatR hace la función de un service bus pero en memoria para proyectos pequeños


### CASO DE USO
1. Creas un producto en la base de datos escritura (genera un evento) en el service bus 
2. Del service bus se hace un handler que incluya la información del nuevo producto creado y eventualmente escribirá en la base de datos lectura


![Alternate image text](https://github.com/alrare/pattern-CQRS/blob/main/PatternCQRS-4.drawio.png)

1. Producto con nombre
2. Descripción (Detalles del producto)
3. Stock       (Microservicio Almacén) 
4. Precio      (Microservicio Ventas)



