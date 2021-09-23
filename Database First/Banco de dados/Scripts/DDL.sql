CREATE DATABASE Projeto_Xpto;
GO

USE Projeto_Xpto;
GO

CREATE TABLE tipoUsuario
(
	idTipoUsuario	INT PRIMARY KEY IDENTITY
	,titulo			VARCHAR(150) UNIQUE NOT NULL
);
GO

CREATE TABLE usuario
(
	idUsuario		INT PRIMARY KEY IDENTITY
	,idTipoUsuario	INT FOREIGN KEY REFERENCES tipoUsuario(idTipoUsuario)
	,email			VARCHAR(60) UNIQUE NOT NULL
	,senha			VARCHAR(60) NOT NULL
	,nome			VARCHAR(60) NOT NULL
	,telefone		VARCHAR(18) NOT NULL
	,imagem			VARCHAR(255)
	,cidade			VARCHAR(30) NOT NULL
	,estado			VARCHAR(30) NOT NULL
);
GO

CREATE TABLE anuncio
(
	idAnuncio		INT PRIMARY KEY IDENTITY
	,idUsuario		INT FOREIGN KEY REFERENCES usuario(idUsuario)
	,nome			VARCHAR(60) NOT NULL
	,descricao		VARCHAR(255) NOT NULL
	,imagem			VARCHAR(255)
	,preco			FLOAT NOT NULL
);
GO

CREATE TABLE interesse
(
	idInteresse		INT PRIMARY KEY IDENTITY
	,idUsuario		INT FOREIGN KEY REFERENCES usuario(idUsuario)
	,idAnuncio		INT FOREIGN KEY REFERENCES anuncio(idAnuncio)
);
GO