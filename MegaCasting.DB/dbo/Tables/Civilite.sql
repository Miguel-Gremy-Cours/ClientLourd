CREATE TABLE [dbo].[Civilite] (
    [id]      INT         IDENTITY (1, 1) NOT NULL,
    [libelle] VARCHAR (4) NOT NULL,
    CONSTRAINT [PK_Civilite] PRIMARY KEY CLUSTERED ([id] ASC)
);

