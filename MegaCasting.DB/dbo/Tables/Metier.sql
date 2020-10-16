CREATE TABLE [dbo].[Metier] (
    [id]             INT          IDENTITY (1, 1) NOT NULL,
    [libelle]        VARCHAR (50) NOT NULL,
    [domaine_metier] INT          NOT NULL,
    CONSTRAINT [PK_Metier] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Metier_DomaineMetier] FOREIGN KEY ([domaine_metier]) REFERENCES [dbo].[DomaineMetier] ([id])
);

