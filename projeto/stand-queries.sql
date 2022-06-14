use stand;
-- Procurar por título do anúncio
declare @input_value as varchar(50); 
set @input_value = '10';
select * from anuncio where lower(Titulo) like '%' + @input_value + '%';

-- Receber favoritos de um cliente
declare @input_clientID as varchar(50);
set @input_clientID = '123412343';
select * from favourites where ID_Client = @input_clientID;

-- Receber clientes que têm o anúncio como favorito
declare @input_anuncio as varchar(50);
set @input_anuncio = '2';
select ID_Cliente from (cliente join favourites
on ID_Client=ID_Cliente)
where ID_Anuncio = @input_anuncio;

-- Filtrar peças por categoria
declare @input_category as varchar(50);
set @input_category = 'Interiores';
select * from (peca join categoria
on ID_Item = ID_Peca)
where categoria.Nome = @input_category;

-- Filtrar peças por condição
declare @input_condition as varchar(50);
set @input_condition = 'Usado';
select * from peca where Condicao = @input_condition;

-- Filtrar veículo por combustível
declare @input_fuel as varchar(50);
set @input_fuel = 'Eletrico';
select * from veiculo where Combustivel = @input_fuel;

-- Filtrar por veículos que tenham menos de X km
declare @input_km as int;
set @input_km = 100000;
select ID_Item, Matricula, Modelo, Marca, quilometros from (veiculo_terrestre join veiculo on ID_Veiculo=ID_Item)
where quilometros <= @input_km;

/* ===== Procedures ===== */
-- Filtrar anúncios por kms, combustivel, titulo e marca
create procedure search_km_fuel
	@kms as int,
	@title as varchar(40),
	@fuel as varchar(20)
as
	if(@fuel != '' and @kms != '')
	begin
		select Titulo, preco, Marca, Modelo, Ano, Combustivel, quilometros, Matricula from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where (quilometros < @kms) and ((lower(Titulo) like '%' + lower(@title) + '%') or (lower(Marca) like '%' + lower(@title) + '%')) and (lower(Combustivel) = lower(@fuel));
	end
	else if (@fuel != '' and @kms = '')
	begin
		select Titulo, preco, Marca, Modelo, Ano, Combustivel, quilometros, Matricula from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where ((lower(Titulo) like '%' + lower(@title) + '%') or (lower(Marca) like '%' + lower(@title) + '%')) and (lower(Combustivel) = lower(@fuel));
	end
	else if (@fuel = '' and @kms != '')
	begin
		select Titulo, preco, Marca, Modelo, Ano, Combustivel, quilometros, Matricula from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where ((lower(Titulo) like '%' + lower(@title) + '%') or (lower(Marca) like '%' + lower(@title) + '%')) and (quilometros < @kms) ;
	end
	else
	begin
		select Titulo, preco, Marca, Modelo, Ano, Combustivel, quilometros, Matricula from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where ((lower(Titulo) like '%' + lower(@title) + '%') or (lower(Marca) like '%' + lower(@title) + '%'));
	end
go

-- Recebe id do user e retorna uma tabela com os seus anuncios com veiculos terrestres
create procedure get_anuncios_utilizador_veiculos_terrestres
	@id as int
as
	select Titulo, preco, Marca, Modelo, Ano, Combustivel, quilometros, Matricula from anuncio join
		(item join
			(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
		on item.ID = veiculo.ID_Item)
	on anuncio.ID_Anuncio = item.ID_Anuncio
	where anuncio.ID_Vendedor = @id;
go

-- Recebe id do user e retorna uma tabela com os seus anuncios com pecas
create procedure get_anuncios_utilizador_pecas
	@id as int
as
	select * from anuncio join
		(item join
			(peca join categoria on peca.ID_Item = categoria.ID_Peca)
		on item.ID = peca.ID_Item)
	on anuncio.ID_Anuncio = item.ID_Anuncio
	where anuncio.ID_Vendedor = 10;
go

/* ===== UPDATES ===== */
-- Adicionar novo utilizador
create procedure create_user
	@fname as varchar(30),
	@lname as varchar(30),
	@tel as decimal(9),
	@email as varchar(40),
	@pw as varchar(20)
as
	declare @r varchar(100)
	insert into utilizador
	values (@fname, @lname, @tel, @email, @pw);
	if(@@ROWCOUNT = 1)
		set @r = '[REGISTER]: Success';
	else
		set @r = '[REGISTER]: ERROR';
	select @r;
go

-- Login com email e password
create procedure login_user
	@email as varchar(40),
	@password as varchar(20)
as
	select user1.ID_utilizador from utilizador as user1 
	join utilizador as user2 on user1.ID_utilizador=user2.ID_utilizador 
	where user2.email=@email and user2.pw=@password;
go

-- Receives user id and retrieves user info
create procedure get_user_info
	@id	as int
as
	select email, Fname, Lname from utilizador where ID_utilizador = @id;
go
