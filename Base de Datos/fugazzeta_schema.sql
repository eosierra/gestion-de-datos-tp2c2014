USE GD2C2014
GO
CREATE SCHEMA FUGAZZETA AUTHORIZATION gd
GO

---------------------------/*Creacion de Tablas*/-------------------------------------------
--------------------------------------------------------------------------------------------
CREATE TABLE FUGAZZETA.Hoteles(
Id_Hotel int identity(1,1) PRIMARY KEY,
Nombre nvarchar(40),
Mail nvarchar (70),
Telefono numeric(20,0),
Calle varchar(70),
Nro_Calle numeric(6,0),
Ciudad varchar(50),
Pais varchar(50),
CantEstrella int,
Fec_Creacion date,
Recarga int,
Habilitado bit /* 1 Habilitado, 0 deshabilitado ...? */,
)
CREATE TABLE FUGAZZETA.Roles(
Id_Rol int identity(1,1) PRIMARY KEY,
Nombre varchar(23) not null,
Estado bit
)
CREATE TABLE FUGAZZETA.Usuarios(
Username nvarchar(30) primary key,
Contraseña nvarchar(32),
Nombre varchar(50),
Apellido varchar(50),
Tipo_Doc varchar(5),
Nro_Doc numeric(11,0),
Mail nvarchar (70),
Telefono numeric (20,0),
Calle varchar(70),
NroCalle numeric(6,0),
Fecha_Nac date,
CantFallos_Login int default 0,
Baja bit
)
CREATE TABLE FUGAZZETA.Clientes(
Id_Cliente int identity(1,1) PRIMARY KEY,
Nombre varchar (50),
Apellido varchar (50),
Tipo_Doc varchar(5),
Nro_Doc numeric (11,0),
Fecha_Nac date,
Mail nvarchar (70),
Telefono numeric (20,0),
Dom_Calle varchar(70),
Nro_Calle numeric(6,0),
Piso numeric (3,0),
Depto varchar(4),
Localidad varchar(50),
Nacionalidad varchar(50),
Habilitado bit
)
CREATE TABLE FUGAZZETA.MovimientosHotel(
Id_Hotel int FOREIGN KEY REFERENCES FUGAZZETA.Hoteles,
Fecha_Inicio date,
Fecha_Fin date,
Motivo varchar(140)
PRIMARY KEY (Id_Hotel,Fecha_Inicio)
)
CREATE TABLE FUGAZZETA.[Usuarios x Hoteles](
Username nvarchar(30),
Id_Hotel int,
EstadoSesion bit,
PRIMARY KEY (Username,Id_Hotel),
FOREIGN KEY (Username) REFERENCES FUGAZZETA.Usuarios,
FOREIGN KEY (Id_Hotel) REFERENCES FUGAZZETA.Hoteles
)
CREATE TABLE FUGAZZETA.[Usuarios x Roles](
Username nvarchar(30),
Id_Rol int,
PRIMARY KEY (Username,Id_Rol),
FOREIGN KEY (Username) REFERENCES FUGAZZETA.Usuarios,
FOREIGN KEY (Id_Rol) REFERENCES FUGAZZETA.Roles
)
CREATE TABLE FUGAZZETA.Funcionalidades(
Id_Funcionalidad int IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(40)
)
CREATE TABLE FUGAZZETA.[Funcionalidades x Roles](
Id_Funcionalidad int,
Id_Rol int,
PRIMARY KEY (Id_Funcionalidad,Id_Rol),
FOREIGN KEY (Id_Funcionalidad) REFERENCES FUGAZZETA.Funcionalidades,
FOREIGN KEY (Id_Rol) REFERENCES FUGAZZETA.Roles
)
CREATE TABLE FUGAZZETA.Regimenes(
Id_Regimen int identity(1,1) PRIMARY KEY,
Descripcion varchar(50),
Precio numeric (7,2),
Activo bit
)
CREATE TABLE FUGAZZETA.EstadosReserva(
Id_EstadoReserva INT IDENTITY(1,1) PRIMARY KEY,
Descripcion varchar(50)
)
CREATE TABLE FUGAZZETA.Reservas(
Id_Reserva int IDENTITY(1,1) PRIMARY KEY,
Id_Cliente int FOREIGN KEY REFERENCES FUGAZZETA.Clientes,
Id_Hotel int FOREIGN KEY REFERENCES FUGAZZETA.Hoteles,
Fecha_Reserva date,
Fecha_Inicio date,
Fecha_Egreso date,
Fecha_Fin_Reserva date,
Id_Regimen int FOREIGN KEY REFERENCES FUGAZZETA.Regimenes,
Id_EstadoReserva int FOREIGN KEY REFERENCES FUGAZZETA.EstadosReserva
)
CREATE TABLE FUGAZZETA.MovimientosReserva(
Id_Reserva int FOREIGN KEY REFERENCES FUGAZZETA.Reservas,
Proceso char,
Username nvarchar(30) FOREIGN KEY REFERENCES FUGAZZETA.Usuarios,
FechaMovimiento datetime,
Motivo nvarchar(140)
)
CREATE TABLE FUGAZZETA.[Acompañantes](
Id_Reserva int FOREIGN KEY REFERENCES FUGAZZETA.Reservas,
Id_Cliente int FOREIGN KEY REFERENCES FUGAZZETA.Clientes,
PRIMARY KEY (Id_Reserva,Id_Cliente)
)
CREATE TABLE FUGAZZETA.TiposHabitacion(
Id_TipoHab INT IDENTITY (1,1) PRIMARY KEY,
Descripcion varchar (80),
Porcentual numeric(5,2),
CantPersonas int,
CHECK (CantPersonas > 0)
)
CREATE TABLE FUGAZZETA.Facturas(
NroFactura int PRIMARY KEY,
Id_Hotel INT FOREIGN KEY REFERENCES FUGAZZETA.Hoteles,
Fecha date,
Total numeric (10,2),
Id_Cliente int FOREIGN KEY REFERENCES FUGAZZETA.Clientes
)
CREATE TABLE FUGAZZETA.[Items_Hospedaje](
NroFactura int FOREIGN KEY REFERENCES FUGAZZETA.Facturas,
Ocupadas char /* también puede ser Bit */,
CantNoches int,
Monto numeric (7,2),
PRIMARY KEY (NroFactura,Ocupadas),
CHECK (CantNoches >= 0)
)
CREATE TABLE FUGAZZETA.Consumibles(
Id_Consumible INT IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(50),
Precio numeric (7,2)
)
CREATE TABLE FUGAZZETA.[Items_Consumible](
NroFactura int FOREIGN KEY REFERENCES FUGAZZETA.Facturas,
Id_Consumible int FOREIGN KEY REFERENCES FUGAZZETA.Consumibles,
Cantidad int,
Monto numeric (7,2),
PRIMARY KEY (NroFactura,Id_Consumible),
CHECK (Cantidad > 0)
)
CREATE TABLE FUGAZZETA.TiposPago(
Id_TipoPago int IDENTITY (1,1) PRIMARY KEY,
Descripcion nvarchar(50)
)
CREATE TABLE FUGAZZETA.Bancos(
Id_Banco int identity (1,1) PRIMARY KEY,
Nombre nvarchar (50)
)
CREATE TABLE FUGAZZETA.AbonoFacturas(
NroFactura INT FOREIGN KEY REFERENCES FUGAZZETA.Facturas,
Id_TipoPago int FOREIGN KEY REFERENCES FUGAZZETA.TiposPago,
Id_Banco int FOREIGN KEY REFERENCES FUGAZZETA.Bancos,
TipoCuenta char,
NroCuenta int,
PRIMARY KEY (NroFactura)
)
CREATE TABLE FUGAZZETA.Habitaciones(
Id_Hotel int FOREIGN KEY REFERENCES FUGAZZETA.Hoteles,
Num_Habitacion int,
Piso int,
Frente char,
Id_TipoHab int FOREIGN KEY REFERENCES FUGAZZETA.TiposHabitacion,
Comodidades nvarchar (140),
Baja bit,
PRIMARY KEY (Id_Hotel, Num_Habitacion)
)
CREATE TABLE FUGAZZETA.HistorialHabitaciones(
Id_Hotel int,
Num_Habitacion int,
FechaOcupacion date,
CantNochesOcupada int,
CHECK (CantNochesOcupada > 0),
FOREIGN KEY (Id_Hotel,Num_Habitacion) REFERENCES FUGAZZETA.Habitaciones
)
CREATE TABLE FUGAZZETA.[Habitaciones x Reservas](
Id_Reserva int,
Id_Hotel int,
Num_Habitacion int,
PRIMARY KEY (Id_Reserva, Id_Hotel, Num_Habitacion),
FOREIGN KEY (Id_Reserva) REFERENCES FUGAZZETA.Reservas,
FOREIGN KEY (Id_Hotel,Num_Habitacion) REFERENCES FUGAZZETA.Habitaciones
)

go



--------------------------/* Poblado de Datos*/---------------------------------------------
--------------------------------------------------------------------------------------------

INSERT INTO FUGAZZETA.Roles
values('Administrador General',1)
insert into FUGAZZETA.Roles values('Administrador',1)
insert into FUGAZZETA.Roles values('Recepcionista',1)
insert into FUGAZZETA.Roles values('Guest',1)
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
UPDATE FUGAZZETA.Hoteles set Pais = 'Argentina'
INSERT INTO FUGAZZETA.Usuarios
(Username, Contraseña, CantFallos_Login, Baja) values ('admin','w23e',0,0)
INSERT INTO FUGAZZETA.[Usuarios x Roles] values ('admin',1)
go

--- HASTA ACÁ SE PUEDE EJECUTAR BIEN. HAY QUE ORGANIZARNOS DESPUÉS COMO VAMOS DESARROLLANDO.


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
