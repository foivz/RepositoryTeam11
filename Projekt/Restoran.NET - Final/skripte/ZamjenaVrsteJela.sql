CREATE procedure ZamjenaVrsteJela
(
@id_stavke int
)

AS

BEGIN

 UPDATE [Stavka racuna]
    SET
    Pripremljen= 0
	WHERE [Sifra stavke]= @id_stavke
	
END