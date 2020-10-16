CREATE TABLE [dbo].[Studios] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [siret]          VARCHAR (100) NOT NULL,
    [adresse]        VARCHAR (25)  NOT NULL,
    [numero_adresse] INT           NOT NULL,
    [libelle]        VARCHAR (25)  NOT NULL,
    [email]          VARCHAR (254) NOT NULL,
    [telephone]      VARCHAR (20)  NOT NULL,
    CONSTRAINT [PK_Studios] PRIMARY KEY CLUSTERED ([id] ASC)
);

