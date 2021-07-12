USE CZBooks;

INSERT INTO TiposUsuarios(tituloTipoUsuario)		
VALUES ('ADM'),
		('Autor'),
		('Cliente');

INSERT INTO Usuarios(idTipoUsuario,email, senha)
VALUES	(1, 'adm@adm.com','123456'),
		(2,'saulo@gmail.com', '123456'),
		(2,'caique@gmail.com','123456'),
		(3,'joao@gmail.com','123456'),
		(3,'maiara@gmail.com','123456');

INSERT INTO Categorias(categoria)
VALUES	('Sci-Fi'),
		('Terror'),
		('Folclore');

INSERT INTO Autores(idUsuario, nomeAutor)
VALUES	(2,'Sau love'),
		(3, 'Caique Lindo');

INSERT INTO Instituicoes(nome, endereco, cnpj)
VALUES ('Savaira','Praça da Sé, 423 - Sé','33.333.333/3333-33'),
		('Tulcura','Av. Paulista, 2073 - Bela Vista','44.444.444/4444-44');

INSERT INTO Livros(idInstituicao, idAutor, idCategoria, titulo, nomeAutor, sinopse, categoria, dataPublicacao, preco)
VALUES	(2, 1, 3, 'O Boitatá', 'Sau Love', 'Neste livro veremos a dismestificação dessa entidade deste folclore', 'Folclore',  2021-03-13-16-00-00, 'R$:30.00'),
		(1, 1, 1, 'Odisséia espacial', 'Sau love' ,'Livro que deu origem ao filme 2001 a space odyssey', 'Sci-Fi', 2020-11-20-05-00-00, 'R$:60.00'),
		(2, 2, 2, 'O mistério do terraço', 'Caique Lindo', 'Muitos estudandes de Dev com notas ruins são levados ao terraço do Senai, e nunca mais são vistos', 'Terror', 2021-12-14-04-00-00, 'R$:400.00');