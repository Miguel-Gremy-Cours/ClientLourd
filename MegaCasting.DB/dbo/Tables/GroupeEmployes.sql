CREATE TABLE [dbo].[GroupeEmployes] (
    [id]      INT          IDENTITY (1, 1) NOT NULL,
    [libelle] VARCHAR (10) NOT NULL,
    CONSTRAINT [PK_GroupeEmployes] PRIMARY KEY CLUSTERED ([id] ASC)
);

