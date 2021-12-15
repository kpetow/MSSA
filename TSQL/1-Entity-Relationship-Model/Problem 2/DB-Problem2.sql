create database Problem2

use Problem2

create table Player
(
	Id int identity (1,1) primary key,
	age int not null,
	prefCharacter varchar(25) not null,
	playerName varchar(50) not null
)

create table Team
(
	Id int identity (1,1) primary key,
	teamName varchar (50) not null,
	teamSize int not null,
	playerId int foreign key references Player(Id)
)
create table Game
(
	Id int identity (1,1) primary key
)

create table Outcome
(
	result varchar (25) not null,
	gameId int foreign key references Game(Id),
	teamId int foreign key references Team(Id)
)



select * from Player
select * from Team
select * from Outcome
select * from Game

drop table Player
drop table Team
drop table Outcome
drop table Game