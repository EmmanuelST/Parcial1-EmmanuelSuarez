
create database Parcial1_db
go
use Parcial1_db
go
create table Usuarios
(
	ProductoId int Primary key identity,
	Descripcion varchar(100) not null,
	Existencia int not null,
	Costo float not null
)