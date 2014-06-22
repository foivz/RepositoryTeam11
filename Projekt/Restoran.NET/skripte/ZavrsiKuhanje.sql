create procedure ZavrsenoKuhanje
(
 @artikl varchar(50),
 @vrijeme_kuhanja int
)

AS

BEGIN

 UPDATE Artikl
    SET
    [Vrijeme pripreme] = @vrijeme_kuhanja
	WHERE Naziv = @artikl
	
END