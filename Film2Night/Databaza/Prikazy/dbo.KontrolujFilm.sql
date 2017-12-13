CREATE PROCEDURE [dbo].[KontrolujFilm]
	@meno varchar(20)

	AS
	
	SELECT * FROM [Filmy] WHERE ([Meno] = @meno)
