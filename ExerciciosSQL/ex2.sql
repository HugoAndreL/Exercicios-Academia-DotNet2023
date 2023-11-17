-- ex6



DELETE FROM [cat]
WHERE id = 2;
DELETE FROM [author]
WHERE id = 2;

select * from livros.isbn, livros.title, livros.ano, pub.nome, cat.nome
from livros, pub, cat
where livros.fk_pub = pub.id and livros.fk_cat = cat.id
order by livros.nome, livros.ano asc