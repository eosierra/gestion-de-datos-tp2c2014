USE GD2C2014
go
CREATE SCHEMA FUGAZZETA AUTHORIZATION gd
go
GRANT CREATE TABLE TO gd
go

--Hoteles
SELECT DISTINCT
Hotel_Calle,
Hotel_Ciudad,
Hotel_Nro_Calle,
Hotel_CantEstrella,
Hotel_Recarga_Estrella 
FROM gd_esquema.Maestra
go

--Roles
CREATE TABLE Roles(
Id int unique,
Nombre varchar(23) not null,
Estado bit)

insert into Roles(Id,Nombre,Estado)
values(1,'Administrador',1)
go
insert into 
values(2,'Recepcionista',1)
values(3,'Guest',1)
go

