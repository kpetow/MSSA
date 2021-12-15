create database Problem1

use Problem1

create table Factory
(
	Id int identity(1,1) primary key,
	factoryName varchar(50) not null,
	stock int not null,
	contactInfo varchar(100) not null
)
create table Item
(
	Id int identity(1,1) primary key,
	itemName varchar(50) not null,
	itemDescription varchar (100) not null,
	factoryId int foreign key references Factory(Id)
)
create table Customer
(
	Id int identity(1,1) primary key,
	customerName varchar(50) not null,
	balance float not null,
	creditLimit float not null,
	shipAddress varchar(50) not null
)
create table CustomerOrder
(
	Id int identity(1,1) primary key,
	shipAddress varchar(50) not null,
	quantity int not null,
	orderDate varchar(25) not null, --lookup if there is a date variable type
	itemId int foreign key references Item(Id),
	customerId int foreign key references Customer(Id)
)



select * from Customer
select * from CustomerOrder
select * from Item
select * from Factory

drop table Customer
drop table CustomerOrder
drop table Item
drop table Factory