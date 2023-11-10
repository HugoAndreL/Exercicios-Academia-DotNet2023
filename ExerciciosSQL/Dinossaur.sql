USE [master];

CREATE DATABASE dboDinassaur ON PRIMARY (
	NAME = dbo_Dinassaur,
	FILENAME = 'C:\workspace\Exercicios-Academia-DotNet2023-master\ExerciciosSQL\DBs\MDF\dbo_Dinassaur.mdf',
	SIZE = 5MB,
	FILEGROWTH = 10MB
) LOG ON (
	NAME = dbo_Dinassaur_log,
	FILENAME = 'C:\workspace\Exercicios-Academia-DotNet2023-master\ExerciciosSQL\DBs\LDF\dbo_Dinassaur_log.ldf',
	SIZE = 5MB,
	FILEGROWTH = 10MB
);

USE [dboDinassaur];

CREATE TABLE age (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(60) NOT NULL,
	yBeg INTEGER NOT NULL,
	yEnd INTEGER NOT NULL
);

CREATE TABLE grupos (
	id INTEGER PRIMARY KEY NOT NULL IDENTITY,
	nome VARCHAR(50) NOT NULL
);

CREATE TABLE dinossaur (
	nome VARCHAR(25) NOT NULL,
	fk_grupo INTEGER NOT NULL,
	toneladas INTEGER NOT NULL,
	yDescoberta INTEGER NOT NULL,
	descrobidor VARCHAR(30) NOT NULL,
	fk_age INTEGER NOT NULL,
	yVivo INTEGER NOT NULL,
	pais VARCHAR(50) NOT NULL,

	FOREIGN KEY (fk_grupo) REFERENCES grupos(id),
	FOREIGN KEY (fk_age) REFERENCES age(id)
);