USE [D:\SKYDRIVE\DOCUMENTS\PROGRAMSKO INŽENJERSTVO\PROJEKT\RESTORAN.NET - COPY\RESTORAN.NET\BAZA\RESTORANDB.MDF]
GO
/****** Object:  StoredProcedure [dbo].[ZavrsenoKuhanje]    Script Date: 1.7.2014. 20:30:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[ZavrsenoKuhanje]
(
 @id_stavke int,
 @artikl varchar(50),
 @vrijeme_kuhanja int
)

AS

BEGIN

 UPDATE Artikl
    SET
    [Vrijeme pripreme] = ((([Vrijeme pripreme]+(@vrijeme_kuhanja))/2))/(SELECT Kolicina FROM [Stavka racuna] WHERE [Sifra stavke]=@id_stavke)
	WHERE Naziv = @artikl
	
END