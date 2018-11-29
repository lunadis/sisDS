use master
go
drop database escola
go
create database escola
go
use escola


create table funcionario(
	id int not null identity(0,1),
	nome varchar(250) not null,
	cpf varchar(12) not null,
	telefone varchar(80) not null,
	celular varchar(80),
	endereco varchar(180)not null,
	comp varchar(130),
	senha varchar(90)
	
	primary key (ID)
);
create table unidade(
	id int not null identity(0,1),
	nome varchar(180),
	Estado varchar(90),
	cdUF varchar(30),
	endereco varchar(180),
	comp varchar(90),
	telefone varchar(30),	
	primary key (ID)
);
create table curso(
	id int not null identity(0,1),
	nome varchar(180),
	area varchar(50),
	primary key (ID)
);
create table aluno(
	id int not null identity(0,1),
	nome varchar(250) not null,
	cpf varchar(12) not null,
	telefone varchar(80) not null,
	celular varchar(80),
	endereco varchar(180)not null,
	comp varchar(130),
	
	primary key (ID)
);
create table professor(
	id int not null identity(0,1),
	nome varchar(250) not null,
	cpf varchar(12) not null,
	telefone varchar(80) not null,
	celular varchar(80),
	Cidade varchar(30),
	codigoUf varchar(5),
	endereco varchar(180)not null,
	comp varchar(130),
	area varchar(100),
	curso varchar(100),
	unidade varchar(100),
	
	primary key (ID)
);
