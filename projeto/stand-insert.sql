use stand;
/* Insert data into the tables */
--insert diferent data in the table
insert into utilizador values   (123412343,'João','Silva',912345678,'joao@gmail.com', 'pass1'),
                                (276547567,'Maria','Santos',923456781,'maria@gmail.com', 'pass2'),
                                (398798673,'Pedro','Souza',934567812,'pedro@gmail.com', 'pass3'),
                                (416323756,'José','Pereira',945678913,'jose@gmail.com', 'pass4'),
                                (508697554,'João','Souza',955678914,'souza@gmail.com', 'pass5'),
                                (675820234,'Maria','Pereira',965678915,'pereira@gmail.com', 'pass6'),
                                (757480192,'Pedro','Pereira',975678916,'pp@gmail.com', 'pass7'),
                                (855882299,'José','Santos',985678917,'js@gmail.com', 'pass8'),
                                (999999922,'João','Pereira',995678918,'jp@gmail.com', 'pass9'),
                                (100043781,'Hugo','Santos',100567891,'hs@gmail.com', 'pass10'),
								(578234896, 'Francisco', 'Lopes', 947234552, 'bombaatomicz@toohottohandle.com', 'pass11');

insert into cliente values		(123412343),
								(276547567),
								(398798673),
								(416323756),
								(508697554);

insert into vendedor values		(100043781,123456789),
								(999999922,234567890),
								(855882299,345678901),
								(757480192,456789012),
								(675820234,567890123);

insert into anuncio values  (1,100043781,'Titulo1',1000.00),
                            (2,757480192,'Titulo2',20000.00),
                            (3,100043781,'Titulo3',30000.00),
                            (4,757480192,'Titulo4',40000.00),
                            (5,100043781,'Titulo5',50.00),
                            (6,999999922,'Titulo6',60.00),
                            (7,855882299,'Titulo7',70.00),
                            (8,999999922,'Titulo8',80.00),
                            (9,855882299,'Titulo9',90.00),
                            (10,675820234,'Titulo10',100.00);

insert into favourites values	(123412343, 2),
								(123412343, 4),
								(276547567, 5),
								(276547567, 4),
								(276547567, 1),
								(398798673, 9),
								(508697554, 10),
								(508697554, 1),
								(508697554, 3),
								(508697554, 2);


insert into item values	(111111111, 3),
						(222222222, 4),
						(333333333, 1),
						(555555555, 2),
						(444444444, 5),
						(666666666, 6),
						(777777777, 7),
						(888888888, 8),
						(999999999, 9),
						(101010101, 10);

insert into peca values (111111111, 'Peca1', 'Usado'),
						(222222222, 'Peca2', 'Usado'),
						(333333333, 'Peca3', 'Novo'),
						(444444444, 'Peca4', 'Usado'),
						(555555555, 'Peca5', 'Novo');

insert into categoria values	(111111111, 'Interiores'),
								(222222222, 'Acessorios'),
								(333333333, 'Suspensao'),
								(444444444, 'Suspensao'),
								(555555555, 'Interiores');

insert into veiculo values	(666666666, 'AB12AB', 'Astra', 2001, 'Gasolina', 'Opel'),
							(777777777, '12YY89', 'Ibiza', 1999, 'Gasolina', 'Seat'),
							(888888888, '00GF01', 'TT', 2001, 'Gasoleo','Audi'),
							(999999999, '09TR09', 'Model X', 2022, 'Eletrico', 'Tesla'),
							(101010101, 'TT33RE', 'ZOE', 2021, 'Eletrico', 'Renault');

insert into veiculo_terrestre(ID_Veiculo, segmento, quilometros, tipo_veiculo)
values	(666666666, 'Cabrio', 100000, 'Carro'),
		(777777777, 'Comercial', 39000, 'Carro'),
		(888888888, 'Citadino', 123900, 'Carro'),
		(999999999, 'Citadino', 99800, 'Carro'),
		(101010101, 'Citadino', 40000, 'Carro');



/* Delete data from tables */
/*
use stand;
delete from favourites;
delete from anuncio;
delete from vendedor;
delete from cliente;
delete from utilizador;
*/