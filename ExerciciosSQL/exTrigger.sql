CREATE TABLE log
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	acao VARCHAR(15) NOT NULL,
	descricao VARCHAR(250),
	quando DATETIME NOT NULL
);

ALTER TABLE dinossaur
ADD yVivo INTEGER;

CREATE TRIGGER CheckInsertDino
ON dinossaur
AFTER INSERT
AS
BEGIN
	DECLARE @dinoY INTEGER
	DECLARE @ageIni INTEGER
	DECLARE @ageEnd INTEGER
 
	SELECT @dinoY = (SELECT inserted.yVivo from inserted)
	select @ageIni = (select age.yBeg from age where age.id = (SELECT inserted.fk_age from inserted))
	select @ageEnd = (select age.yEnd from age where age.id = (SELECT inserted.fk_age from inserted))
	IF @dinoY BETWEEN @ageIni AND @ageEnd
	BEGIN
		INSERT INTO log VALUES ('Inserção', 'Novo dinossauro inserido em Dinossauros', GETDATE());
		PRINT('Dinossauro inseridos com sucesso!')
	END
	ELSE
	BEGIN
		ROLLBACK;
		INSERT INTO log VALUES ('Inserção', 'tentativa de inserção de novo dinossauro na tabela Dinossauros', GETDATE());
		RAISERROR('INVALIDO, Impossivel colocar ano de esistencia maior que era', 14,1);
		RETURN;
	END
END

-- Testando
INSERT INTO dinossaur 
VALUES (
	'Acressauro',
	2,
	5,
	2002,
	'Hugo André',
	2,
	'Brasil',
	500
);