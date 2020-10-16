CREATE TABLE [dbo].[Employes] (
    [id]              INT           IDENTITY (1, 1) NOT NULL,
    [nom]             VARCHAR (50)  NOT NULL,
    [prenom]          VARCHAR (50)  NOT NULL,
    [civilite]        INT           NOT NULL,
    [groupe_employes] INT           NOT NULL,
    [login]           VARCHAR (100) NOT NULL,
    [password]        VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Employes] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Employes_Civilite] FOREIGN KEY ([civilite]) REFERENCES [dbo].[Civilite] ([id]),
    CONSTRAINT [FK_Employes_GroupeEmployes] FOREIGN KEY ([groupe_employes]) REFERENCES [dbo].[GroupeEmployes] ([id])
);

