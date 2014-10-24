USE GD2C2014

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'FUGAZZETA')
BEGIN
	EXEC ('CREATE SCHEMA FUGAZZETA AUTHORIZATION gd')
END


--------------------Borrando Tablas------------------------
-----------------------------------------------------------

DROP TABLE FUGAZZETA.AbonoFacturas
DROP TABLE FUGAZZETA.Acompañantes
DROP TABLE FUGAZZETA.Bancos
DROP TABLE FUGAZZETA.[Usuarios x Hoteles x Rol]
DROP TABLE FUGAZZETA.TiposPago
DROP TABLE FUGAZZETA.[Funcionalidades x Roles]
DROP TABLE FUGAZZETA.Funcionalidades
DROP TABLE FUGAZZETA.[Habitaciones x Reservas]
DROP TABLE FUGAZZETA.HistorialHabitaciones
DROP TABLE FUGAZZETA.Items_Consumible
DROP TABLE FUGAZZETA.Items_Hospedaje
DROP TABLE FUGAZZETA.MovimientosHotel
DROP TABLE FUGAZZETA.MovimientosReserva
DROP TABLE FUGAZZETA.Usuarios
DROP TABLE FUGAZZETA.Consumibles
DROP TABLE FUGAZZETA.Facturas
DROP TABLE FUGAZZETA.Roles
DROP TABLE FUGAZZETA.Reservas
DROP TABLE FUGAZZETA.EstadosReserva
DROP TABLE FUGAZZETA.ClientesDuplicados
DROP TABLE FUGAZZETA.Clientes
DROP TABLE FUGAZZETA.TiposDoc
DROP TABLE FUGAZZETA.[Regimenes x Hotel]
DROP TABLE FUGAZZETA.Regimenes
DROP TABLE FUGAZZETA.Habitaciones
DROP TABLE FUGAZZETA.TiposHabitacion
DROP TABLE FUGAZZETA.Hoteles
DROP TABLE FUGAZZETA.Paises
GO

--------------------/*Borrado de procedimientos,vistas*/------------------------------------
--------------------------------------------------------------------------------------------
IF OBJECT_ID('FUGAZZETA.LoginCorrecto', 'P') IS NOT NULL
DROP PROCEDURE FUGAZZETA.LoginCorrecto

IF OBJECT_ID('FUGAZZETA.LoginIncorrecto', 'P') IS NOT NULL
DROP PROCEDURE FUGAZZETA.LoginIncorrecto

IF OBJECT_ID('FUGAZZETA.MigrarClientes') IS NOT NULL
DROP PROCEDURE FUGAZZETA.MigrarClientes

IF OBJECT_ID('FUGAZZETA.[UsuariosHabilitados]') IS NOT NULL
DROP VIEW FUGAZZETA.[UsuariosHabilitados]

IF OBJECT_ID('FUGAZZETA.[TodosLosClientes]') IS NOT NULL
DROP VIEW FUGAZZETA.[TodosLosClientes]


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
Contraseña nvarchar(32),
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
Nacionalidad int FOREIGN KEY REFERENCES FUGAZZETA.Paises,
Habilitado bit default 1
)

SELECT * INTO FUGAZZETA.ClientesDuplicados FROM FUGAZZETA.Clientes
ALTER TABLE FUGAZZETA.ClientesDuplicados
ADD PRIMARY KEY (Id_Cliente),
FOREIGN KEY (Id_TipoDoc) REFERENCES FUGAZZETA.TiposDoc,
FOREIGN KEY (Nacionalidad) REFERENCES FUGAZZETA.Paises,
DEFAULT 1 FOR Habilitado
DBCC CHECKIDENT ('FUGAZZETA.ClientesDuplicados',RESEED,700001)

