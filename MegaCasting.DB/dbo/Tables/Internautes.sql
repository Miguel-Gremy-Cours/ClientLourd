CREATE TABLE [dbo].[Internautes] (
    [id]               INT           IDENTITY (1, 1) NOT NULL,
    [nom]              VARCHAR (50)  NOT NULL,
    [prenom]           VARCHAR (50)  NOT NULL,
    [date_naissance]   DATE          NOT NULL,
    [date_inscription] DATE          CONSTRAINT [DF_Internautes_date_inscription] DEFAULT (getdate()) NOT NULL,
    [civilite]         INT           NOT NULL,
    [lien_google]      VARCHAR (200) NULL,
    [login]            VARCHAR (100) NOT NULL,
    [password]         VARCHAR (64)  NOT NULL,
    [cv_name]          VARCHAR (150) NULL,
    [email]            VARCHAR (254) NOT NULL,
    CONSTRAINT [PK_Internautes] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Internautes_Civilite] FOREIGN KEY ([civilite]) REFERENCES [dbo].[Civilite] ([id])
);


GO
CREATE   TRIGGER TR_date_inscription_insert ON dbo.Internautes
AFTER INSERT
AS 
BEGIN
	UPDATE Internautes
		SET date_inscription = GETDATE()
	FROM Internautes
	INNER JOIN inserted ON inserted.id = Internautes.id
END
GO
CREATE   TRIGGER TR_date_inscription_update ON dbo.Internautes
AFTER UPDATE
AS 
BEGIN
IF (SELECT TRIGGER_NESTLEVEL()) < 2
	BEGIN
		UPDATE Internautes
			SET date_inscription = deleted.date_inscription
		FROM Internautes
		INNER JOIN deleted ON deleted.id = Internautes.id
	END
END
GO
CREATE   TRIGGER TR_nom_upcase ON dbo.Internautes
AFTER INSERT, UPDATE
AS
BEGIN
IF (SELECT TRIGGER_NESTLEVEL()) < 2
	BEGIN
		UPDATE Internautes
			SET nom = UPPER(Internautes.nom)
		FROM Internautes
		INNER JOIN inserted ON inserted.id = Internautes.id
	END
END