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