CREATE PROCEDURE [dbo].[KontrolujExistuje]
	@userMeno varchar(20)

	AS
	
	SELECT * FROM [Table] WHERE ([Meno] = @userMeno)