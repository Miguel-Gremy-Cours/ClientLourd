CREATE TABLE [dbo].[Employe] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Nom]              VARCHAR (50)  NOT NULL,
    [Prenom]           VARCHAR (50)  NOT NULL,
    [IdCivilite]       INT           NOT NULL,
    [IdGroupeEmployes] INT           NOT NULL,
    [Login]            VARCHAR (100) NOT NULL,
    [Password]         VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Employes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employes_Civilite] FOREIGN KEY ([IdCivilite]) REFERENCES [dbo].[Civilite] ([Id]),
    CONSTRAINT [FK_Employes_GroupeEmployes] FOREIGN KEY ([IdGroupeEmployes]) REFERENCES [dbo].[GroupeEmploye] ([Id])
);

