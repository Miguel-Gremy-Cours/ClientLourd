CREATE TABLE [dbo].[DomaineMetier] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Libelle] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DomaineMetier] PRIMARY KEY CLUSTERED ([Id] ASC)
);

