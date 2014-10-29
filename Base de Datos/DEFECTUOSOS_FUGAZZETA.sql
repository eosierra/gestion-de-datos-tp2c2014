-------------------
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
UPDATE FUGAZZETA.Reservas SET Id_EstadoReserva = 1 WHERE Id_EstadoReserva IS NULL
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
