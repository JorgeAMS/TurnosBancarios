create database BankT
go
use BankT
create table Turno(
ID int identity (1,1),
Texto varchar (4) not null,
Modulo varchar (2) not null
)
alter table Turno add constraint PK_Turno primary key(ID)
