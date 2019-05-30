
create database Parcial1_db
go
use Parcial1_db
go
create table Productos
(
	ProductoId int Primary key identity,
	Descripcion varchar(100) not null,
	Existencia int not null,
	Costo decimal not null
)




