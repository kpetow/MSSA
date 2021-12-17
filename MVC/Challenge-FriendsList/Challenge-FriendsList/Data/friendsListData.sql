create database Friends;
use Friends;

create table Friend(
	id int PRIMARY KEY IDENTITY (1,1),
	friendName varchar(50) not null,
	place varchar(50) not null,
	age int not null,
	occupation varchar(50) not null,
	sport varchar(50) not null
)

insert into Friend (friendName, place, age, occupation, sport) values ('Kevin', 'Florida', 27, 'Student', 'Track')

select * from Friend

drop table Friend