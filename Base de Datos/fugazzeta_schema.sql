USE GD2C2014
go
CREATE SCHEMA FUGAZZETA AUTHORIZATION gd
go
GRANT CREATE TABLE TO gd
go

/* Creacion de Tablas
*/

--Hoteles
CREATE TABLE Hoteles(
Id int primary key,
Nombre varchar(40),
Mail varchar (40),
Telefono numeric(10,0),
Calle varchar(255),
NroCalle numeric(18,0),
CantEstrella int,
Ciudad varchar(50),
Pais varchar(50),
Fec_Creacion date,
Recarga int,
Habilitado bit)
go

CREATE TABLE Roles(
Id int unique,
Nombre varchar(23) not null,
Estado bit)
go

CREATE TABLE Usuarios(
Username varchar(30) primary key,
Contraseña varchar(20),
Nombre varchar(20),
Apellido varchar(25),
Tipo_Doc varchar(3),
Nro_Doc numeric(18,0),
Direccion varchar(50),
Fecha_Nac datetime,
Cant_FallosLogin int,
Baja bit)
go


/* Poblado de Datos*/
insert into Roles
values(1,'Administrador',1)
insert into Roles values(2,'Recepcionista',1)
insert into Roles values(3,'Guest',1)
go

insert into Hoteles
(Calle, Ciudad, NroCalle, CantEstrella, Recarga)
SELECT DISTINCT
Hotel_Calle,
Hotel_Ciudad,
Hotel_Nro_Calle,
Hotel_CantEstrella,
Hotel_Recarga_Estrella 
FROM gd_esquema.Maestra
go




----------------------------------------------
--Clientes
SELECT DISTINCT
Cliente_Pasaporte_Nro,
Cliente_Apellido,
Cliente_Nombre,
Cliente_Fecha_Nac,
Cliente_Mail,
Cliente_Dom_Calle,
Cliente_Nro_Calle,
Cliente_Piso,
Cliente_Depto,
Cliente_Nacionalidad
FROM gd_esquema.Maestra
go
