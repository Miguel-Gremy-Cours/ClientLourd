CREATE TABLE [dbo].[Partenaires] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [siret]          VARCHAR (100) NOT NULL,
    [adresse]        VARCHAR (25)  NOT NULL,
    [numero_adresse] INT           NOT NULL,
    [libelle]        VARCHAR (25)  NOT NULL,
    [email]          VARCHAR (25)  NOT NULL,
    [telephone]      VARCHAR (20)  NOT NULL,
    [login]          VARCHAR (100) NOT NULL,
    [password]       VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Partenaires] PRIMARY KEY CLUSTERED ([id] ASC)
);

