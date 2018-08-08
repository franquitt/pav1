
# Universidad Tecnológica Nacional
## Facultad Regional Córdoba
### Ingeniería en Sistemas de Información



## Programación de Aplicaciones Visuales 1: Proyecto Integrador


Profesores:

* Romero, María Soledad
* Figueroa, Rodolfo Alfredo
* Botta, Oscar Ernesto

Integrantes:

* AGRESTA, Franco [72622]
* LOZA, Leonardo [72964]
* VENTURI, Agustin [71943]


## Caso estudiado
Una Ferretería de la provincia de Córdoba desea solucionar 
diversos problemas relacionados con el control del stock, 
administración del personal, gestión de sus productos y sus 
respectivos proveedores. Para ello desea la realización de un 
sistema informático capaz de resolver los puntos especificados 
anteriormente. A continuación describiremos cómo trabaja el 
negocio, como así también la estructura del mismo.

La ferretería vende una gran variedad de **productos**, de los 
cuales se almacena la siguiente información: 

* Código
* Nombre
* Descripción 
* Precio
* Clasificación

Cada producto puede tener más de un **proveedor**. De estos se 
almacena:

* Apellido
* Nombre
* Dirección
* Teléfono
* Tiempo de entrega
* Precio.

Los productos se almacenan según **lotes**, los cuales se 
identifican con un número secuencial por producto. En un mismo 
momento puede haber varios lotes del mismo producto. Además se 
almacena de cada lote:

* Proveedor
* Stock inicial
* Stock actual
* Fecha de ingreso

Al vender un producto se genera una **factura**, la cual posee 
un número único, un tipo de factura (A, B, C, etc.), fecha, un 
cliente del cual se almacena: 
* Código
* Apellido
* Nombre
* Teléfono
* CUIT

y el **vendedor**, del cual se almacena:

* Legajo
* Fecha de ingreso
* Teléfono
* Edad
* Apellido
* Nombre

También se almacena el detalle de cada producto, la cantidad 
vendida, el lote del mismo y el precio al que se vendió.

Se ha realizado un diagrama de la posible base de datos que le 
daría solución a este trabajo:



