CREATE PROCEDURE ex2Procedure (@id AS INTEGER)
AS
SELECT dinossaur.nome AS 'Nome'
FROM dinossaur
WHERE dinossaur.fk_grupo = @id

EXEC ex2Procedure 1;

CREATE PROCEDURE store (@id AS INTEGER, @peso AS INTEGER)
AS
UPDATE dinossaur
SET toneladas = @peso
WHERE id = @id;

EXEC store @id = 1, @peso = 6;