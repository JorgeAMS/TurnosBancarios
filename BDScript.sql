create database BankT
go
use BankT
create table Turno(
ID int identity (1,1),
Tipo varchar (2) not null,
Numero Varchar (2) not null,
Modulo varchar (2) not null,
IDCliente varchar (10) not null,
Estado varchar (20) not null,
FechaAt datetime
)
alter table Turno add constraint PK_Turno primary key(ID)
