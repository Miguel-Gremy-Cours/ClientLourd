CREATE TABLE [dbo].[Contrat] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [IdTypeContrat]  INT            NOT NULL,
    [DebutContrat]   DATE           NOT NULL,
    [DureContrat]    INT            NOT NULL,
    [CodeContrat]    NVARCHAR (50)  NOT NULL,
    [FichierContrat] NVARCHAR (MAX) NOT NULL,
    [IdOffre]        INT            NOT NULL,
    CONSTRAINT [PK_Contrat] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Contrat_Offres] FOREIGN KEY ([IdOffre]) REFERENCES [dbo].[Offre] ([Id]),
    CONSTRAINT [FK_Contrat_TypeContrat] FOREIGN KEY ([IdTypeContrat]) REFERENCES [dbo].[TypeContrat] ([Id])
);

