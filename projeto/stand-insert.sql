-- use stand;
/* Insert data into the tables */
--insert diferent data in the table
insert into utilizador values   ('João','Silva',912345678,'joao@gmail.com', 'pass1',1273463723),
                                ('Maria','Santos',923456781,'maria@gmail.com', 'pass2',123678934),
                                ('Pedro','Souza',934567812,'pedro@gmail.com', 'pass3',098902345),
                                ('José','Pereira',945678913,'jose@gmail.com', 'pass4',126354321),
                                ('João','Souza',955678914,'souza@gmail.com', 'pass5',765409823),
                                ('Maria','Pereira',965678915,'pereira@gmail.com', 'pass6',092312374),
                                ('Pedro','Pereira',975678916,'pp@gmail.com', 'pass7',567890123),
                                ('José','Santos',985678917,'js@gmail.com', 'pass8',456789012),
                                ('João','Pereira',995678918,'jp@gmail.com', 'pass9',345678901),
                                ('Hugo','Santos',100567891,'hs@gmail.com', 'pass10',234567890),
								('Francisco', 'Lopes', 947234552, 'bombaatomicz@toohottohandle.com', 'pass11',123456789);

insert into cliente values		(1),
								(2),
								(3),
								(4),
								(5);

insert into vendedor values		(10),
								(9),
								(8),
								(7),
								(6);

insert into anuncio values  (10,'Titulo1',1000.00),
                            (7,'Titulo2',20000.00),
                            (10,'Titulo3',30000.00),
                            (7,'Titulo4',40000.00),
                            (10,'Titulo5',50.00),
                            (9,'Titulo6',60.00),
                            (8,'Titulo7',70.00),
                            (9,'Titulo8',80.00),
                            (8,'Titulo9',90.00),
                            (6,'Titulo10',100.00);

insert into favourites values	(1, 2),
								(1, 4),
								(2, 5),
								(2, 4),
								(2, 1),
								(3, 9),
								(5, 10),
								(5, 1),
								(5, 3),
								(5, 2);


insert into item values	(3, null),
						(4, null),
						(1, null),
						(2, null),
						(5, null),
						(6, null),
						(7, null),
						(8, null),
						(9, null),
						(10, null);

insert into peca values (1, 'Peca1', 'Usado'),
						(2, 'Peca2', 'Usado'),
						(3, 'Peca3', 'Novo'),
						(4, 'Peca4', 'Usado'),
						(5, 'Peca5', 'Novo');

insert into categoria values	(1, 'Interiores'),
								(2, 'Acessorios'),
								(3, 'Suspensao'),
								(4, 'Suspensao'),
								(5, 'Interiores');

insert into veiculo values	(6, 'AB12AB', 'Astra', 2001, 'Gasolina', 'Opel'),
							(7, '12YY89', 'Ibiza', 1999, 'Gasolina', 'Seat'),
							(8, '00GF01', 'TT', 2001, 'Gasoleo','Audi'),
							(9, '09TR09', 'Model X', 2022, 'Eletrico', 'Tesla'),
							(1, 'TT33RE', 'ZOE', 2021, 'Eletrico', 'Renault');

insert into veiculo_terrestre(ID_Veiculo, segmento, quilometros, tipo_veiculo)
values	(6, 'Cabrio', 100000, 'Carro'),
		(7, 'Coupé', 39000, 'Carro'),
		(8, 'Citadino', 123900, 'Carro'),
		(9, 'Citadino', 99800, 'Carro'),
		(1, 'Citadino', 40000, 'Carro');

/* Delete data from tables */
/*
use stand;
delete from favourites;
delete from anuncio;
delete from vendedor;
delete from cliente;
delete from utilizador;
*/
