CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Cin] NCHAR(8) NULL, 
    [Nom] NCHAR(20) NULL, 
    [Prenom] NCHAR(20) NULL, 
    [Mail] NCHAR(30) NULL, 
    [Login] NCHAR(20) NULL, 
    [Password] NCHAR(20) NULL
)