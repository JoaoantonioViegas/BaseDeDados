go	
	create trigger add_client_seller ON anuncio
	after insert 
	as
	INSERT INTO vendedor(ID_Vendedor) VALUES (SELECT ID_Vendedor FROM inserted)
	end
go