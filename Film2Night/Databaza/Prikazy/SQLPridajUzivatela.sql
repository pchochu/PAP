Create PROC pridajUzivatela
	@Id	int,	
	@meno	varchar(20),		
	@heslo	varchar(20),	
	@menoPriezvisko varchar(50)	
	
	AS
		
		INSERT INTO [Table](meno,heslo,menoPriezvisko)	
		VALUES(@meno,@heslo,@menoPriezvisko)
