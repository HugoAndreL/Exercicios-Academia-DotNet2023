USE [master];

CREATE DATABASE dboLivraria ON PRIMARY (
	NAME = dbo_Livraria,
	FILENAME = 'C:\workspace\Exercicios-Academia-DotNet2023-master\ExerciciosSQL\DBs\MDF\dbo_Livraria.mdf',
	SIZE = 8MB,
	FILEGROWTH = 64MB
) LOG ON (
	NAME = dbo_Livraria_log,
	FILENAME = 'C:\workspace\Exercicios-Academia-DotNet2023-master\ExerciciosSQL\DBs\LDF\dbo_Livraria_log.ldf',
	SIZE = 8MB,
	FILEGROWTH = 64MB
);

USE [dboLivraria];

CREATE TABLE pub (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(60) NOT NULL
);

CREATE TABLE author (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(50) NOT NULL,
	nation VARCHAR(40)
);

CREATE TABLE cat (
	id INTEGER PRIMARY KEY NOT NULL IDENTITY,
	nome VARCHAR(50) NOT NULL
);

CREATE TABLE livros (
	isbn VARCHAR(22) PRIMARY KEY NOT NULL,
	title VARCHAR(50) NOT NULL,
	ano INTEGER NOT NULL,
	fk_pub INTEGER NOT NULL,
	fk_cat INTEGER NOT NULL,
	FOREIGN KEY (fk_pub) REFERENCES pub(id),
	FOREIGN KEY (fk_cat) REFERENCES cat(id)
);

CREATE TABLE livro_autor (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	fk_livro VARCHAR(22) NOT NULL,
	fk_autor INTEGER NOT NULL,
	FOREIGN KEY (fk_livro) REFERENCES livros(isbn),
	FOREIGN KEY (fk_autor) REFERENCES author(id)
);