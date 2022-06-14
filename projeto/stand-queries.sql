use stand;
-- Procurar por t�tulo do an�ncio
declare @input_value as varchar(50); 
set @input_value = '10';
select * from anuncio where lower(Titulo) like '%' + @input_value + '%';

-- Receber favoritos de um cliente
declare @input_clientID as varchar(50);
set @input_clientID = '123412343';
select * from favourites where ID_Client = @input_clientID;

-- Receber clientes que t�m o an�ncio como favorito
declare @input_anuncio as varchar(50);
set @input_anuncio = '2';
select ID_Cliente from (cliente join favourites
on ID_Client=ID_Cliente)
where ID_Anuncio = @input_anuncio;

-- Filtrar pe�as por categoria
declare @input_category as varchar(50);
set @input_category = 'Interiores';
select * from (peca join categoria
on ID_Item = ID_Peca)
where categoria.Nome = @input_category;

-- Filtrar pe�as por condi��o
declare @input_condition as varchar(50);
set @input_condition = 'Usado';
select * from peca where Condicao = @input_condition;

-- Filtrar ve�culo por combust�vel
declare @input_fuel as varchar(50);
set @input_fuel = 'Eletrico';
select * from veiculo where Combustivel = @input_fuel;

-- Filtrar por ve�culos que tenham menos de X km
declare @input_km as int;
set @input_km = 100000;
select ID_Item, Matricula, Modelo, Marca, quilometros from (veiculo_terrestre join veiculo on ID_Veiculo=ID_Item)
where quilometros <= @input_km;

/* ===== Procedures ===== */
-- Procurar por t�tulo do an�ncio
create procedure search_anuncio
	@title as varchar(40)
as
	select * from anuncio
	where lower(Titulo) like '%' + lower(@title) + '%';
go

-- Filtrar an�ncios por tipo de combust�vel do ve�culo
create procedure filter_by_fuel
	@fuel as varchar(20)
as
	select * from anuncio join (item join veiculo on item.ID = veiculo.ID_Item) on anuncio.ID_Anuncio = item.ID_Anuncio where lower(Combustivel) = lower(@fuel);
go

-- Filtrar anuncios por tipo de combustivel do veiculo e titulo
create procedure search_and_fuel
	@title as varchar(40),
	@fuel as varchar(20)
as
	select * from anuncio join 
		(item join veiculo on item.ID = veiculo.ID_Item)
	on anuncio.ID_Anuncio = item.ID_Anuncio
	where (lower(Combustivel) = lower(@fuel))
	and (lower(Titulo) like '%' + lower(@title) + '%');
go

-- Filtrar an�ncios por kms
create procedure search_km_fuel
	@kms as int,
	@title as varchar(40),
	@fuel as varchar(20)
as
	if(@fuel != '' and @kms != '')
	begin
		select * from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where (quilometros < @kms) and (lower(Titulo) like '%' + lower(@title) + '%') and (lower(Combustivel) = lower(@fuel));
	end
	else if (@fuel != '' and @kms = '')
	begin
		select * from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where (lower(Titulo) like '%' + lower(@title) + '%') and (lower(Combustivel) = lower(@fuel));
	end
		else if (@fuel = '' and @kms != '')
	begin
		select * from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where (lower(Titulo) like '%' + lower(@title) + '%') and (quilometros < @kms) ;
	end
go

drop procedure search_km_fuel;
select * from anuncio;
select * from item;
select * from veiculo;
select * from veiculo_terrestre;

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

select * from utilizador;
drop procedure create_user;
-- Remover utilizador
delete from utilizador
where ID_utilizador=27;