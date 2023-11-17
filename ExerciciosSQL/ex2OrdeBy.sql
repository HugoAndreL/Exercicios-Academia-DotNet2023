-- ex7
SELECT dinossaur.nome AS 'Dinossauro',
grupos.nome AS 'Grupo',
dinossaur.toneladas AS 'Toneladas',
dinossaur.yDescoberta AS 'Ano Descoberta',
dinossaur.descobridor AS 'Descobridor',
age.nome AS 'Era',
age.yBeg AS 'Inicio (milhões)',
age.yEnd AS 'Fim (milhões)',
dinossaur.pais AS 'País'
FROM age, grupos, dinossaur
WHERE dinossaur.fk_grupo = grupos.id AND
dinossaur.fk_age = age.id
ORDER BY dinossaur.nome ASC;

-- ex8
SELECT dinossaur.nome AS 'Dinossauro',
grupos.nome AS 'Grupo',
dinossaur.toneladas AS 'Toneladas',
dinossaur.yDescoberta AS 'Ano Descoberta',
dinossaur.descobridor AS 'Descobridor',
age.nome AS 'Era',
age.yBeg AS 'Inicio (milhões)',
age.yEnd AS 'Fim (milhões)',
dinossaur.pais AS 'País'
FROM age, grupos, dinossaur
WHERE dinossaur.fk_grupo = grupos.id AND
dinossaur.fk_age = age.id
ORDER BY dinossaur.descobridor ASC;

-- ex9
SELECT dinossaur.nome AS 'Dinossauro',
grupos.nome AS 'Grupo',
dinossaur.toneladas AS 'Toneladas',
dinossaur.yDescoberta AS 'Ano Descoberta',
dinossaur.descobridor AS 'Descobridor',
age.nome AS 'Era',
age.yBeg AS 'Inicio (milhões)',
age.yEnd AS 'Fim (milhões)',
dinossaur.pais AS 'País'
FROM age, grupos, dinossaur
WHERE dinossaur.fk_grupo = grupos.id AND
dinossaur.fk_age = age.id AND
grupos.nome = 'Anquilossauros'
ORDER BY dinossaur.yDescoberta ASC;

-- ex10
SELECT dinossaur.nome AS 'Dinossauro',
grupos.nome AS 'Grupo',
dinossaur.toneladas AS 'Toneladas',
dinossaur.yDescoberta AS 'Ano Descoberta',
dinossaur.descobridor AS 'Descobridor',
age.nome AS 'Era',
age.yBeg AS 'Inicio (milhões)',
age.yEnd AS 'Fim (milhões)',
dinossaur.pais AS 'País'
FROM age, grupos, dinossaur
WHERE dinossaur.fk_grupo = grupos.id AND
dinossaur.fk_age = age.id AND
grupos.nome IN ('Anquilossauros', 'Ceratopsídeos') AND
dinossaur.yDescoberta BETWEEN 1900 AND 1999;