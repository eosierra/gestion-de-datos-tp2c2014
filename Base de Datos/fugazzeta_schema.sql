USE GD2C2014

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'FUGAZZETA')
BEGIN
	EXEC ('CREATE SCHEMA FUGAZZETA AUTHORIZATION gd')
END
GO

-----------------------------------/*Borrando Tablas */-------------------------------------
--------------------------------------------------------------------------------------------

IF OBJECT_ID('FUGAZZETA.AbonoFacturas') IS NOT NULL
DROP TABLE FUGAZZETA.AbonoFacturas

IF OBJECT_ID('FUGAZZETA.Acompañantes') IS NOT NULL
DROP TABLE FUGAZZETA.Acompañantes

IF OBJECT_ID('FUGAZZETA.Bancos') IS NOT NULL
DROP TABLE FUGAZZETA.Bancos

IF OBJECT_ID('FUGAZZETA.[Usuarios x Hoteles x Rol]') IS NOT NULL
DROP TABLE FUGAZZETA.[Usuarios x Hoteles x Rol]

IF OBJECT_ID('FUGAZZETA.TiposPago') IS NOT NULL
DROP TABLE FUGAZZETA.TiposPago

IF OBJECT_ID('FUGAZZETA.[Funcionalidades x Roles]') IS NOT NULL
DROP TABLE FUGAZZETA.[Funcionalidades x Roles]

IF OBJECT_ID('FUGAZZETA.Funcionalidades') IS NOT NULL
DROP TABLE FUGAZZETA.Funcionalidades

IF OBJECT_ID('FUGAZZETA.[Habitaciones x Reservas]') IS NOT NULL
DROP TABLE FUGAZZETA.[Habitaciones x Reservas]

IF OBJECT_ID('FUGAZZETA.HistorialHabitaciones') IS NOT NULL
DROP TABLE FUGAZZETA.HistorialHabitaciones

IF OBJECT_ID('FUGAZZETA.Items_Consumible') IS NOT NULL
DROP TABLE FUGAZZETA.Items_Consumible

IF OBJECT_ID('FUGAZZETA.Items_Hospedaje') IS NOT NULL
DROP TABLE FUGAZZETA.Items_Hospedaje

IF OBJECT_ID('FUGAZZETA.HistorialBajasHotel') IS NOT NULL
DROP TABLE FUGAZZETA.HistorialBajasHotel

IF OBJECT_ID('FUGAZZETA.MovimientosReserva') IS NOT NULL
DROP TABLE FUGAZZETA.MovimientosReserva

IF OBJECT_ID('FUGAZZETA.Usuarios') IS NOT NULL
DROP TABLE FUGAZZETA.Usuarios

IF OBJECT_ID('FUGAZZETA.Consumibles') IS NOT NULL
DROP TABLE FUGAZZETA.Consumibles

IF OBJECT_ID('FUGAZZETA.Facturas') IS NOT NULL
DROP TABLE FUGAZZETA.Facturas

IF OBJECT_ID('FUGAZZETA.Roles') IS NOT NULL
DROP TABLE FUGAZZETA.Roles

IF OBJECT_ID('tempdb.dbo.#Estadias') IS NOT NULL
DROP TABLE #Estadias

IF OBJECT_ID('FUGAZZETA.Reservas') IS NOT NULL
DROP TABLE FUGAZZETA.Reservas

IF OBJECT_ID('FUGAZZETA.EstadosReserva') IS NOT NULL
DROP TABLE FUGAZZETA.EstadosReserva

IF OBJECT_ID('FUGAZZETA.Clientes') IS NOT NULL
DROP TABLE FUGAZZETA.Clientes

IF OBJECT_ID('FUGAZZETA.TiposDoc') IS NOT NULL
DROP TABLE FUGAZZETA.TiposDoc

IF OBJECT_ID('FUGAZZETA.[Regimenes x Hotel]') IS NOT NULL
DROP TABLE FUGAZZETA.[Regimenes x Hotel]

IF OBJECT_ID('FUGAZZETA.Regimenes') IS NOT NULL
DROP TABLE FUGAZZETA.Regimenes

IF OBJECT_ID('FUGAZZETA.Habitaciones') IS NOT NULL
DROP TABLE FUGAZZETA.Habitaciones

IF OBJECT_ID('FUGAZZETA.TiposHabitacion') IS NOT NULL
DROP TABLE FUGAZZETA.TiposHabitacion

IF OBJECT_ID('FUGAZZETA.Hoteles') IS NOT NULL
DROP TABLE FUGAZZETA.Hoteles

IF OBJECT_ID('FUGAZZETA.Paises') IS NOT NULL
DROP TABLE FUGAZZETA.Paises

GO


--------------------/*Borrado de procedimientos,vistas*/------------------------------------
--------------------------------------------------------------------------------------------
--Views
IF OBJECT_ID('FUGAZZETA.[UsuariosHabilitados]') IS NOT NULL
DROP VIEW FUGAZZETA.[UsuariosHabilitados]

IF OBJECT_ID('FUGAZZETA.[TodosLosClientes]') IS NOT NULL
DROP VIEW FUGAZZETA.[TodosLosClientes]

IF OBJECT_ID('FUGAZZETA.ReservasNoCanceladas') IS NOT NULL
DROP VIEW FUGAZZETA.ReservasNoCanceladas

IF OBJECT_ID('FUGAZZETA.ReservasModificables') IS NOT NULL
DROP VIEW FUGAZZETA.ReservasModificables

IF OBJECT_ID('FUGAZZETA.ProximasHabitacionesReservadas') IS NOT NULL
DROP VIEW FUGAZZETA.ProximasHabitacionesReservadas

IF OBJECT_ID('FUGAZZETA.ClientesDuplicados') IS NOT NULL
DROP VIEW FUGAZZETA.ClientesDuplicados

--Functions

IF OBJECT_ID('FUGAZZETA.CostoHabitacion') IS NOT NULL
DROP FUNCTION FUGAZZETA.CostoHabitacion

IF OBJECT_ID('FUGAZZETA.PuntosFactura') IS NOT NULL
DROP FUNCTION FUGAZZETA.PuntosFactura

If OBJECT_ID('FUGAZZETA.FechaEgreso') IS NOT NULL
DROP FUNCTION FUGAZZETA.FechaEgreso

--Procedures
IF OBJECT_ID('FUGAZZETA.LoginCorrecto', 'P') IS NOT NULL
DROP PROCEDURE FUGAZZETA.LoginCorrecto

