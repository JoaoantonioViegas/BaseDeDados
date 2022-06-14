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

/* ===== UPDATES ===== */
