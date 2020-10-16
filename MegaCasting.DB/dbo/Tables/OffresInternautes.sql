CREATE TABLE [dbo].[OffresInternautes] (
    [id_internaute]    INT  IDENTITY (1, 1) NOT NULL,
    [id_offre]         INT  NOT NULL,
    [date_postulation] DATE NOT NULL,
    CONSTRAINT [PK_OffresInternautes] PRIMARY KEY CLUSTERED ([id_internaute] ASC, [id_offre] ASC),
    CONSTRAINT [FK_OffresInternautes_Internautes] FOREIGN KEY ([id_internaute]) REFERENCES [dbo].[Internautes] ([id]),
    CONSTRAINT [FK_OffresInternautes_Offres] FOREIGN KEY ([id_offre]) REFERENCES [dbo].[Offres] ([id])
);

