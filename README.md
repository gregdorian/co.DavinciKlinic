# **co.DavinciKlinic
**
 Se realizo el proyecto Utilizando DDD con CodeFirst y en base de datos motor
Sql Server como el codigo realiza el script tambien se expone el Script que genera la migración.



Se realizo en el Backend c# con .NET 5.0 y ORM entity framework

La Nomenclatura se desarrolla de la siguiente manera
Para SOLUCION se especifica el prefijo co. que significa compañia a la que se desarrollo seguido de el nombre de la empresa.
ej:
    co.DavinciKlinic
    
     01-DavinciKlinicinfraestructureData 
     02-DavinciKlinic.Domain 
     03-DavinciKlinic.Services.Api 
     04-DavinciKlinic.Services.UI.Api 
     04.1-DavinciKlinic.Aplication
     05-DavinciKlinic.UI.Web 
     06-DavinciKlinic.Testing 
La Carpeta 01 indica la capa de persistencia a datos

La carpeta 02 indica la capa de dominio o negocio 

La carpeta 03 indica la capa de servicios distribuidos

La carpeta 04 indica la capa de servicio web Api

La carpeta 04.1 indica la capa de Facade o aplication

La carpeta 05 indica la capa de presentacion Web o Interfaz de Usuario

La carpeta 06 indica la capa de Testing

**NOTA** Por Simplicidad de la prueba solo se van a tomar los proyectos o capas de
     01-DavinciKlinicinfraestructureData 
     02-DavinciKlinic.Domain 
     05-DavinciKlinic.UI.Web 
     06-DavinciKlinic.Testing
     
**Patrones de Diseño**
- DTO
- Repositorio
- Inyeccion de Dependencias
- MVC
entre otros
