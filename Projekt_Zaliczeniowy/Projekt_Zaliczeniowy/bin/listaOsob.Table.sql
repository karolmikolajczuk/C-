CREATE TABLE [listaOsob].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Imie] NCHAR(20) NOT NULL,
	[Nazwisko] NCHAR(30) NOT NULL,
	[Kolo1] INT,
	[Kolo2] INT,
	[Kolo3] INT,
	[Przedmiot] NCHAR(60) NOT NULL,
	[Ocena] INT NOT NULL,
	[Frekwencja] BIT,
	[Olimpiada] BIT
)
