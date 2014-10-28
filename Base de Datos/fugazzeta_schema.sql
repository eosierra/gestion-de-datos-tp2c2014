USE GD2C2014

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'FUGAZZETA')
BEGIN
	EXEC ('CREATE SCHEMA FUGAZZETA AUTHORIZATION gd')
END
GO

-----------------------------------/*Borrando Tablas */-------------------------------------
--------------------------------------------------------------------------------------------

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
DROP TABLE FUGAZZETA.HistorialBajasHotel
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
--Views
IF OBJECT_ID('FUGAZZETA.[UsuariosHabilitados]') IS NOT NULL
DROP VIEW FUGAZZETA.[UsuariosHabilitados]

IF OBJECT_ID('FUGAZZETA.[TodosLosClientes]') IS NOT NULL
DROP VIEW FUGAZZETA.[TodosLosClientes]

IF OBJECT_ID('FUGAZZETA.ReservasNoCanceladas') IS NOT NULL
DROP VIEW FUGAZZETA.ReservasNoCanceladas

IF OBJECT_ID('FUGAZZETA.ReservasModificables') IS NOT NULL
DROP VIEW FUGAZZETA.ReservasModificables

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

--Triggers
IF OBJECT_ID('FUGAZZETA.TR_MovimientosHotel_A_I') IS NOT NULL
DROP TRIGGER FUGAZZETA.TR_MovimientosHotel_A_I
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
Habilitado bit default 1,
UNIQUE (Id_TipoDoc,Nro_Doc)
)

