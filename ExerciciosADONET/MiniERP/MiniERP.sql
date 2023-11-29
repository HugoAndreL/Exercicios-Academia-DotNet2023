-- Uso futuro para projeto final
CREATE DATABASE dboMiniERP;

USE dboMiniERP;

CREATE TABLE [Fornecedores] (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(30) NOT NULL
);

ALTER TABLE [Fornecedores] 
ADD cnpj INTEGER NOT NULL,
descricao VARCHAR(50) NULL,
datCriacao DATETIME NULL;

ALTER TABLE Fornecedores
ALTER COLUMN descricao TEXT NULL;

EXEC sp_rename 'Fornecedores.descricao', 'funcao', 'COLUMN';

ALTER TABLE Fornecedores
ALTER COLUMN datCriacao VARCHAR(10) NULL;

CREATE TABLE [Produtos] (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(30) NOT NULL,
	fk_forn INTEGER NOT NULL,

	FOREIGN KEY (fk_forn) REFERENCES Fornecedores(id)
);

ALTER TABLE [Produtos] 
ADD preco INTEGER NOT NULL,
descricao TEXT NOT NULL;

CREATE TABLE [Clients] (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(30) NOT NULL
);

ALTER TABLE [Clients]
ADD cpf INTEGER NOT NULL,
datNasc VARCHAR(10) NULL;

CREATE TABLE [nota_cliente] (
	fk_notaId INTEGER NOT NULL,
	fk_clientId INTEGER NOT NULL
);

ALTER TABLE nota_cliente 
ADD FOREIGN KEY (fk_notaId) REFERENCES Nota(id),
FOREIGN KEY (fk_clientId) REFERENCES Clients(id);

CREATE TABLE [nota_prod] (
	fk_notaId INTEGER NOT NULL,
	fk_prodId INTEGER NOT NULL
);

ALTER TABLE [nota_prod]
ADD FOREIGN KEY (fk_notaId) REFERENCES Nota(id),
FOREIGN KEY (fk_prodId) REFERENCES Produtos(id);

CREATE TABLE [Nota] (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(30) NOT NULL,
	fk_cliente INTEGER NOT NULL,
	fk_prod INTEGER NOT NULL
);

ALTER TABLE [Nota]
ADD rg INTEGER NOT NULL,
metPagamento VARCHAR(10) NOT NULL,
datCompra DATE NOT NULL;

CREATE LOGIN MiniERP WITH PASSWORD = 'MiniERP123';

CREATE USER MiniERP FROM LOGIN MiniERP;

EXEC sp_addrolemember 'DB_DATAREADER', 'MiniERP';

EXEC sp_addrolemember 'DB_DATAWRITER', 'MiniERP';
