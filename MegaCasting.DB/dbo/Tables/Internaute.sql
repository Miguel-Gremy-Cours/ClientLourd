CREATE TABLE [dbo].[Internaute] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Nom]             VARCHAR (50)  NOT NULL,
    [Prenom]          VARCHAR (50)  NOT NULL,
    [DateNaissance]   DATE          NOT NULL,
    [DateInscription] DATE          CONSTRAINT [DF_Internautes_date_inscription] DEFAULT (getdate()) NOT NULL,
    [IdCivilite]      INT           NOT NULL,
    [LienGoogle]      VARCHAR (200) NULL,
    [Login]           VARCHAR (100) NOT NULL,
    [Password]        VARCHAR (64)  NOT NULL,
    [Cv]              VARCHAR (MAX) NULL,
    [Email]           VARCHAR (254) NOT NULL,
    CONSTRAINT [PK_Internautes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Internautes_Civilite] FOREIGN KEY ([IdCivilite]) REFERENCES [dbo].[Civilite] ([Id])
);

