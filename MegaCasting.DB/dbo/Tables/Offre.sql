CREATE TABLE [dbo].[Offre] (
    [Id]                 INT           IDENTITY (1, 1) NOT NULL,
    [IdStudio]           INT           NOT NULL,
    [Intitule]           VARCHAR (25)  NOT NULL,
    [IdMetier]           INT           NOT NULL,
    [DatePublication]    DATE          NOT NULL,
    [DureDiffusion]      INT           NOT NULL,
    [NombrePostes]       INT           NOT NULL,
    [DescriptionPoste]   VARCHAR (100) NOT NULL,
    [DescriptionProfile] VARCHAR (100) NOT NULL,
    [IdEmploye]          INT           NOT NULL,
    [Localisation]       VARCHAR (50)  NOT NULL,
    [CodeOffre]          NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Offres] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Offres_Employes] FOREIGN KEY ([IdEmploye]) REFERENCES [dbo].[Employe] ([Id]),
    CONSTRAINT [FK_Offres_Metier] FOREIGN KEY ([IdMetier]) REFERENCES [dbo].[Metier] ([Id]),
    CONSTRAINT [FK_Offres_Studios] FOREIGN KEY ([IdStudio]) REFERENCES [dbo].[Studio] ([Id])
);

