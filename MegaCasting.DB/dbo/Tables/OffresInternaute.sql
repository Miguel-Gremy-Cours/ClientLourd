CREATE TABLE [dbo].[OffresInternaute] (
    [IdInternaute]    INT  IDENTITY (1, 1) NOT NULL,
    [IdOffre]         INT  NOT NULL,
    [DatePostulation] DATE NOT NULL,
    CONSTRAINT [PK_OffresInternautes] PRIMARY KEY CLUSTERED ([IdInternaute] ASC, [IdOffre] ASC),
    CONSTRAINT [FK_OffresInternautes_Internautes] FOREIGN KEY ([IdInternaute]) REFERENCES [dbo].[Internaute] ([Id]),
    CONSTRAINT [FK_OffresInternautes_Offres] FOREIGN KEY ([IdOffre]) REFERENCES [dbo].[Offre] ([Id])
);

