USE GD2C2014
GO
CREATE SCHEMA FUGAZZETA AUTHORIZATION gd
GO

---------------------------/*Creacion de Tablas*/-------------------------------------------
--------------------------------------------------------------------------------------------
CREATE TABLE FUGAZZETA.Hoteles(
Id_Hotel int identity(1,1) PRIMARY KEY,
Nombre nvarchar(40),
Mail nvarchar (70) check (Mail LIKE '%@%'),
Telefono numeric(20,0),
Calle varchar(70),
Nro_Calle numeric(6,0),
Ciudad varchar(50),
Pais varchar(50),
CantEstrella int,
Fec_Creacion date,
Recarga int,
Habilitado bit /* 1 Habilitado, 0 deshabilitado ...? */
)
go
CREATE TABLE FUGAZZETA.Roles(
Id_Rol int identity(1,1) PRIMARY KEY,
Nombre varchar(23) not null,
Estado bit
)
go
CREATE TABLE FUGAZZETA.Usuarios(
Username nvarchar(30) primary key,
Contraseña nvarchar(32),
Nombre varchar(50),
Apellido varchar(50),
Tipo_Doc varchar(5),
Nro_Doc numeric(11,0),
Mail nvarchar (70) check (Mail LIKE '%@%'),
Telefono numeric (20,0),
Calle varchar(70),
NroCalle numeric(6,0),
Fecha_Nac date,
CantFallos_Login int default 0,
Baja bit
)
go
CREATE TABLE FUGAZZETA.Clientes(
Id_Cliente int identity(1,1) PRIMARY KEY,
Nombre varchar (50),
Apellido varchar (50),
Tipo_Doc varchar(5),
Nro_Doc numeric (11,0),
Fecha_Nac date,
Mail nvarchar (70) check (Mail LIKE '%@%'),
Telefono numeric (20,0),
Dom_Calle varchar(70),
Nro_Calle numeric(6,0),
Piso numeric (3,0),
Depto varchar(4),
Localidad varchar(50),
Nacionalidad varchar(50),
Habilitado bit
)
go
CREATE TABLE FUGAZZETA.MovimientosHotel(
Id_Hotel int,
Fecha_Inicio date,
Fecha_Fin date,
Motivo varchar(140)
PRIMARY KEY (Id_Hotel,Fecha_Inicio),
FOREIGN KEY(Id_Hotel) REFERENCES FUGAZZETA.Hoteles
)
go
CREATE TABLE FUGAZZETA.[Usuarios x Hoteles](
Username nvarchar(30),
Id_Hotel int,
EstadoSesion bit,
PRIMARY KEY (Username,Id_Hotel),
FOREIGN KEY (Username) REFERENCES FUGAZZETA.Usuarios,
FOREIGN KEY (Id_Hotel) REFERENCES FUGAZZETA.Hoteles
)
go
CREATE TABLE FUGAZZETA.[Usuarios x Roles](
Username nvarchar(30),
Id_Rol int,
PRIMARY KEY (Username,Id_Rol),
FOREIGN KEY (Username) REFERENCES FUGAZZETA.Usuarios,
FOREIGN KEY (Id_Rol) REFERENCES FUGAZZETA.Roles
)
go
CREATE TABLE FUGAZZETA.Funcionalidades(
Id_Funcionalidad int IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(40)
)
go
CREATE TABLE FUGAZZETA.[Funcionalidades x Roles](
Id_Funcionalidad int,
Id_Rol int,
PRIMARY KEY (Id_Funcionalidad,Id_Rol),
FOREIGN KEY (Id_Funcionalidad) REFERENCES FUGAZZETA.Funcionalidades,
FOREIGN KEY (Id_Rol) REFERENCES FUGAZZETA.Roles
)
go





---------------------------/* Poblado de Datos*/--------------------------------------------
--------------------------------------------------------------------------------------------
INSERT INTO FUGAZZETA.Roles
values(1,'Administrador',1)
insert into FUGAZZETA.Roles values(2,'Recepcionista',1)
insert into FUGAZZETA.Roles values(3,'Guest',1)
go
INSERT INTO FUGAZZETA.Hoteles
(Calle, Ciudad, Nro_Calle, CantEstrella, Recarga)
SELECT DISTINCT
Hotel_Calle,
Hotel_Ciudad,
Hotel_Nro_Calle,
Hotel_CantEstrella,
Hotel_Recarga_Estrella 
FROM gd_esquema.Maestra
go
INSERT INTO FUGAZZETA.Clientes
(Nro_Doc,Apellido,Nombre,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto,Nacionalidad)
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
