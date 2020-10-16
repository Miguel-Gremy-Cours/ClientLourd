CREATE TABLE [dbo].[Offres] (
    [id]                  INT           IDENTITY (1, 1) NOT NULL,
    [studio]              INT           NOT NULL,
    [intitule]            VARCHAR (25)  NOT NULL,
    [metier]              INT           NOT NULL,
    [contrat]             INT           NOT NULL,
    [date_publication]    DATE          NOT NULL,
    [dure_diffusion]      INT           NOT NULL,
    [nombre_postes]       INT           NOT NULL,
    [description_poste]   VARCHAR (100) NOT NULL,
    [description_profile] VARCHAR (100) NOT NULL,
    [numero_employe]      INT           NOT NULL,
    [localisation]        VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Offres] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Offres_Contrat] FOREIGN KEY ([contrat]) REFERENCES [dbo].[Contrat] ([id]),
    CONSTRAINT [FK_Offres_Employes] FOREIGN KEY ([numero_employe]) REFERENCES [dbo].[Employes] ([id]),
    CONSTRAINT [FK_Offres_Metier] FOREIGN KEY ([metier]) REFERENCES [dbo].[Metier] ([id]),
    CONSTRAINT [FK_Offres_Studios] FOREIGN KEY ([studio]) REFERENCES [dbo].[Studios] ([id])
);

