﻿CREATE TABLE [dbo].[TypeContrat] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Libelle] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TypeContrat] PRIMARY KEY CLUSTERED ([Id] ASC)
);

