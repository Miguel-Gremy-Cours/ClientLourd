CREATE TABLE [dbo].[Metier] (
    [Id]              INT          IDENTITY (1, 1) NOT NULL,
    [IdLibelle]       VARCHAR (50) NOT NULL,
    [IdDomaineMetier] INT          NOT NULL,
    CONSTRAINT [PK_Metier] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Metier_DomaineMetier] FOREIGN KEY ([IdDomaineMetier]) REFERENCES [dbo].[DomaineMetier] ([Id])
);

