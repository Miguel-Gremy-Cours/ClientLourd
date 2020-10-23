CREATE TABLE [dbo].[Civilite] (
    [Id]      INT         IDENTITY (1, 1) NOT NULL,
    [Libelle] VARCHAR (4) NOT NULL,
    CONSTRAINT [PK_Civilite] PRIMARY KEY CLUSTERED ([Id] ASC)
);

