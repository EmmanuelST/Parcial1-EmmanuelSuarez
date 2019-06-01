
create database Parcial1_db
go
use Parcial1_db
go
create table Productos
(
	ProductoId int Primary key identity,
	Descripcion varchar(100) not null,
	Existencia int not null,
	Costo decimal not null,
	ValorInventario decimal
)

use Master
drop database Parcial1_db

Use Parcial1_db
select * from Productos

Use Parcial1_db
SELECT ValorTotal FROM ValorTotalInventarios Where ValorInventarioId = 1

update ValorTotalInventarios set ValorTotal =(select SUM(ValorTotal)
from Parcial1_db.dbo.Productos)where ValorInventarioId = 1