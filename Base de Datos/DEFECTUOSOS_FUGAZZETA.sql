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