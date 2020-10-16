CREATE TABLE [dbo].[DomaineMetier] (
    [id]      INT          IDENTITY (1, 1) NOT NULL,
    [libelle] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DomaineMetier] PRIMARY KEY CLUSTERED ([id] ASC)
);

