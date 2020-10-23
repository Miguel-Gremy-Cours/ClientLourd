CREATE TABLE [dbo].[Partenaire] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Siret]         VARCHAR (100) NOT NULL,
    [Adresse]       VARCHAR (25)  NOT NULL,
    [NumeroAdresse] INT           NOT NULL,
    [Libelle]       VARCHAR (25)  NOT NULL,
    [Email]         VARCHAR (25)  NOT NULL,
    [Telephone]     VARCHAR (20)  NOT NULL,
    [Login]         VARCHAR (100) NOT NULL,
    [Password]      VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Partenaires] PRIMARY KEY CLUSTERED ([Id] ASC)
);

