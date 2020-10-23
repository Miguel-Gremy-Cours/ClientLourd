CREATE TABLE [dbo].[Studio] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Siret]         VARCHAR (100) NOT NULL,
    [Adresse]       VARCHAR (25)  NOT NULL,
    [NumeroAdresse] INT           NOT NULL,
    [Libelle]       VARCHAR (25)  NOT NULL,
    [Email]         VARCHAR (254) NOT NULL,
    [Telephone]     VARCHAR (20)  NOT NULL,
    CONSTRAINT [PK_Studios] PRIMARY KEY CLUSTERED ([Id] ASC)
);

