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
-- Filtrar an�ncios por kms, combustivel, titulo e marca
create procedure search_km_fuel
	@title as nvarchar(40),
	@fuel as nvarchar(20),
	@kms as int
as
	declare @sql varchar(max);
	set @sql = '
		select Titulo, preco, Marca, Modelo, Ano, Combustivel, quilometros, Matricula from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where ((lower(Titulo) like ''%'' + lower('''+@title+''') + ''%'') or (lower(Marca) like ''%'' + lower('''+@title+''') + ''%''))'

	if @fuel != ''
	begin
		set @sql = @sql + ' and (lower(Combustivel) = lower('''+@fuel+'''))'
	end
	if @kms is not null
	begin
		set @sql = @sql + ' and (quilometros < '+CONVERT(NVARCHAR(MAX), @kms)+')';
	end
	exec(@sql)
go

select Titulo, preco, Marca, Modelo, Ano, Combustivel, quilometros, Matricula from anuncio join 
			(item join 
				(veiculo join veiculo_terrestre on ID_Veiculo=ID_Item)
			on item.ID = veiculo.ID_Item)
		on anuncio.ID_Anuncio = item.ID_Anuncio
		where ((lower(Titulo) like '%' + lower('') + '%') or (lower(Marca) like '%' + lower('') + '%')) and (quilometros <100000);

drop procedure search_km_fuel;

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

-- Login com email e password
create procedure login_user
	@email as varchar(40),
	@password as varchar(20)
as
	select user1.ID_utilizador from utilizador as user1 
	join utilizador as user2 on user1.ID_utilizador=user2.ID_utilizador 
	where user2.email=@email and user2.pw=@password;
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

-- Receives user id and retrieves user info
create procedure get_user_info
	@id	as int
as
	select email, Fname, Lname from utilizador where ID_utilizador = @id;
go

-- criar anuncio de uma pe�a
create procedure create_anuncio_peca
	@seller_id as int,
	@title as varchar(100),
	@price as real,
	@piece_name as varchar(30),
	@piece_condition as varchar(10)
as
	insert into anuncio values(@seller_id, @title, @price);
	
	declare @last_index_anuncio as int;
	select @last_index_anuncio = @@IDENTITY from anuncio;
	insert into item values (@last_index_anuncio);
	declare @last_index_item as int;
	select @last_index_item = MAX(ID) from item;
	insert into peca values (@last_index_item, @piece_name, @piece_condition);
go

-- criar anuncio de um veiculo terrestre
create procedure create_anuncio_terrestre
	@seller_id as int,

as
go

select * from anuncio;
select * from item;
select * from veiculo;
select * from veiculo_terrestre;

-- update password do utilizador quando recebe email e password antiga
create procedure update_user_password
	@old_email as varchar(40),
	@old_password as varchar(40),
	@new_email as varchar(40),
	@new_password as varchar(40),

	@response as varchar(50) output
as
	begin try
		if exists(select * from utilizador where email=@old_email and pw=@old_password)
		begin
			update utilizador
			set [email]=coalesce(@new_email, [email]),
			[pw]=coalesce(@new_password, [pw])
			where email=@old_email and pw=@old_password
			set @response = 'Success'
		end
		else
			set @response = 'Invalid'
	end try
	begin catch
		set @response = ERROR_MESSAGE()
	end catch 
go

-- update do titulo e do preco quando recebe id do anuncio
create procedure update_anuncio_peca
	@id	as int,
	@new_title as varchar(100),
	@new_price as real,

	@response as varchar(50) output
as
	begin try
		if exists( select * from anuncio where ID_Anuncio = @id)
		begin
			update anuncio
			set [Titulo]=coalesce(@new_title, Titulo),
			[Preco]=coalesce(@new_price, Preco)
			where ID_Anuncio = @id;
			set @response = 'Success'
		end
		else
			set @response = 'Invalid'
	end try
	begin catch
		set @response = ERROR_MESSAGE()
	end catch
go
