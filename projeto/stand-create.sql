--create database stand;
use stand;
create table utilizador(
	ID_utilizador		varchar(9)			not null primary key,
	FName				varchar(30)			not null,
	LName				varchar(30)			not null,
	Telefone			decimal(9)			not null,
	email				varchar(40)			not null,
	pw					varchar(20)			not null
);

create table cliente(
	ID_Cliente			varchar(9)			not null primary key
	foreign key references Utilizador(ID_utilizador)
);

create table vendedor(
	ID_Vendedor			varchar(9)			not null foreign key references Utilizador(ID_utilizador),
	NIF					varchar(9)			not null primary key
);

create table anuncio(
	ID_Anuncio			varchar(9)			not null primary key,
	ID_Vendedor			varchar(9)			not null foreign key references Utilizador(ID_utilizador),
	Titulo				varchar(100),
	Preco				real
);

create table favourites(
	ID_Client			varchar(9)			not null foreign key references cliente(ID_Cliente),
	ID_Anuncio			varchar(9)			not null foreign key references anuncio(ID_Anuncio)
);

create table item (
	ID					varchar(9)			not null	primary key,
	ID_Anuncio			varchar(9)			not null foreign key references anuncio(ID_Anuncio)
);

create table peca(
	ID_Item				varchar(9)			not null	primary key	foreign key references Item(ID),
	Nome				varchar(30)			not null,
	Condicao			varchar(10)			not null	check(Condicao = 'Usado' or Condicao='Novo')
);

create table categoria(
	ID_Peca				varchar(9)			not null	foreign key references Peca(ID_Item),
	Nome				varchar(20)			not null	check(Nome = 'Interiores' or Nome = 'Acessorios' or Nome = 'Suspensao' or Nome = 'Iluminacao' or Nome = 'Carrocaria' or Nome = 'Caixa Velocidades'),
);

--create table Sub_Categoria(
--	Nome_Sub				varchar(20)			not null
--	Nome_Categoria			varchar(30)			not null	foreign key references Categoria(Nome),
--);

create table veiculo(
	ID_Item				varchar(9)			not null	primary key	foreign key references Item(ID),
	Matricula			varchar(6)			not null,
	Modelo				varchar(20)			not null,
	Ano					int					not null,
	Combustivel			varchar(20)			not null	check(Combustivel = 'Gasolina' or Combustivel='Gasoleo' or Combustivel='Eletrico'),
	Marca				varchar(20)			not null
);

create table veiculo_terrestre (
	ID_Veiculo			varchar(9)			foreign key references Veiculo(ID_Item),
	sub_modelo			varchar(30),		
	segmento			varchar(30)			not null,	--citadino, coupe etc etc
	quilometros			int					not null,
	tipo_veiculo		varchar(20)			not null			check(tipo_veiculo = 'Autocaravana' or tipo_veiculo = 'Moto' or tipo_veiculo = 'Comercial' or tipo_veiculo = 'Carro')
);

create table veiculo_aquatico (
	ID_Veiculo			varchar(9)			foreign key references Veiculo(ID_Item),
	propulsao			varchar				not null			check(propulsao = 'Remo' or propulsao = 'Vela' or propulsao = 'Motor'), 
	tipo_veiculo		varchar(20)			not null			check(tipo_veiculo = 'Barco' or tipo_veiculo = 'Mota_agua')
);
