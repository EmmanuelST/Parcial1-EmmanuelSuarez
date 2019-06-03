USE master
GO
CREATE DATABASE Parcial1_db
 
USE Parcial1_db
GO

CREATE TABLE Productos
(
	ProductoId int PRIMARY KEY IDENTITY(1,1),
	Descripcion nvarchar(max) NULL,
	Existencia int NOT NULL,
	Costo decimal(18, 2) NOT NULL,
	ValorInventario decimal(18,2) NOT NULL 
)
GO

CREATE TABLE ValorTotalInventarios
(
	ValorInventarioId int PRIMARY KEY IDENTITY(1,1),
	ValorTotal decimal(18, 2) NOT NULL
)
GO

CREATE TABLE ProductoModificacions(
	ModificacionId int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ProductoId int NOT NULL,
	Descripcion nvarchar(max) NULL,
	FechaModificacion datetime NOT NULL
)


use master 
drop database Parcial1_db