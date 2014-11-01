---DEFECTUOSOS-----
-------------------

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
CREATE PROCEDURE FUGAZZETA.MigrarReservas AS
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

/*
CREATE TRIGGER FUGAZZETA.TR_Reservas_A_U ON FUGAZZETA.Reservas
AFTER UPDATE AS
BEGIN
	DECLARE mi_cursor CURSOR FOR (SELECT Id_Reserva,Fecha_Inicio,Fecha_Egreso,Id_EstadoReserva FROM UPDATED)
	DECLARE @Reserva int
	DECLARE @Inicio date
	DECLARE @Salida date
	DECLARE @Estado int	
	OPEN mi_cursor FETCH NEXT FROM mi_cursor INTO @Reserva,@Inicio,@Salida,@Estado
	WHILE @@FETCH_STATUS = 0
		BEGIN
		IF (@Estado = 6 AND @Salida IS NULL)
			INSERT INTO FUGAZZETA.MovimientosReserva (Id_Reserva,Proceso,Motivo) VALUES (@RESERVA,'I','Ingreso al hotel')
		IF (@Estado = 6 AND @Salida IS NOT NULL)
			INSERT INTO FUGAZZETA.MovimientosReserva (Id_Reserva,Proceso,Motivo) VALUES (@RESERVA,'E','Egreso del hotel')
		FETCH NEXT FROM mi_cursor INTO @Reserva
		END
	CLOSE mi_cursor
	DEALLOCATE mi_cursor
*/