CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nom] NCHAR(30) NULL, 
    [Prenom] NCHAR(30) NULL, 
    [Mail] NCHAR(40) NULL, 
    [Password] NCHAR(20) NULL
)