IF OBJECT_ID('FUGAZZETA.LoginIncorrecto', 'P') IS NOT NULL
DROP PROCEDURE FUGAZZETA.LoginIncorrecto

IF OBJECT_ID('FUGAZZETA.MigrarClientes') IS NOT NULL
DROP PROCEDURE FUGAZZETA.MigrarClientes

IF OBJECT_ID('FUGAZZETA.VerReservasHotelEnPeriodo') IS NOT NULL
DROP PROCEDURE FUGAZZETA.VerReservasHotelEnPeriodo

IF OBJECT_ID('FUGAZZETA.VerReservasHotel') IS NOT NULL
DROP PROCEDURE FUGAZZETA.OcupacionEnHotelEnPeriodo

IF OBJECT_ID('FUGAZZETA.CancelarReserva') IS NOT NULL
DROP PROCEDURE FUGAZZETA.CancelarReserva

IF OBJECT_ID('FUGAZZETA.MigrarReservas') IS NOT NULL
DROP PROCEDURE FUGAZZETA.MigrarReservas

IF OBJECT_ID('FUGAZZETA.OcupacionEnHotelEnPeriodo') IS NOT NULL
DROP PROCEDURE FUGAZZETA.OcupacionEnHotelEnPeriodo

IF OBJECT_ID('FUGAZZETA.RealizarIngreso') IS NOT NULL
DROP PROCEDURE FUGAZZETA.RealizarIngreso

IF OBJECT_ID('FUGAZZETA.CancelarPorNoShow') IS NOT NULL
DROP PROCEDURE FUGAZZETA.CancelarPorNoShow

IF OBJECT_ID('FUGAZZETA.HabitacionesLibresEnPeriodo') IS NOT NULL
DROP PROCEDURE FUGAZZETA.HabitacionesLibresEnPeriodo

IF OBJECT_ID('FUGAZZETA.GenerarReserva') IS NOT NULL
DROP PROCEDURE FUGAZZETA.GenerarReserva

IF OBJECT_ID('FUGAZZETA.Migrar_ItemsHospedaje') IS NOT NULL
DROP PROCEDURE FUGAZZETA.Migrar_ItemsHospedaje

IF OBJECT_ID('FUGAZZETA.ValidarEstadia') IS NOT NULL
DROP PROCEDURE FUGAZZETA.ValidarEstadia

IF OBJECT_ID('FUGAZZETA.VerHabitacionesDeEstadia') IS NOT NULL
DROP PROCEDURE FUGAZZETA.VerHabitacionesDeEstadia

IF OBJECT_ID('FUGAZZETA.RealizarEgreso') IS NOT NULL
DROP PROCEDURE FUGAZZETA.RealizarEgreso

IF OBJECT_ID('FUGAZZETA.RealizarModificacion') IS NOT NULL
DROP PROCEDURE FUGAZZETA.RealizarModificacion

IF OBJECT_ID('FUGAZZETA.ActualizarReserva') IS NOT NULL
DROP PROCEDURE FUGAZZETA.ActualizarReserva

IF OBJECT_ID('FUGAZZETA.GenerarFactura') IS NOT NULL
DROP PROCEDURE FUGAZZETA.GenerarFactura

IF OBJECT_ID('FUGAZZETA.VerFuncionalidadesEnHotel') IS NOT NULL
DROP PROCEDURE FUGAZZETA.VerFuncionalidadesEnHotel

--Triggers
IF OBJECT_ID('FUGAZZETA.TR_MovimientosHotel_A_I') IS NOT NULL
DROP TRIGGER FUGAZZETA.TR_MovimientosHotel_A_I

IF OBJECT_ID('FUGAZZETA.TR_Reservas_A_I') IS NOT NULL
DROP TRIGGER FUGAZZETA.TR_Reservas_A_I
GO


---------------------------/*Creacion de Tablas*/-------------------------------------------
--------------------------------------------------------------------------------------------
CREATE TABLE FUGAZZETA.Paises(
Id_Pais int identity(1,1) PRIMARY KEY,
Nombre varchar(40))

CREATE TABLE FUGAZZETA.Hoteles(
Id_Hotel int identity(1,1) PRIMARY KEY,
Nombre nvarchar(40),
Mail nvarchar (70),
Telefono numeric(20,0),
Calle varchar(70),
Nro_Calle numeric(6,0),
Ciudad varchar(50),
Pais int FOREIGN KEY REFERENCES FUGAZZETA.Paises,
CantEstrella int,
Fec_Creacion date,
Recarga int,
Habilitado bit DEFAULT 1
)
CREATE TABLE FUGAZZETA.Roles(
Id_Rol int identity(1,1) PRIMARY KEY,
Nombre varchar(23) not null,
Estado bit DEFAULT 1
)

CREATE TABLE FUGAZZETA.TiposDoc(
Id_TipoDoc int IDENTITY(1,1) PRIMARY KEY,
Descripcion varchar(30))

CREATE TABLE FUGAZZETA.Usuarios(
Username nvarchar(30) primary key,
Contraseña nvarchar(200),
Nombre varchar(50),
Apellido varchar(50),
Id_TipoDoc int FOREIGN KEY REFERENCES FUGAZZETA.TiposDoc,
Nro_Doc numeric(11,0),
Mail nvarchar (70),
Telefono numeric (20,0),
Calle varchar(70),
NroCalle numeric(6,0),
Fecha_Nac date,
CantFallos_Login int default 0,
Habilitado bit DEFAULT 1
)
CREATE TABLE FUGAZZETA.Clientes(
Id_Cliente int identity(1,1) PRIMARY KEY,
Nombre varchar (50),
Apellido varchar (50),
Id_TipoDoc int FOREIGN KEY REFERENCES FUGAZZETA.TiposDoc,
Nro_Doc numeric (11,0),
Fecha_Nac date,
Mail nvarchar (70),
Telefono numeric (20,0),
Dom_Calle varchar(70),
Nro_Calle numeric(6,0),
Piso numeric (3,0),
Depto varchar(4),
Localidad varchar(50),
PaisOrigen int FOREIGN KEY REFERENCES FUGAZZETA.Paises,
Nacionalidad int FOREIGN KEY REFERENCES FUGAZZETA.Paises,
Habilitado bit default 1,
)

