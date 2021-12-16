--reset--
drop table Boxes
drop table warehouse
drop database WarehouseExercise

--1--
create database WarehouseExercise
use WarehouseExercise

--2--
create table Warehouses
(
	warehouseId int identity (1,1) primary key,
	place varchar(100),
	capacity int
)

create table Boxes
(
	refNumber int identity (1, 1) primary key,
	content varchar(100),
	price int,
	warehouseId int foreign key references Warehouses(warehouseId)
)

--3--
alter table Warehouses
add city varchar(80)

--4--
drop table Boxes

--5--
create table Boxes
(
	refNumber int identity (1, 1) primary key,
	content varchar(100),
	price int,
	warehouseId int foreign key references Warehouses(warehouseId)
)

--6--
GO
	insert into Warehouses (city) values ('Boston')
	insert into Warehouses (city) values ('Seattle')
	insert into Warehouses (city) values ('New York')
	insert into Warehouses (city) values ('Houston')
	insert into Warehouses (city) values ('Miami')
	insert into Warehouses (city) values ('Chicago')
GO

--7--
insert into Boxes (warehouseId) values (1)
insert into Boxes (warehouseId) values (2)
insert into Boxes (warehouseId) values (3)
insert into Boxes (warehouseId) values (4)
insert into Boxes (warehouseId) values (1)
insert into Boxes (warehouseId) values (3)
insert into Boxes (warehouseId) values (6)
insert into Boxes (warehouseId) values (5)
insert into Boxes (warehouseId) values (5)
insert into Boxes (warehouseId) values (4)

--8--
exec sp_rename 'Warehouses', 'warehouse'

--9--
select * from warehouse

--10--
select refNumber, content, price from Boxes

--11--
update Boxes set price = 200 where refNumber = 1
update Boxes set price = 200 where refNumber = 2
update Boxes set price = 200 where refNumber = 3
update Boxes set price = 200 where refNumber = 4
update Boxes set price = 200 where refNumber = 5
update Boxes set price = 200 where refNumber = 6
update Boxes set price = 200 where refNumber = 7
update Boxes set price = 200 where refNumber = 8
update Boxes set price = 200 where refNumber = 9
update Boxes set price = 200 where refNumber = 10

--12--
select content from Boxes

--13--
insert into warehouse (city, capacity) values ('Barcelona', 5)

--14--
insert into Boxes (content, warehouseId) values (3500, 3)