CREATE TABLE FUGAZZETA.MovimientosHotel(
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
PRIMARY KEY (Username,Id_Hotel),
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
Id_Hotel int,
Id_Regimen int,
PRIMARY KEY (Id_Hotel,Id_Regimen)
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
Id_Consumible INT PRIMARY KEY,
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

--------------------------/* Poblado de Datos*/---------------------------------------------
--------------------------------------------------------------------------------------------
INSERT INTO FUGAZZETA.Roles values('Administrador General',1)
insert into FUGAZZETA.Roles values('Administrador',1)
insert into FUGAZZETA.Roles values('Recepcionista',1)
insert into FUGAZZETA.Roles values('Guest',1)
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
GO

INSERT INTO FUGAZZETA.Usuarios
(Username, Contraseña, Habilitado) values ('admin','w23e',1)
go

INSERT INTO FUGAZZETA.Regimenes
(Precio,Descripcion)
SELECT DISTINCT
Regimen_Precio,
Regimen_Descripcion
FROM gd_esquema.Maestra
UPDATE FUGAZZETA.Regimenes SET Activo = 1
GO

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

INSERT INTO FUGAZZETA.Bancos values('Banco Frances')
INSERT INTO FUGAZZETA.Bancos values('Banco Ciudad')
go

INSERT INTO FUGAZZETA.TiposPago values('Efectivo')
INSERT INTO FUGAZZETA.TiposPago values('Tarjeta de Crédito')
INSERT INTO FUGAZZETA.TiposPago values('Tarjeta de Débito')
go

INSERT INTO	FUGAZZETA.EstadosReserva values('Correcta')
INSERT INTO	FUGAZZETA.EstadosReserva values('Modificada')
INSERT INTO	FUGAZZETA.EstadosReserva values('Cancelada por Recepcion')
INSERT INTO	FUGAZZETA.EstadosReserva values('Cancelada por Cliente')
INSERT INTO	FUGAZZETA.EstadosReserva values('Cancelada por No-Show')
INSERT INTO	FUGAZZETA.EstadosReserva values('Efectivizada')
go

INSERT INTO FUGAZZETA.TiposDoc values ('DNI')
INSERT INTO FUGAZZETA.TiposDoc values ('LC')
INSERT INTO FUGAZZETA.TiposDoc values ('LE')
INSERT INTO FUGAZZETA.TiposDoc values ('Pasaporte')
go

INSERT INTO FUGAZZETA.Paises values ('Argentina')
INSERT INTO FUGAZZETA.Paises values ('Uruguay')
go

INSERT INTO FUGAZZETA.[Usuarios x Hoteles x Rol]
(Username,Id_Hotel)
SELECT U.Username, H.Id_Hotel FROM FUGAZZETA.Usuarios U, FUGAZZETA.Hoteles H where U.Username = 'admin'
UPDATE FUGAZZETA.[Usuarios x Hoteles x Rol]
SET Id_Rol = 1
GO

INSERT INTO FUGAZZETA.Consumibles
(Id_Consumible,Descripcion, Precio)
SELECT DISTINCT
Consumible_Codigo,
Consumible_Descripcion,
Consumible_Precio
FROM gd_esquema.Maestra
WHERE 
Consumible_Codigo IS NOT NULL
go

CREATE PROCEDURE FUGAZZETA.MigrarClientes AS
BEGIN
	SELECT DISTINCT
	Cliente_Pasaporte_Nro,
	Cliente_Apellido,
	Cliente_Nombre,
	Cliente_Fecha_Nac,
	Cliente_Mail,
	Cliente_Dom_Calle,
	Cliente_Nro_Calle,
	Cliente_Piso,
	Cliente_Depto INTO #TmpClientes FROM gd_esquema.Maestra

	INSERT INTO FUGAZZETA.Clientes
	(Nro_Doc,Apellido,Nombre,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto)
	SELECT * FROM #TmpClientes
	WHERE Cliente_Pasaporte_Nro NOT IN (
	SELECT Cliente_Pasaporte_Nro
	FROM #TmpClientes
	group by Cliente_Pasaporte_Nro
	having COUNT(*)>1)

	INSERT INTO FUGAZZETA.ClientesDuplicados
	(Nro_Doc,Apellido,Nombre,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto)
	SELECT * FROM #TmpClientes
	WHERE Cliente_Pasaporte_Nro IN (
	SELECT Cliente_Pasaporte_Nro
	FROM #TmpClientes
	group by Cliente_Pasaporte_Nro
	having COUNT(*)>1)

	UPDATE FUGAZZETA.Clientes SET Nacionalidad = 1
	UPDATE FUGAZZETA.ClientesDuplicados SET Nacionalidad = 1
END 
go
EXEC FUGAZZETA.MigrarClientes
go
----------------------------------------/*VISTAS*/------------------------------------------
--------------------------------------------------------------------------------------------

CREATE VIEW FUGAZZETA.[UsuariosHabilitados] AS
SELECT * FROM FUGAZZETA.Usuarios
WHERE (Habilitado = 1)
GO

CREATE VIEW FUGAZZETA.[TodosLosClientes] AS
SELECT * FROM FUGAZZETA.Clientes
UNION
SELECT * FROM FUGAZZETA.ClientesDuplicados
GO


----------------------------/* PROCEDIMIENTOS Y FUNCIONES*/---------------------------------
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



--- HASTA ACÁ SE PUEDE EJECUTAR BIEN. HAY QUE ORGANIZARNOS DESPUÉS COMO VAMOS DESARROLLANDO.

----------------------------------------/*PROCEDIMIENTO-NO SE SI ESTA BIEN*/----------------
--------------------------------------------------------------------------------------------

CREATE FUNCTION FUGAZZETA.calcular_total_factura
(
	@NroFactura int
)
RETURNS int
AS
BEGIN
	DECLARE @TotalHospedaje numeric(18,2)
	DECLARE @TotalConsumibles numeric(18,2)
	DECLARE @TotalFactura numeric(18,2)
	
	SET @TotalHospedaje = (SELECT SUM(Monto) FROM FUGAZZETA.Items_Hospedaje WHERE NroFactura = @NroFactura) 
	SET @TotalCOnsumibles = (SELECT SUM(Monto) FROM FUGAZZETA.Items_Cunsumible WHERE NroFactura = @NroFactura) 
	SET @TotalFactura = @TotalHospedaje + @TotalConsumible
	RETURN @Total
END
GO

-- cargar totales de facturas 


DECLARE mi_cursor CURSOR FOR
	SELECT NroFactura FROM FUGAZZETA.Facturas
	DECLARE @id int
OPEN mi_cursor
FETCH FROM mi_cursor INTO @id
WHILE  @@FETCH_STATUS = 0
BEGIN	
	UPDATE FUGAZZETA.Facturas SET Total = FUGAZZETA.calcular_total_factura(@id) WHERE NroFactura = @id

	FETCH FROM mi_cursor INTO @id
END
CLOSE mi_cursor
DEALLOCATE mi_cursor
GO

