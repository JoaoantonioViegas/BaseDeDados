use stand;

-- quando um utilizador cria um anuncio, automaticamente é inserido na tabela de vendedores(quando já está na tabela nao é adicionado)
create trigger add_client_seller ON anuncio
after insert 
as
	declare @added_seller as int;
	select @added_seller = ID_Vendedor from inserted;
	print(@added_seller);
	if not exists(select v1.ID_Vendedor from vendedor as v1 join vendedor as v2 on v1.ID_Vendedor = @added_seller)
	begin
		INSERT INTO vendedor(ID_Vendedor) VALUES (@added_seller);
	end
go

--quando eliminamos um anuncio -> eliminar da tabela:
-- item!!
-- favoritos se existir
--peça!!
--veiculo
--terrestre
--aquatic

create trigger after_delete_ad on anuncio
for delete
as 
	declare @delete as int;
	select @delete= ID_Anuncio from deleted
		if exists(select * from peca join item on peca.ID_Item = item.ID where item.ID_Anuncio=@delete)
		begin
			delete peca from peca join item on peca.ID_Item = item.ID where item.ID_Anuncio=@delete 
		end
		if exists(select * from item where ID_Anuncio=@delete)
		begin
			delete from item where ID_Anuncio = @delete
		end
		if exists(select * from veiculo join item on veiculo.ID_Item = item.ID where item.ID_Anuncio=@delete)
		begin
			declare @id_rem_item as int;
			select @id_rem_item = item.ID from veiculo join item on veiculo.ID_Item = item.ID where item.ID=@delete
			delete veiculo from veiculo join item on veiculo.ID_Item = item.ID where item.ID_Anuncio=@delete
			if exists(select * from veiculo_terrestre join veiculo on veiculo_terrestre.ID_Veiculo= veiculo.ID_Item where veiculo.ID_Item=@id_rem_item)
			begin
				delete veiculo_terrestre from veiculo_terrestre join veiculo on veiculo_terrestre.ID_Veiculo= veiculo.ID_Item where veiculo_terrestre.ID_Veiculo=@id_rem_item;
			end
			if exists(select * from veiculo_aquatico join veiculo on veiculo_aquatico.ID_Veiculo= veiculo.ID_Item where veiculo.ID_Item=@id_rem_item)
			begin
				delete veiculo_aquatico from veiculo_aquatico join veiculo on veiculo_aquatico.ID_Veiculo= veiculo.ID_Item where veiculo_aquatico.ID_Veiculo=@id_rem_item;
			end
		end
		if exists(select * from favourites where ID_Anuncio=@delete)
		begin
			delete from favourites where ID_Anuncio=@delete;
		end
go

select * from item
select * from anuncio
select * from peca
select * from favourites
select * from veiculo
select * from veiculo_aquatico
select * from veiculo_terrestre

drop trigger after_delete_ad;