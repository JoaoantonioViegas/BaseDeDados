--create database stand;
use stand;
create table utilizador(
	ID_utilizador		int					not null	identity(1,1),
	FName				varchar(30)			not null,
	LName				varchar(30)			not null,
	Telefone			decimal(9)			not null,
	email				varchar(40)			unique,
	pw					varchar(20)			not null,
	NIF					varchar(9)			not null,
	primary key (ID_utilizador)
);

create table cliente(
	ID_Cliente			int			not null primary key foreign key references Utilizador(ID_utilizador)	on delete cascade
);

create table vendedor(
	ID_Vendedor			int			not null foreign key references Utilizador(ID_utilizador)
);

create table anuncio(
	ID_Anuncio			int			not null primary key identity(1,1),
	ID_Vendedor			int			not null foreign key references Utilizador(ID_utilizador)		on delete cascade,
	Titulo				varchar(100),
	Preco				real,
);

create table favourites(
	ID_Client			int					not null foreign key references utilizador(ID_utilizador),
	ID_Anuncio			int					not null foreign key references anuncio(ID_Anuncio)		on delete cascade
);

create table item (
	ID					int					not null	primary key identity(1,1),
	ID_Anuncio			int					not null	foreign key references anuncio(ID_Anuncio)	on delete cascade,
	imagem				image
);

create table peca(
	ID_Item				int					not null	primary key	foreign key references Item(ID) on delete cascade,
	Nome				varchar(30)			not null,
	Condicao			varchar(10)			not null	check(Condicao = 'Usado' or Condicao='Novo')
);

create table categoria(
	ID_Peca				int					not null	foreign key references Peca(ID_Item)		on delete cascade,
	Nome				varchar(20)			not null	check(Nome = 'Interiores' or Nome = 'Acessorios' or Nome = 'Suspensao' or Nome = 'Iluminacao' or Nome = 'Carrocaria' or Nome = 'Caixa Velocidades'),
);

--create table Sub_Categoria(
--	Nome_Sub				varchar(20)			not null
--	Nome_Categoria			varchar(30)			not null	foreign key references Categoria(Nome),
--);

create table veiculo(
	ID_Item				int					not null	primary key	foreign key references Item(ID)		on delete cascade,
	Matricula			varchar(6)			not null,
	Modelo				varchar(20)			not null,
	Ano					int					not null,
	Combustivel			varchar(20)			not null	check(Combustivel = 'Gasolina' or Combustivel='Gasoleo' or Combustivel='Eletrico'),
	Marca				varchar(20)			not null
);

create table veiculo_terrestre (
	ID_Veiculo			int					foreign key references Veiculo(ID_Item)		on delete cascade,
	sub_modelo			varchar(30),		
	segmento			varchar(30)			not null	check(segmento = 'Citadino' or segmento = 'Coupé' or segmento = 'Cabrio' or segmento = 'Carrinha' or segmento = 'Monovolume' or segmento = 'SUV'),
	quilometros			int					not null,
	tipo_veiculo		varchar(20)			not null	check(tipo_veiculo = 'Autocaravana' or tipo_veiculo = 'Moto' or tipo_veiculo = 'Comercial' or tipo_veiculo = 'Carro')
);

create table veiculo_aquatico (
	ID_Veiculo			int					foreign key references Veiculo(ID_Item),
	propulsao			varchar				not null			check(propulsao = 'Remo' or propulsao = 'Vela' or propulsao = 'Motor'), 
	tipo_veiculo		varchar(20)			not null			check(tipo_veiculo = 'Barco' or tipo_veiculo = 'Mota_agua')
);

create nonclustered index anuncioVendedorIdIndex on anuncio(ID_Vendedor);

/* Drop tables */
/*
use stand;
drop table veiculo_terrestre;
drop table veiculo_aquatico;
drop table veiculo;
drop table categoria;
drop table peca;
drop table item;
drop table favourites;
drop table anuncio;
drop table cliente;
drop table vendedor;
drop table utilizador;
*/
