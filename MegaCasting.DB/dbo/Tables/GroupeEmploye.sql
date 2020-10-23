CREATE TABLE [dbo].[GroupeEmploye] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Libelle] VARCHAR (10) NOT NULL,
    CONSTRAINT [PK_GroupeEmployes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

