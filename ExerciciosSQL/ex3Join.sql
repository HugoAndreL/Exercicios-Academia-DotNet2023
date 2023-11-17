-- ex7 com join
SELECT dinossaur.nome AS Dinossauro,
grupos.nome AS Grupo,
dinossaur.toneladas AS Toneladas,
dinossaur.yDescoberta AS 'Ano Descoberta',
dinossaur.descobridor AS Descobridor,
age.nome AS Era,
age.yBeg AS 'Inicio (milhões)',
age.yEnd AS 'Fim (milhões)',
dinossaur.pais AS País
FROM dinossaur
INNER JOIN grupos on grupos.id = dinossaur.id
INNER JOIN age on age.id = dinossaur.fk_age
ORDER BY 2; -- index

-- ex8 com join
SELECT dinossaur.nome AS 'Dinossauro',
grupos.nome AS 'Grupo',
dinossaur.toneladas AS 'Toneladas',
dinossaur.yDescoberta AS 'Ano Descoberta',
dinossaur.descobridor AS 'Descobridor',
age.nome AS 'Era',
age.yBeg AS 'Inicio (milhões)',
age.yEnd AS 'Fim (milhões)',
dinossaur.pais AS 'País'
FROM dinossaur
INNER JOIN grupos on grupos.id = dinossaur.id
INNER JOIN age on age.id = dinossaur.fk_age
ORDER BY 5;

-- ex9 com join
SELECT dinossaur.nome AS 'Dinossauro',
grupos.nome AS 'Grupo',
dinossaur.toneladas AS 'Toneladas',
dinossaur.yDescoberta AS 'Ano Descoberta',
dinossaur.descobridor AS 'Descobridor',
age.nome AS 'Era',
age.yBeg AS 'Inicio (milhões)',
age.yEnd AS 'Fim (milhões)',
dinossaur.pais AS 'País'
FROM dinossaur
INNER JOIN grupos on grupos.id = dinossaur.fk_grupo
INNER JOIN age ON age.id = dinossaur.fk_age
WHERE grupos.nome = 'Anquilossauros'
ORDER BY yDescoberta;

-- ex10 com join
SELECT dinossaur.nome AS 'Dinossauro',
grupos.nome AS 'Grupo',
dinossaur.toneladas AS 'Toneladas',
dinossaur.yDescoberta AS 'Ano Descoberta',
dinossaur.descobridor AS 'Descobridor',
age.nome AS 'Era',
age.yBeg AS 'Inicio (milhões)',
age.yEnd AS 'Fim (milhões)',
dinossaur.pais AS 'País'
FROM dinossaur
INNER JOIN grupos on grupos.id = dinossaur.fk_grupo
INNER JOIN age ON age.id = dinossaur.fk_age AND
grupos.nome IN ('Anquilossauros', 'Ceratopsídeos') AND
yDescoberta BETWEEN 1900 AND 1999;