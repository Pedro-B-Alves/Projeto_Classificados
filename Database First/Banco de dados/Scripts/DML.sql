USE Projeto_Xpto;
GO

INSERT INTO tipoUsuario(titulo)
VALUES		('Administrador')
		   ,('Cliente');
GO

INSERT INTO usuario(idTipoUsuario, email, senha, nome, telefone, imagem, cidade, estado)
VALUES		(1, 'admin@admin.com','admin1234','Admin','11912345678', 'https://github.com/RenatoAlvesdv.png', 'São Paulo','São Paulo')
		   ,(2, 'vini@cliente.com','vini1234','Vini','11912345677', 'https://github.com/Vinixiii.png', 'São Paulo','São Paulo')
		   ,(2, 'pedro@gmail.com','pedro1234','Pedro','11912345676', 'https://github.com/Pedro-B-Alves.png', 'São Paulo','São Paulo');
GO

INSERT INTO anuncio(nome, descricao, imagem, preco, idUsuario)
VALUES		('playstation 2','Em boa condição','https://i.zst.com.br/thumbs/12/1b/2d/36173618.jpg',600.00, 1)
		   ,('playstation 3','Em boa condição','https://upload.wikimedia.org/wikipedia/commons/d/d3/Sony-PlayStation-3-2001A-wController-L.jpg',800.00, 2)
		   ,('playstation 4','Em boa condição','https://tecnoblog.net/wp-content/uploads/2020/12/Playstation-4D-700x700.jpg',1200.00, 3)
		   ,('PC Gamer','Em boa condição e ótimo desempenho','https://a-static.mlcdn.com.br/618x463/computador-pc-gamer-completo-i5-8gb-ssd-240gb-monitor-intel/wssolucoes/9978683981/7a62945f9b8686184cdb745706ee069d.jpg',1500.00, 3)
		   ,('Xbox One','Em boa condição','https://tecnoblog.net/wp-content/uploads/2020/12/Xbox-One-500GBa-700x700.jpg',1200.00, 2)
		   ,('Nintendo Switch','Em boa condição','https://images-americanas.b2w.io/produtos/01/00/img/1951732/6/1951732670_3GG.jpg',1200.00, 2);
GO

INSERT INTO interesse(idUsuario, idAnuncio)
VALUES		(2, 1)
		   ,(3, 1)
		   ,(1, 2)
		   ,(3, 2)
		   ,(1, 3)
		   ,(2, 3)
		   ,(1, 4)
		   ,(2, 4)
		   ,(1, 5)
		   ,(3, 5)
		   ,(1, 6)
		   ,(3, 6);
GO