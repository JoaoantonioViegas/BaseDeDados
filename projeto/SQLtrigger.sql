-- use stand;

-- quando um utilizador cria um anuncio, automaticamente � inserido na tabela de vendedores(quando j� est� na tabela nao � adicionado)
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

-- quando um anuncio � eliminado e o utilizador nao tem mais anuncios, entao � retirado da tabela de vendedores
create trigger remove_seller on anuncio
after delete
as
	declare @removed_seller as int;
	select @removed_seller=ID_Vendedor from deleted;

	if not exists( select * from anuncio where ID_Vendedor = @removed_seller )
	begin
		delete from vendedor where ID_Vendedor = @removed_seller;
	end
go