CREATE TABLE FUGAZZETA.HistorialBajasHotel(
Id_Hotel int FOREIGN KEY REFERENCES FUGAZZETA.Hoteles,
Fecha_Inicio date,
Fecha_Fin date,
Motivo varchar(140)
PRIMARY KEY (Id_Hotel,Fecha_Inicio)
)
CREATE TABLE FUGAZZETA.[Usuarios x Hoteles x Rol](
Username nvarchar(30),
Id_Hotel int,
Id_Rol int,
EstadoSesion bit DEFAULT 0,
PRIMARY KEY (Username,Id_Hotel,Id_Rol),
FOREIGN KEY (Username) REFERENCES FUGAZZETA.Usuarios,
FOREIGN KEY (Id_Hotel) REFERENCES FUGAZZETA.Hoteles,
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
Activo bit DEFAULT 1
)
CREATE TABLE FUGAZZETA.[Regimenes x Hotel](
Id_Hotel int FOREIGN KEY REFERENCES FUGAZZETA.Hoteles,
Id_Regimen int FOREIGN KEY REFERENCES FUGAZZETA.Regimenes,
PRIMARY KEY (Id_Hotel,Id_Regimen)
)
CREATE TABLE FUGAZZETA.EstadosReserva(
Id_EstadoReserva INT IDENTITY(1,1) PRIMARY KEY,
Descripcion varchar(50)
)
CREATE TABLE FUGAZZETA.Reservas(
Id_Reserva int IDENTITY (1,1) PRIMARY KEY,
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
Id_Reserva int NOT NULL,
Proceso char NOT NULL,
Username nvarchar(30) FOREIGN KEY REFERENCES FUGAZZETA.Usuarios,
FechaMovimiento datetime,
Motivo nvarchar(140),
FOREIGN KEY (Id_Reserva) REFERENCES FUGAZZETA.Reservas
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
NroFactura int IDENTITY(1,1) PRIMARY KEY,
Id_Hotel INT FOREIGN KEY REFERENCES FUGAZZETA.Hoteles,
Fecha date,
Total numeric (10,2),
Id_Cliente int FOREIGN KEY REFERENCES FUGAZZETA.Clientes
)
CREATE TABLE FUGAZZETA.[Items_Hospedaje](
NroFactura int FOREIGN KEY REFERENCES FUGAZZETA.Facturas NOT NULL,
Ocupadas Bit,
CantNoches int,
Monto numeric (7,2),
CHECK (CantNoches >= 0)
)
CREATE TABLE FUGAZZETA.Consumibles(
Id_Consumible INT IDENTITY (1,1) PRIMARY KEY,
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
Habilitado bit DEFAULT 1,
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

-------------------------------/* Triggers*/------------------------------------------------
--------------------------------------------------------------------------------------------
CREATE TRIGGER FUGAZZETA.TR_MovimientosHotel_A_I ON FUGAZZETA.HistorialBajasHotel
AFTER INSERT AS
BEGIN
	UPDATE FUGAZZETA.Hoteles
	SET Habilitado = 0
	WHERE Id_Hotel IN (SELECT Id_Hotel FROM INSERTED)
END
GO

CREATE TRIGGER FUGAZZETA.TR_Reservas_A_I ON FUGAZZETA.Reservas
AFTER INSERT AS
BEGIN
	DECLARE mi_cursor CURSOR FOR (SELECT Id_Reserva FROM INSERTED)
	DECLARE @RESERVA int	
	OPEN mi_cursor FETCH FROM mi_cursor INTO @Reserva
	WHILE @@FETCH_STATUS = 0	
		BEGIN
		INSERT INTO FUGAZZETA.MovimientosReserva (Id_Reserva,Proceso,Motivo) VALUES (@RESERVA,'A','Alta')
		FETCH FROM mi_cursor INTO @Reserva
		END
	CLOSE mi_cursor
	DEALLOCATE mi_cursor
END
GO

--------------------------/* Poblado de Datos*/---------------------------------------------
--------------------------------------------------------------------------------------------
INSERT INTO FUGAZZETA.Paises values ('ARGENTINA')
INSERT INTO FUGAZZETA.Paises values ('URUGUAY')
INSERT INTO FUGAZZETA.Paises values ('ESPAÑA')
INSERT INTO FUGAZZETA.Paises values ('BRASIL')
go

--Funcionalidades
INSERT INTO FUGAZZETA.Funcionalidades values('ABM Rol')
INSERT INTO FUGAZZETA.Funcionalidades values('ABM Usuario')
INSERT INTO FUGAZZETA.Funcionalidades values('ABM Cliente')
INSERT INTO FUGAZZETA.Funcionalidades values('ABM Hotel')
INSERT INTO FUGAZZETA.Funcionalidades values('ABM Habitacion')
INSERT INTO FUGAZZETA.Funcionalidades values('ABM Regimen')
INSERT INTO FUGAZZETA.Funcionalidades values('Generar/Modificar Reserva')
INSERT INTO FUGAZZETA.Funcionalidades values('Cancelar Reserva')
INSERT INTO FUGAZZETA.Funcionalidades values('Registrar Estadia')
INSERT INTO FUGAZZETA.Funcionalidades values('Registrar Consumible')
INSERT INTO FUGAZZETA.Funcionalidades values('Facturar')
go

--Roles
INSERT INTO FUGAZZETA.Roles values('Administrador General',1)
insert into FUGAZZETA.Roles values('Administrador',1)
insert into FUGAZZETA.Roles values('Recepcionista',1)
insert into FUGAZZETA.Roles values('Guest',1)
GO

--Funcionalidades x Roles
--AdminGeneral
INSERT INTO FUGAZZETA.[Funcionalidades x Roles]
SELECT Id_Funcionalidad,Id_Rol FROM FUGAZZETA.Funcionalidades, FUGAZZETA.Roles WHERE Id_Rol = 1
--guest
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(7,4)
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(8,4)
--admin
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(2,2)
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(3,2)
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(4,2)
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(5,2)
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(6,2)
--recep
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(3,3)
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(7,3)
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(8,3)
INSERT INTO FUGAZZETA.[Funcionalidades x Roles] values(9,3)
GO

INSERT INTO FUGAZZETA.Hoteles
(Calle, Ciudad, Nro_Calle, CantEstrella, Recarga)
SELECT DISTINCT
Hotel_Calle,
Hotel_Ciudad,
Hotel_Nro_Calle,
Hotel_CantEstrella,
Hotel_Recarga_Estrella 
FROM gd_esquema.Maestra
UPDATE FUGAZZETA.Hoteles SET Pais = 1
GO

INSERT INTO FUGAZZETA.TiposDoc values ('DNI')
INSERT INTO FUGAZZETA.TiposDoc values ('LC')
INSERT INTO FUGAZZETA.TiposDoc values ('LE')
INSERT INTO FUGAZZETA.TiposDoc values ('Pasaporte')
go

INSERT INTO FUGAZZETA.Usuarios (Username, Contraseña) values ('admin','w23e')
INSERT INTO FUGAZZETA.Usuarios (Username) values ('guest')
go

INSERT INTO FUGAZZETA.Clientes
	(Nro_Doc,Apellido,Nombre,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto)
	SELECT DISTINCT 
	Cliente_Pasaporte_Nro,
	Cliente_Apellido,
	Cliente_Nombre,
	Cliente_Fecha_Nac,
	Cliente_Mail,
	Cliente_Dom_Calle,
	Cliente_Nro_Calle,
	Cliente_Piso,
	Cliente_Depto
	FROM gd_esquema.Maestra
	UPDATE FUGAZZETA.Clientes SET Nacionalidad = 1
GO

--HistorialBajasHotel: no hay informacion de bajas de hotel

INSERT INTO FUGAZZETA.[Usuarios x Hoteles x Rol]
(Username,Id_Hotel,Id_Rol)
SELECT U.Username, H.Id_Hotel,1
FROM FUGAZZETA.Usuarios U, FUGAZZETA.Hoteles H where U.Username = 'admin'
INSERT INTO FUGAZZETA.[Usuarios x Hoteles x Rol]
(Username,Id_Hotel,Id_Rol)
SELECT U.Username, H.Id_Hotel,4
FROM FUGAZZETA.Usuarios U, FUGAZZETA.Hoteles H where U.Username = 'guest'
GO

INSERT INTO FUGAZZETA.Regimenes
(Precio,Descripcion)
SELECT DISTINCT
Regimen_Precio,
Regimen_Descripcion
FROM gd_esquema.Maestra
GO

INSERT INTO FUGAZZETA.[Regimenes x Hotel]
SELECT DISTINCT H.Id_Hotel, R.Id_Regimen FROM FUGAZZETA.Hoteles H, FUGAZZETA.Regimenes R,
(SELECT DISTINCT Hotel_Calle,Hotel_Nro_Calle,Regimen_Descripcion FROM gd_esquema.Maestra) AS M
WHERE
H.Calle = M.Hotel_Calle AND
M.Hotel_Nro_Calle = H.Nro_Calle AND
M.Regimen_Descripcion = R.Descripcion
GO

INSERT INTO	FUGAZZETA.EstadosReserva values('Correcta')
INSERT INTO	FUGAZZETA.EstadosReserva values('Modificada')
INSERT INTO	FUGAZZETA.EstadosReserva values('Cancelada por Recepcion')
INSERT INTO	FUGAZZETA.EstadosReserva values('Cancelada por Cliente')
INSERT INTO	FUGAZZETA.EstadosReserva values('Cancelada por No-Show')
INSERT INTO	FUGAZZETA.EstadosReserva values('Efectivizada')
go

----------------CREACION DE TABLA TEMPORAL ESTADIAS-----------------------------
SELECT distinct
		Reserva_Codigo,
		(select top 1 Id_Cliente from FUGAZZETA.Clientes where Cliente_Mail=Mail and Cliente_Pasaporte_Nro=Nro_Doc) Id_Cliente,
		(select Id_Hotel from FUGAZZETA.Hoteles where Calle = Hotel_Calle AND Nro_Calle = Hotel_Nro_Calle) Id_Hotel,
		cast(Reserva_Fecha_Inicio as DATE) Inicio_Reserva,
		cast(DATEADD(d,Estadia_Cant_Noches,Estadia_Fecha_Inicio) as DATE) Egreso,
		cast(DATEADD(d,Reserva_Cant_Noches,Reserva_Fecha_Inicio) as DATE) Fin_Reserva,
		(select Id_Regimen from FUGAZZETA.Regimenes where Descripcion=Regimen_Descripcion) Id_Regimen,
		6 Id_EstadoReserva
	into #Estadias
	From gd_esquema.Maestra
	where Estadia_Fecha_Inicio is not null

-----------------INSERTO RESERVAS EFECTIVIZADAS/ESTADIAS--------------------------------
SET IDENTITY_INSERT FUGAZZETA.Reservas ON
Insert into FUGAZZETA.Reservas
(Id_Reserva,Id_Cliente,Id_Hotel,Fecha_Inicio,Fecha_Egreso,Fecha_Fin_Reserva,Id_Regimen,Id_EstadoReserva)
	select * FROM #Estadias
	SET IDENTITY_INSERT FUGAZZETA.Reservas OFF
go	

-----------------MODIFICO CAMPOS DISTINTOS DE LA TEMPORAL-----------------------------
UPDATE #Estadias SET Egreso = null, Id_EstadoReserva = 1

-----------------INSERTO RESERVAS NO EFECTIVIZADAS = ((TOTALES - ESTADIAS))--------------------------
SET IDENTITY_INSERT FUGAZZETA.Reservas ON
Insert into FUGAZZETA.Reservas
(Id_Reserva,Id_Cliente,Id_Hotel,Fecha_Inicio,Fecha_Egreso,Fecha_Fin_Reserva,Id_Regimen,Id_EstadoReserva)
	
	(SELECT DISTINCT
		Reserva_Codigo,
		(select top 1 Id_Cliente from FUGAZZETA.Clientes where Cliente_Mail=Mail and Cliente_Pasaporte_Nro=Nro_Doc),
		(select Id_Hotel from FUGAZZETA.Hoteles where Calle = Hotel_Calle AND Nro_Calle = Hotel_Nro_Calle),
		cast(Reserva_Fecha_Inicio as DATE),
		null,
		cast(DATEADD(d,Reserva_Cant_Noches,Reserva_Fecha_Inicio) as DATE),
		(select Id_Regimen from FUGAZZETA.Regimenes where Descripcion=Regimen_Descripcion),
		1
	From gd_esquema.Maestra MP
	where (Estadia_Fecha_Inicio is null)
	EXCEPT
	select * FROM #Estadias)
	
	SET IDENTITY_INSERT FUGAZZETA.Reservas OFF
go	
-----------------------------------

/*CREATE PROCEDURE FUGAZZETA.MigrarReservas AS
BEGIN
SELECT DISTINCT
Reserva_Codigo, Cliente_Pasaporte_Nro, Cliente_Apellido, Hotel_Calle, Hotel_Nro_Calle,
cast(DATEADD(d,Reserva_Cant_Noches,Reserva_Fecha_Inicio) as DATE) as FinReserva,
cast(Reserva_Fecha_Inicio as DATE) AS ReservaIngreso,
cast(Estadia_Fecha_Inicio as DATE) AS Ingreso,
cast(DATEADD(d,Estadia_Cant_Noches,Estadia_Fecha_Inicio) as DATE) as Egreso,
Regimen_Descripcion
INTO #TempReservas FROM gd_esquema.Maestra 
	
SET IDENTITY_INSERT FUGAZZETA.Reservas ON
INSERT INTO FUGAZZETA.Reservas
(Id_Reserva,Id_Cliente, Id_Hotel,Fecha_Inicio,Fecha_Fin_Reserva,Id_Regimen)
SELECT
M.Reserva_Codigo, C.Id_Cliente, H.Id_Hotel, M.ReservaIngreso, M.FinReserva, REG.Id_Regimen
FROM
FUGAZZETA.Clientes C, FUGAZZETA.Hoteles H, FUGAZZETA.Regimenes REG,#TempReservas M
WHERE
	C.Nro_Doc = M.Cliente_Pasaporte_Nro
AND C.Apellido = M.Cliente_Apellido
AND H.Calle = M.Hotel_Calle 
AND H.Nro_Calle = M.Hotel_Nro_Calle 
AND REG.Descripcion = M.Regimen_Descripcion
AND M.Ingreso IS NULL
AND M.Egreso IS NULL
SET IDENTITY_INSERT FUGAZZETA.Reservas OFF

MERGE INTO FUGAZZETA.Reservas RES
USING
(SELECT Reserva_Codigo,Egreso FROM #TempReservas
WHERE 
Ingreso IS NOT NULL
AND Egreso IS NOT NULL) E
ON RES.Id_Reserva = E.Reserva_Codigo
WHEN MATCHED THEN UPDATE
SET Fecha_Egreso = E.Egreso,
Id_EstadoReserva = 6;

UPDATE FUGAZZETA.Reservas SET Id_EstadoReserva = 1 WHERE Id_EstadoReserva IS NULL

DECLARE mi_cursor CURSOR FOR
(SELECT Reserva_Codigo,Ingreso, Egreso FROM #TempReservas
WHERE 
	Ingreso IS NOT NULL
AND Egreso IS NOT NULL)
DECLARE @RESERVA INT
DECLARE @Ing date
DECLARE @Egr date
OPEN mi_cursor	FETCH NEXT FROM mi_cursor INTO @RESERVA, @Ing,@Egr
WHILE @@FETCH_STATUS = 0
	BEGIN
	INSERT INTO FUGAZZETA.MovimientosReserva (Id_Reserva,Proceso,FechaMovimiento,Motivo) values (@RESERVA,'I',@Ing,'Ingreso al hotel')
	INSERT INTO FUGAZZETA.MovimientosReserva (Id_Reserva,Proceso,FechaMovimiento,Motivo) values (@RESERVA,'E',@Egr,'Egreso del hotel')
	FETCH NEXT FROM mi_cursor INTO @RESERVA, @Ing, @Egr
	END
CLOSE mi_cursor
DEALLOCATE mi_cursor
END
GO
EXEC FUGAZZETA.MigrarReservas
GO*/

--ACOMPAÑANTES: NO HAY INFORMACION DE PERSONAS QUE ACOMPAÑARON EN UNA ESTADIA.

SET IDENTITY_INSERT FUGAZZETA.TiposHabitacion ON
INSERT INTO FUGAZZETA.TiposHabitacion (Id_TipoHab,Descripcion,Porcentual)
SELECT DISTINCT Habitacion_Tipo_Codigo,Habitacion_Tipo_Descripcion,Habitacion_Tipo_Porcentual FROM gd_esquema.Maestra
SET IDENTITY_INSERT FUGAZZETA.TiposHabitacion OFF
UPDATE FUGAZZETA.TiposHabitacion SET CantPersonas = cast(RIGHT(Id_TipoHab,1) as int)
GO

SET IDENTITY_INSERT FUGAZZETA.Facturas ON
INSERT INTO FUGAZZETA.Facturas
(NroFactura,Id_Hotel,Fecha,Total,Id_Cliente)
SELECT DISTINCT
M.Factura_Nro,H.Id_Hotel,cast(M.Factura_Fecha as DATE), M.Factura_Total, C.Id_Cliente
FROM gd_esquema.Maestra M, FUGAZZETA.Hoteles H, FUGAZZETA.Clientes C
where
	M.Factura_Nro IS NOT NULL
AND H.Calle = M.Hotel_Calle
AND H.Nro_Calle = M.Hotel_Nro_Calle
AND C.Nro_Doc = M.Cliente_Pasaporte_Nro
AND C.Apellido = M.Cliente_Apellido
ORDER BY M.Factura_Nro
SET IDENTITY_INSERT FUGAZZETA.Facturas OFF
GO

CREATE PROCEDURE FUGAZZETA.Migrar_ItemsHospedaje AS
BEGIN
	BEGIN TRANSACTION
	INSERT INTO FUGAZZETA.Items_Hospedaje (NroFactura,CantNoches,Monto)
	SELECT Factura_Nro, Estadia_Cant_Noches, Item_Factura_Monto FROM gd_esquema.Maestra
	where
		Factura_Nro is not null
	AND Consumible_Codigo is null
	ORDER BY Factura_Nro
	UPDATE FUGAZZETA.Items_Hospedaje SET Ocupadas = 1
	COMMIT TRANSACTION
	--Ninguna estadía tuvo noches de sobra. Por lo tanto, para todas ellas la cantidad de Noches NO ocupadas es 0
	BEGIN TRANSACTION
		INSERT INTO FUGAZZETA.Items_Hospedaje (NroFactura)
		SELECT Factura_Nro FROM gd_esquema.Maestra
		where
			Factura_Nro is not null
		AND Consumible_Codigo is null
		ORDER BY Factura_Nro
		UPDATE FUGAZZETA.Items_Hospedaje
			SET Ocupadas = 0,
				CantNoches = 0,
				Monto = 0
			WHERE Ocupadas IS NULL AND CantNoches IS NULL AND MONTO IS NULL
	COMMIT TRANSACTION
	-- Después del poblado se agrega la PK en la tabla.	
END
GO
EXEC FUGAZZETA.Migrar_ItemsHospedaje
GO
ALTER TABLE FUGAZZETA.Items_Hospedaje
ALTER COLUMN Ocupadas Bit not null
go
ALTER TABLE FUGAZZETA.Items_Hospedaje
ADD PRIMARY KEY (NroFactura,Ocupadas)
GO


SET IDENTITY_INSERT FUGAZZETA.Consumibles ON
INSERT INTO FUGAZZETA.Consumibles (Id_Consumible,Descripcion,Precio)
SELECT DISTINCT
Consumible_Codigo,
Consumible_Descripcion,
Consumible_Precio
FROM gd_esquema.Maestra
WHERE Consumible_Codigo IS NOT NULL
set identity_insert fugazzeta.consumibles off
go

INSERT INTO FUGAZZETA.Items_Consumible
SELECT
Factura_Nro,
Consumible_Codigo as Id_Consumible,
SUM(Item_Factura_Cantidad) as [Cantidad],
SUM(Item_Factura_Monto) AS [Monto total]
FROM gd_esquema.Maestra
WHERE
	Factura_Nro IS NOT NULL
AND Consumible_Codigo IS NOT NULL
GROUP BY Factura_Nro, Consumible_Codigo
ORDER BY Factura_Nro, Consumible_Codigo
GO

INSERT INTO FUGAZZETA.TiposPago values('Efectivo')
INSERT INTO FUGAZZETA.TiposPago values('Tarjeta de Crédito')
INSERT INTO FUGAZZETA.TiposPago values('Tarjeta de Débito')
go

INSERT INTO FUGAZZETA.Bancos values('Banco Frances')
INSERT INTO FUGAZZETA.Bancos values('Banco Ciudad')
go

--ABONOFACTURAS: no hay informacion de pagos.

INSERT INTO FUGAZZETA.Habitaciones (Id_Hotel,Num_Habitacion,Piso,Frente,Id_TipoHab)
SELECT H.Id_Hotel,M.Habitacion_Numero,M.Habitacion_Piso,
M.Habitacion_Frente,M.Habitacion_Tipo_Codigo
FROM FUGAZZETA.Hoteles H, (SELECT DISTINCT Hotel_Calle,Hotel_Nro_Calle,Habitacion_Numero,Habitacion_Piso,
Habitacion_Frente,Habitacion_Tipo_Codigo FROM gd_esquema.Maestra) as M
WHERE
	H.Calle = M.Hotel_Calle
AND H.Nro_Calle = M.Hotel_Nro_Calle
GO

INSERT INTO FUGAZZETA.HistorialHabitaciones
SELECT DISTINCT
H.Id_Hotel, M.Habitacion_Numero, CAST(M.Estadia_Fecha_Inicio AS DATE) AS DIA, M.Estadia_Cant_Noches
FROM gd_esquema.Maestra M, FUGAZZETA.Hoteles H
WHERE 
	M.Hotel_Calle = H.Calle
AND M.Hotel_Nro_Calle = H.Nro_Calle
AND M.Estadia_Fecha_Inicio IS NOT NULL
ORDER BY H.Id_Hotel,M.Habitacion_Numero, DIA
GO

INSERT INTO FUGAZZETA.[Habitaciones x Reservas]
SELECT DISTINCT M.Reserva_Codigo,H.Id_Hotel,M.Habitacion_Numero FROM gd_esquema.Maestra M, FUGAZZETA.Hoteles H
WHERE
	H.Calle = M.Hotel_Calle
AND H.Nro_Calle = M.Hotel_Nro_Calle
GO

----------------------------------------/*VISTAS*/------------------------------------------
--------------------------------------------------------------------------------------------

CREATE VIEW FUGAZZETA.ClientesDuplicados AS
SELECT * FROM FUGAZZETA.Clientes
	WHERE Mail IN (
	SELECT Mail
	FROM FUGAZZETA.Clientes
	group by Mail
	having COUNT(*)>1)
UNION
SELECT C.Id_Cliente,C.Nombre,C.Apellido,C.Id_TipoDoc, C.Nro_Doc,C.Fecha_Nac,C.Mail,C.Telefono,C.Dom_Calle,
C.Nro_Calle,C.Piso,C.Depto,C.Localidad,C.PaisOrigen,C.Nacionalidad,C.Habilitado
FROM FUGAZZETA.Clientes C, 
(SELECT Id_TipoDoc,Nro_Doc
	FROM FUGAZZETA.Clientes
	group by Id_TipoDoc,Nro_Doc
	having COUNT(*)>1) AS DUP
WHERE
ISNULL(C.Id_TipoDoc,-1) = ISNULL(DUP.Id_TipoDoc,-1)
AND	C.Nro_Doc = DUP.Nro_Doc
GO

CREATE VIEW FUGAZZETA.[UsuariosHabilitados] AS
SELECT * FROM FUGAZZETA.Usuarios
WHERE (Habilitado = 1)
GO

CREATE VIEW FUGAZZETA.ReservasNoCanceladas AS
SELECT 
RS.Id_Reserva, RS.Id_Cliente, RS.Id_Hotel, RS.Fecha_Reserva, RS.Fecha_Inicio, RS.Fecha_Egreso,
RS.Fecha_Fin_Reserva, RG.Descripcion as Regimen, RS.Id_EstadoReserva
FROM FUGAZZETA.Reservas RS, FUGAZZETA.Regimenes RG
where
	RS.Id_Regimen = RG.Id_Regimen
AND RS.Id_EstadoReserva != 3
AND RS.Id_EstadoReserva != 4 
AND RS.Id_EstadoReserva != 5
go

CREATE VIEW FUGAZZETA.ReservasModificables AS
SELECT * FROM FUGAZZETA.[ReservasNoCanceladas]
where
   Id_EstadoReserva = 1
OR Id_EstadoReserva = 2 
go

CREATE VIEW FUGAZZETA.ProximasHabitacionesReservadas AS
SELECT H.Id_Hotel,H.Num_Habitacion, R.Fecha_Inicio, R.Fecha_Fin_Reserva 
FROM FUGAZZETA.Habitaciones H, FUGAZZETA.ReservasNoCanceladas R, FUGAZZETA.[Habitaciones x Reservas] HR
WHERE
	H.Id_Hotel = HR.Id_Hotel
AND H.Num_Habitacion = HR.Num_Habitacion
AND HR.Id_Reserva = R.Id_Reserva
AND R.Fecha_Egreso IS NULL
go


------------------------------------/*FUNCIONES*/-------------------------------------------
--------------------------------------------------------------------------------------------

CREATE FUNCTION FUGAZZETA.CostoHabitacion (@Hotel int, @CantPersonas int, @IdRegimen int) RETURNS float
AS BEGIN
	DECLARE @Incremento float
	declare @Estrellas int
	Declare @PrecioRegimen float
	SET @Estrellas = (SELECT CantEstrella FROM FUGAZZETA.Hoteles where Id_Hotel = @Hotel)
--	SET @Incremento = (SELECT Recarga FROM FUGAZZETA.Hoteles where Id_Hotel = @Hotel)
	SET @PrecioRegimen = ISNULL((SELECT Precio FROM FUGAZZETA.Regimenes where Id_Regimen = @IdRegimen),1)
	RETURN 
--	@Incremento *
	@Estrellas *
	@CantPersonas * @PrecioRegimen
END
GO

CREATE FUNCTION FUGAZZETA.PuntosFactura(@Nf int) RETURNS INT AS
BEGIN 
DECLARE @PUNTOS INT
SET @PUNTOS = 0
DECLARE @PuntosQueOtorga int
DECLARE mi_cursor CURSOR FOR (SELECT Monto FROM FUGAZZETA.Items_Consumible WHERE NroFactura = @Nf)
DECLARE @Monto numeric(7,2)
OPEN mi_cursor FETCH NEXT FROM mi_cursor INTO @Monto
WHILE  @@FETCH_STATUS = 0
	BEGIN	
		SET @PuntosQueOtorga = @Monto / 5
		SET @Puntos += @PuntosQueOtorga
		FETCH NEXT FROM mi_cursor INTO @Monto
	END
CLOSE mi_cursor
DEALLOCATE mi_cursor

DECLARE mi_cursor2 CURSOR FOR (SELECT Monto FROM FUGAZZETA.Items_Hospedaje WHERE NroFactura = @Nf)
DECLARE @Monto2 numeric(7,2)
OPEN mi_cursor2 FETCH NEXT FROM mi_cursor2 INTO @Monto2
WHILE  @@FETCH_STATUS = 0
	BEGIN	
		SET @PuntosQueOtorga = @Monto2 / 10
		SET @Puntos += @PuntosQueOtorga
		FETCH NEXT FROM mi_cursor2 INTO @Monto2
	END
CLOSE mi_cursor2
DEALLOCATE mi_cursor2

RETURN @Puntos
END
GO

----------------------------/* PROCEDIMIENTOS */--------------------------------------------
--------------------------------------------------------------------------------------------

CREATE PROCEDURE FUGAZZETA.LoginCorrecto(@USER nvarchar(30))
AS BEGIN
UPDATE FUGAZZETA.Usuarios
SET CantFallos_Login = 0 WHERE Username like @USER
END
GO

CREATE PROCEDURE FUGAZZETA.LoginIncorrecto(@USER nvarchar(30))
AS BEGIN
DECLARE @FALLOS int
BEGIN TRANSACTION
UPDATE FUGAZZETA.Usuarios 
SET CantFallos_Login = CantFallos_Login + 1
WHERE Username like @USER
COMMIT TRANSACTION 
SET @FALLOS = (SELECT CantFallos_Login FROM FUGAZZETA.Usuarios WHERE Username like @USER)
IF @FALLOS = 3
BEGIN
	UPDATE FUGAZZETA.Usuarios
	SET Habilitado = 0 WHERE Username like @USER 
	RAISERROR('El usuario ha sido inhabilitado por haber llegado a 3 intentos fallidos. Comuníquese con el administrador',10,1)
END
END
GO

CREATE PROCEDURE FUGAZZETA.OcupacionEnHotelEnPeriodo (@Hotel int,@Desde date, @Hasta date) AS
BEGIN
SELECT * FROM FUGAZZETA.ReservasNoCanceladas
WHERE Id_Hotel = @Hotel AND 
((Fecha_Inicio between @Desde and @Hasta) OR
 (Fecha_Egreso between @Desde and @Hasta) OR
 (Fecha_Fin_Reserva between @Desde and @Hasta)
 )
end
GO

CREATE PROCEDURE FUGAZZETA.CancelarReserva (@ReservaID int, @USER nvarchar(30),@Fecha datetime, @Motivo nvarchar(140)) AS
BEGIN
DECLARE @ESTADO int
	IF @USER = 'guest'
		SET @ESTADO = 4
	ELSE SET @ESTADO = 3
	UPDATE FUGAZZETA.Reservas
		SET Id_EstadoReserva = @ESTADO WHERE Id_Reserva = @ReservaID
	INSERT INTO FUGAZZETA.MovimientosReserva
	values (@ReservaID,'B',@USER,@Fecha,@Motivo)
END
GO

CREATE PROCEDURE FUGAZZETA.RealizarIngreso (@IdReserva int, @Usuario nvarchar (40), @Fecha datetime) AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		UPDATE FUGAZZETA.Reservas
		SET Id_EstadoReserva = 6 WHERE Id_Reserva = @IdReserva
		INSERT INTO FUGAZZETA.MovimientosReserva
		VALUES (@IdReserva,'I',@Usuario,@Fecha,'Ingreso al hotel')
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK
		RAISERROR ('No se pudo realizar el ingreso.',10,1)
	END CATCH
END
GO

CREATE PROC FUGAZZETA.CancelarPorNoShow (@Ahora datetime, @Usuario nvarchar(30)) AS
BEGIN
	DECLARE mi_cursor CURSOR FOR
		SELECT Id_Reserva FROM FUGAZZETA.[ReservasModificables] WHERE Fecha_Inicio < cast(@Ahora as date)
		DECLARE @id int
	OPEN mi_cursor
	FETCH FROM mi_cursor INTO @id
	WHILE  @@FETCH_STATUS = 0
	BEGIN	
		UPDATE FUGAZZETA.Reservas SET Id_EstadoReserva = 5 WHERE Id_Reserva = @id
		INSERT INTO FUGAZZETA.MovimientosReserva VALUES (@id,'B',@Usuario,@Ahora,'No show')
		FETCH FROM mi_cursor INTO @id
	END
	CLOSE mi_cursor
	DEALLOCATE mi_cursor
END
GO

CREATE PROC FUGAZZETA.HabitacionesLibresEnPeriodo(@Hotel int, @Desde date, @Hasta date, @Regimen int) AS
begin
	SELECT
	H.Num_Habitacion as [Número],
	T.Descripcion,
	H.Comodidades,
	cast(T.CantPersonas as CHAR(1)) + ' personas' AS Capacidad,
	'$ ' + cast((FUGAZZETA.CostoHabitacion(@Hotel,T.CantPersonas,@Regimen)) as varchar) as [Costo estimado por día]
	FROM FUGAZZETA.Habitaciones H, FUGAZZETA.TiposHabitacion T
	WHERE
	H.Id_Hotel = @Hotel
	AND	(H.Num_Habitacion) NOT IN 
		(SELECT Num_Habitacion FROM FUGAZZETA.ProximasHabitacionesReservadas
			WHERE
				Id_Hotel = H.Id_Hotel
			AND (Fecha_Inicio between @Desde and @Hasta)
			OR (Fecha_Fin_Reserva between @Desde and @Hasta)
		)
	AND Habilitado = 1
	AND H.Id_TipoHab = T.Id_TipoHab
	ORDER BY Capacidad
end
GO

CREATE PROC FUGAZZETA.GenerarReserva 
@Cliente int, @Hotel int,@Ahora datetime, @Inicio date, @Fin date, @Regimen int, @UsuarioActual nvarchar(30)
AS
BEGIN
DECLARE @IdReserva int
	BEGIN TRANSACTION
		INSERT INTO FUGAZZETA.Reservas
		(Id_Cliente,Id_Hotel, Fecha_Reserva, Fecha_Inicio,Fecha_Fin_Reserva,Id_Regimen,Id_EstadoReserva)
		VALUES (@Cliente,@Hotel,CAST(@Ahora as DATE),@Inicio,@Fin,@Regimen,1)
		SET @IdReserva = (SELECT TOP 1 Id_Reserva FROM FUGAZZETA.MovimientosReserva order by 1 desc)
		UPDATE FUGAZZETA.MovimientosReserva
		SET Username = @UsuarioActual, FechaMovimiento = @Ahora
		WHERE Id_Reserva = @IdReserva	
	COMMIT TRANSACTION
	SELECT Id_Reserva FROM FUGAZZETA.Reservas WHERE Id_Reserva = @IdReserva
END
GO

CREATE PROCEDURE FUGAZZETA.VerHabitacionesDeEstadia (@Reserva int, @Egreso date) AS 
BEGIN
	SELECT
	H.Id_Hotel as [Hotel],
	H.Num_Habitacion as [Habitacion],
	TH.Descripcion as [Tipo],
	FUGAZZETA.CostoHabitacion(H.Id_Hotel,TH.CantPersonas,R.Id_Regimen) as [Costo por día],
	FUGAZZETA.CostoHabitacion(H.Id_Hotel,TH.CantPersonas,R.Id_Regimen) * DATEDIFF(d,R.Fecha_Inicio,R.Fecha_Fin_Reserva) as [Subtotal]
	FROM FUGAZZETA.[Habitaciones x Reservas] HR, FUGAZZETA.Habitaciones H,
	FUGAZZETA.TiposHabitacion TH, FUGAZZETA.Reservas R
	WHERE 
		HR.Id_Reserva = @Reserva
	AND HR.Id_Hotel = H.Id_Hotel
	AND HR.Num_Habitacion = H.Num_Habitacion
	AND HR.Id_Reserva = R.Id_Reserva
	AND TH.Id_TipoHab = H.Id_TipoHab
END
GO

CREATE PROC FUGAZZETA.ValidarEstadia (@id int, @Fecha date) AS 
BEGIN
	IF @id NOT IN(SELECT Id_Reserva FROM FUGAZZETA.Reservas WHERE Id_EstadoReserva = 6 
				AND Fecha_Egreso IS NULL)
	RAISERROR('No se encontró la estadía.',16,1)
	ELSE
	BEGIN
		DECLARE @LIMITE date
		SET @LIMITE = (SELECT Fecha_Fin_Reserva FROM FUGAZZETA.Reservas WHERE Id_Reserva = @id)
		IF @fecha > @LIMITE
		RAISERROR('No se puede realizar el Check out de esta reserva. Ya pasó la fecha límite de reserva.',16,1) 
		ELSE (SELECT Id_Reserva,Id_Regimen,Fecha_Inicio,Fecha_Fin_Reserva, Id_Hotel, Id_Cliente FROM FUGAZZETA.Reservas WHERE Id_Reserva = @id)
	END
END
GO

CREATE PROC FUGAZZETA.RealizarEgreso (@Id int, @Ahora datetime, @Usuario nvarchar(30)) AS
BEGIN
	UPDATE FUGAZZETA.Reservas
	SET Fecha_Egreso = CAST(@Ahora as DATE)
	WHERE Id_Reserva = @Id
	INSERT INTO FUGAZZETA.MovimientosReserva
	VALUES (@Id,'E',@Usuario,@Ahora,'Egreso del hotel')
END
GO

CREATE PROC FUGAZZETA.GenerarFactura (@Hotel int, @Hoy date, @Total numeric, @Cliente int) AS
BEGIN
	INSERT INTO FUGAZZETA.Facturas VALUES (@Hotel, @Hoy, @Total,@Cliente)
	
	SELECT NroFactura FROM FUGAZZETA.Facturas
	WHERE Id_Hotel = @Hotel and Fecha = @Hoy and Total = @Total and Id_Cliente = @Cliente
END
GO

CREATE PROC FUGAZZETA.RealizarModificacion (@Reserva int, @Usuario nvarchar(30), @Ahora datetime, @Motivo nvarchar(140)) AS
BEGIN
	INSERT INTO FUGAZZETA.MovimientosReserva values (@Reserva,'M',@Usuario,@Ahora,@Motivo)
	UPDATE FUGAZZETA.Reservas SET Id_EstadoReserva = 2 WHERE Id_Reserva = @Reserva
END
GO

CREATE PROC FUGAZZETA.ActualizarReserva (@Reserva int, @Hotel int, @Inicio date, @Fin date, @Regimen int) AS
BEGIN
	UPDATE FUGAZZETA.Reservas
	SET Id_Hotel = @Hotel,
	Fecha_Inicio = @Inicio,
	Fecha_Fin_Reserva = @Fin,
	Id_Regimen = @Regimen WHERE Id_Reserva = @Reserva
END
go

CREATE PROC FUGAZZETA.VerFuncionalidadesEnHotel(@Usuario nvarchar(30),@Hotel int) AS
BEGIN
	SELECT R.Username, F.Id_Funcionalidad
	FROM FUGAZZETA.[Usuarios x Hoteles x Rol] R, FUGAZZETA.[Funcionalidades x Roles] F
	WHERE 
		R.Id_Rol = F.Id_Rol
	AND	R.Username = @Usuario
	AND R.Id_Hotel = @Hotel
END