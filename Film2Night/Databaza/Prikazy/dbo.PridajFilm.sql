CREATE PROCEDURE [dbo].[PridajFilm]
	@meno	varchar(20),		
	@popis	text,	
	@obrazok image
	
	AS
		
		INSERT INTO [Filmy](Meno,Popis,Obrazok)	
		VALUES(@meno,@popis,@obrazok)
