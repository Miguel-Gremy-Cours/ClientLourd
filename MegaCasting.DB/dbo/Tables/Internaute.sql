CREATE TABLE [dbo].[Internaute] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Nom]             VARCHAR (50)  NOT NULL,
    [Prenom]          VARCHAR (50)  NOT NULL,
    [DateNaissance]   DATE          NOT NULL,
    [DateInscription] DATE          CONSTRAINT [DF_Internautes_date_inscription] DEFAULT (getdate()) NOT NULL,
    [IdCivilite]      INT           NOT NULL,
    [LienGoogle]      VARCHAR (200) NULL,
    [Login]           VARCHAR (100) NOT NULL,
    [Password]        VARCHAR (64)  NOT NULL,
    [Cv]              VARCHAR (MAX) NULL,
    [Email]           VARCHAR (254) NOT NULL,
    CONSTRAINT [PK_Internautes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Internautes_Civilite] FOREIGN KEY ([IdCivilite]) REFERENCES [dbo].[Civilite] ([Id])
);




GO

CREATE   TRIGGER [dbo].[TR_nom_upcase] ON [dbo].[Internaute]
AFTER INSERT, UPDATE
AS
BEGIN
IF (SELECT TRIGGER_NESTLEVEL()) < 2
	BEGIN
		UPDATE Internaute
			SET nom = UPPER(Internaute.nom)
		FROM Internaute
		INNER JOIN inserted ON inserted.id = Internaute.id
	END
END
GO

CREATE   TRIGGER [dbo].[TR_date_inscription_update] ON [dbo].[Internaute]
AFTER UPDATE
AS 
BEGIN
IF (SELECT TRIGGER_NESTLEVEL()) < 2
	BEGIN
		UPDATE Internaute
			SET DateInscription = deleted.DateInscription
		FROM Internaute
		INNER JOIN deleted ON deleted.id = Internaute.id
	END
END
GO

CREATE   TRIGGER [dbo].[TR_date_inscription_insert] ON [dbo].[Internaute]
AFTER INSERT
AS 
BEGIN
	UPDATE Internaute
		SET DateInscription = GETDATE()
	FROM Internaute
	INNER JOIN inserted ON inserted.id = Internaute.id
END