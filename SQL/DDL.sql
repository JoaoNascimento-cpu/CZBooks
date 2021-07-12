CREATE DATABASE CZBooks

USE CZBooks

CREATE TABLE TiposUsuarios(
	idTipoUsuario INT PRIMARY KEY IDENTITY,
	tituloTipoUsuario VARCHAR(250) UNIQUE
);

CREATE TABLE Usuarios(
	idUsuario INT PRIMARY KEY IDENTITY,
	idTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuarios(idTipoUsuario),
	email VARCHAR(250) NOT NULL UNIQUE,
	senha VARCHAR(6) NOT NULL
);

CREATE TABLE Autores(
	idAutor		INT PRIMARY KEY IDENTITY,
	idUsuario	INT FOREIGN KEY REFERENCES Usuarios(idUsuario),
	nomeAutor	VARCHAR(500) NOT NULL
);

CREATE TABLE Categorias(
	idCategoria		INT PRIMARY KEY IDENTITY,
	categoria		VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Instituicoes(
	idInstituicao	INT PRIMARY KEY IDENTITY,
	nome	VARCHAR(250) NOT NULL,
	endereco	VARCHAR(250) NOT NULL,
	cnpj	VARCHAR(18) NOT NULL
);

CREATE TABLE Livros(
	idLivro INT PRIMARY KEY IDENTITY,
	idCategoria	INT FOREIGN KEY REFERENCES Usuarios(idUsuario),
	idInstituicao	INT FOREIGN KEY REFERENCES Instituicoes(idInstituicao),
	idAutor	INT FOREIGN KEY REFERENCES Autores(idAutor),
	titulo	VARCHAR(250) UNIQUE NOT NULL,
	nomeAutor VARCHAR(250) NOT NULL,
	sinopse VARCHAR(500) NOT NULL,
	categoria VARCHAR(10) NOT NULL,
	dataPublicacao DATETIME NOT NULL,
	preco VARCHAR(250) NOT NULL
);