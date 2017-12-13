CREATE TABLE [dbo].[Filmy] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Meno]    VARCHAR (20)  NULL,
    [Popis]   VARCHAR (MAX) NULL,
    [Obrazok] IMAGE         NOT NULL
);

