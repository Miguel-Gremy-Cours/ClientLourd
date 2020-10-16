CREATE TABLE [dbo].[Contrat] (
    [id]            INT  IDENTITY (1, 1) NOT NULL,
    [type_contrat]  INT  NOT NULL,
    [debut_contrat] DATE NOT NULL,
    [dure_contrat]  INT  NOT NULL,
    CONSTRAINT [PK_Contrat] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Contrat_TypeContrat] FOREIGN KEY ([type_contrat]) REFERENCES [dbo].[TypeContrat] ([id])
);