SELECT * INTO FUGAZZETA.ClientesDuplicados FROM FUGAZZETA.Clientes
ALTER TABLE FUGAZZETA.ClientesDuplicados
ADD PRIMARY KEY (Id_Cliente),
FOREIGN KEY (Id_TipoDoc) REFERENCES FUGAZZETA.TiposDoc,
FOREIGN KEY (Nacionalidad) REFERENCES FUGAZZETA.Paises,
DEFAULT 1 FOR Habilitado
DBCC CHECKIDENT ('FUGAZZETA.ClientesDuplicados',RESEED,1)

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
NroFactura int IDENTITY(1,1) PRIMARY KEY,
Id_Hotel INT FOREIGN KEY REFERENCES FUGAZZETA.Hoteles,
Fecha date,
Total numeric (10,2),
Id_Cliente int FOREIGN KEY REFERENCES FUGAZZETA.Clientes
)
CREATE TABLE FUGAZZETA.[Items_Hospedaje](
NroFactura int FOREIGN KEY REFERENCES FUGAZZETA.Facturas,
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
CREATE TRIGGER FUGAZZETA.TR_MovimientosHotel_A_I ON FUGAZZETA.MovimientosHotel
AFTER INSERT AS
BEGIN
	UPDATE FUGAZZETA.Hoteles
	SET Habilitado = 0
	WHERE EXISTS (SELECT Id_Hotel FROM INSERTED)
END
GO


--------------------------/* Poblado de Datos*/---------------------------------------------
--------------------------------------------------------------------------------------------
INSERT INTO FUGAZZETA.Paises values ('Argentina')
INSERT INTO FUGAZZETA.Paises values ('Uruguay')
INSERT INTO FUGAZZETA.Paises values ('España')
INSERT INTO FUGAZZETA.Paises values ('Brasil')
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
UPDATE FUGAZZETA.Hoteles SET Pais = 1
GO

INSERT INTO FUGAZZETA.Roles values('Administrador General',1)
insert into FUGAZZETA.Roles values('Administrador',1)
insert into FUGAZZETA.Roles values('Recepcionista',1)
insert into FUGAZZETA.Roles values('Guest',1)
GO

INSERT INTO FUGAZZETA.TiposDoc values ('DNI')
INSERT INTO FUGAZZETA.TiposDoc values ('LC')
INSERT INTO FUGAZZETA.TiposDoc values ('LE')
INSERT INTO FUGAZZETA.TiposDoc values ('Pasaporte')
go

INSERT INTO FUGAZZETA.Usuarios (Username, Contraseña) values ('admin','w23e')
INSERT INTO FUGAZZETA.Usuarios (Username) values ('guest')
go

CREATE PROCEDURE FUGAZZETA.MigrarClientes AS
BEGIN
DECLARE @NUEVOSEED int
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

	INSERT INTO FUGAZZETA.ClientesDuplicados
	(Nro_Doc,Apellido,Nombre,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto)
	SELECT * FROM #TmpClientes
	WHERE Cliente_Pasaporte_Nro IN (
	SELECT Cliente_Pasaporte_Nro
	FROM #TmpClientes
	group by Cliente_Pasaporte_Nro
	having COUNT(*)>1)

	SET @NUEVOSEED = @@ROWCOUNT + 1
	DBCC CHECKIDENT ('FUGAZZETA.Clientes',RESEED,@NUEVOSEED)
	
	INSERT INTO FUGAZZETA.Clientes
	(Nro_Doc,Apellido,Nombre,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto)
	SELECT * FROM #TmpClientes
	WHERE Cliente_Pasaporte_Nro NOT IN (
	SELECT Cliente_Pasaporte_Nro
	FROM #TmpClientes
	group by Cliente_Pasaporte_Nro
	having COUNT(*)>1)

	UPDATE FUGAZZETA.Clientes SET Nacionalidad = 1
	UPDATE FUGAZZETA.ClientesDuplicados SET Nacionalidad = 1
END 
EXEC FUGAZZETA.MigrarClientes
GO

--HistorialBajasHotel: no hay informacion de bajas de hotel

INSERT INTO FUGAZZETA.[Usuarios x Hoteles x Rol]
(Username,Id_Hotel)
SELECT U.Username, H.Id_Hotel FROM FUGAZZETA.Usuarios U, FUGAZZETA.Hoteles H where U.Username = 'admin' OR U.Username = 'guest'
UPDATE FUGAZZETA.[Usuarios x Hoteles x Rol] SET Id_Rol = 1 where Username = 'admin'
UPDATE FUGAZZETA.[Usuarios x Hoteles x Rol] SET	Id_Rol = 4 where Username = 'guest'
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

--FUNCIONALIDADESxROL

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

--RESERVA

--MOVIMIENTOSRESERVA

--ACOMPAÑANTES: NO HAY INFORMACION DE PERSONAS QUE ACOMPAÑARON EN UNA ESTADIA.

SET IDENTITY_INSERT FUGAZZETA.TiposHabitacion ON
INSERT INTO FUGAZZETA.TiposHabitacion (Id_TipoHab,Descripcion,Porcentual)
SELECT DISTINCT Habitacion_Tipo_Codigo,Habitacion_Tipo_Descripcion,Habitacion_Tipo_Porcentual FROM gd_esquema.Maestra
SET IDENTITY_INSERT FUGAZZETA.TiposHabitacion OFF
UPDATE FUGAZZETA.TiposHabitacion SET CantPersonas = 1 WHERE Id_TipoHab = 1001
UPDATE FUGAZZETA.TiposHabitacion SET CantPersonas = 2 WHERE Id_TipoHab = 1002
UPDATE FUGAZZETA.TiposHabitacion SET CantPersonas = 3 WHERE Id_TipoHab = 1003
UPDATE FUGAZZETA.TiposHabitacion SET CantPersonas = 4 WHERE Id_TipoHab = 1004
UPDATE FUGAZZETA.TiposHabitacion SET CantPersonas = 5 WHERE Id_TipoHab = 1005
GO

--FACTURAS

--ITEMS_HOSPEDAJE

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

--ITEMS_CONSUMIBLE

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

-- HABITACIONES X RESERVAS


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

CREATE PROCEDURE FUGAZZETA.OcupacionEnHotelEnPeriodo (@Hotel int,@Desde date, @Hasta date) AS
BEGIN
SELECT * FROM FUGAZZETA.ReservasNoCanceladas
WHERE Id_Hotel = @Hotel AND 
((Fecha_Inicio >= @Desde AND Fecha_Inicio <=@Hasta) OR
 (Fecha_Egreso >= @Desde AND Fecha_Egreso <= @Hasta) OR
 (Fecha_Fin_Reserva >= @Desde AND Fecha_Fin_Reserva <= @Hasta))
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

--- HASTA ACÁ SE PUEDE EJECUTAR BIEN. HAY QUE ORGANIZARNOS DESPUÉS COMO VAMOS DESARROLLANDO.

----------------------------------------/*PROCEDIMIENTO-NO SE SI ESTA BIEN*/----------------
--------------------------------------------------------------------------------------------

CREATE FUNCTION FUGAZZETA.calcular_total_factura (@NroFactura int)
RETURNS int AS
BEGIN
	DECLARE @TotalHospedaje numeric(10,2)
	DECLARE @TotalConsumibles numeric(10,2)
	DECLARE @TotalFactura numeric(10,2)
	
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

-- ESTOS INSERTS ANDARIAN PERO FALLAN POR FALTA DE FK (CUALQUIER COSA HABLAR CON EMI).

--RESERVAS
SET IDENTITY_INSERT FUGAZZETA.Reservas ON
INSERT INTO FUGAZZETA.Reservas
(Id_Reserva,Id_Cliente, Id_Hotel,Fecha_Inicio,Fecha_Fin_Reserva,Id_Regimen)

SELECT
M.Reserva_Codigo, C.Id_Cliente, H.Id_Hotel, M.ReservaIngreso, M.FinReserva, REG.Id_Regimen
FROM
FUGAZZETA.[TodosLosClientes] C, FUGAZZETA.Hoteles H, FUGAZZETA.Regimenes REG,
(SELECT DISTINCT
Reserva_Codigo, Cliente_Pasaporte_Nro, Cliente_Apellido, Hotel_Calle, Hotel_Nro_Calle,
cast(DATEADD(d,Reserva_Cant_Noches,Reserva_Fecha_Inicio) as DATE) as FinReserva,
cast(Reserva_Fecha_Inicio as DATE) AS ReservaIngreso,
cast(Estadia_Fecha_Inicio as DATE) AS Ingreso,
cast(DATEADD(d,Estadia_Cant_Noches,Estadia_Fecha_Inicio) as DATE) as Egreso,
Regimen_Descripcion
FROM gd_esquema.Maestra) AS M
WHERE
	C.Nro_Doc = M.Cliente_Pasaporte_Nro
AND C.Apellido = M.Cliente_Apellido
AND H.Calle = M.Hotel_Calle 
AND H.Nro_Calle = M.Hotel_Nro_Calle 
AND REG.Descripcion = M.Regimen_Descripcion
AND M.Ingreso IS NULL
AND M.Egreso IS NULL
order by M.Reserva_Codigo

SET IDENTITY_INSERT FUGAZZETA.Reservas OFF

MERGE INTO FUGAZZETA.Reservas RES
USING
(SELECT Reserva_Codigo,Egreso FROM
(SELECT DISTINCT
Reserva_Codigo,
Cliente_Pasaporte_Nro, Cliente_Apellido,
Hotel_Calle, Hotel_Nro_Calle,
cast(Estadia_Fecha_Inicio as DATE) AS [Ingreso],
cast(DATEADD(d,Estadia_Cant_Noches,Estadia_Fecha_Inicio) as DATE) as [Egreso],
Regimen_Descripcion
FROM gd_esquema.Maestra) AS M
WHERE 
	Ingreso IS NOT NULL
AND Egreso IS NOT NULL) E
ON RES.Id_Reserva = E.Reserva_Codigo
WHEN MATCHED THEN UPDATE
SET Fecha_Egreso = E.Egreso,
	Id_EstadoReserva = 6;

UPDATE FUGAZZETA.Reservas SET Id_EstadoReserva = 5 WHERE Id_EstadoReserva IS NULL
GO

--FACTURAS
SET IDENTITY_INSERT FUGAZZETA.Facturas ON
INSERT INTO FUGAZZETA.Facturas
(NroFactura,Id_Hotel,Fecha,Total,Id_Cliente)
SELECT DISTINCT
M.Factura_Nro,H.Id_Hotel,cast(M.Factura_Fecha as DATE), M.Factura_Total, C.Id_Cliente
FROM gd_esquema.Maestra M, FUGAZZETA.Hoteles H, FUGAZZETA.[TodosLosClientes] C
where
	M.Factura_Nro IS NOT NULL
AND H.Calle = M.Hotel_Calle
AND H.Nro_Calle = M.Hotel_Nro_Calle
AND C.Nro_Doc = M.Cliente_Pasaporte_Nro
AND C.Apellido = M.Cliente_Apellido
ORDER BY M.Factura_Nro
SET IDENTITY_INSERT FUGAZZETA.Facturas OFF
GO

--ITEMS_HOSPEDAJE
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
	-- Después del poblado no se permitirán valores nulos.
	ALTER TABLE FUGAZZETA.Items_Hospedaje
	ADD PRIMARY KEY (NroFactura,Ocupadas)
END
EXEC FUGAZZETA.Migrar_ItemsHospedaje
GO

--ITEMS_CONSUMIBLES
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

--HABITACIONES X RESERVA
INSERT INTO FUGAZZETA.[Habitaciones x Reservas]
SELECT DISTINCT M.Reserva_Codigo,H.Id_Hotel,M.Habitacion_Numero FROM gd_esquema.Maestra M, FUGAZZETA.Hoteles H
WHERE
	H.Calle = M.Hotel_Calle
AND H.Nro_Calle = M.Hotel_Nro_Calle
ORDER BY M.Reserva_Codigo
GO

