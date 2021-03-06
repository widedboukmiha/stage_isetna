USE [master]
GO
/****** Object:  Database [stage_isetna]    Script Date: 13/11/2016 12:54:09 ******/
CREATE DATABASE [stage_isetna] ON  PRIMARY 
( NAME = N'stage_isetna', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\stage_isetna.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'stage_isetna_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\stage_isetna_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [stage_isetna] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [stage_isetna].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [stage_isetna] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [stage_isetna] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [stage_isetna] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [stage_isetna] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [stage_isetna] SET ARITHABORT OFF 
GO
ALTER DATABASE [stage_isetna] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [stage_isetna] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [stage_isetna] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [stage_isetna] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [stage_isetna] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [stage_isetna] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [stage_isetna] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [stage_isetna] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [stage_isetna] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [stage_isetna] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [stage_isetna] SET  ENABLE_BROKER 
GO
ALTER DATABASE [stage_isetna] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [stage_isetna] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [stage_isetna] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [stage_isetna] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [stage_isetna] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [stage_isetna] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [stage_isetna] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [stage_isetna] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [stage_isetna] SET  MULTI_USER 
GO
ALTER DATABASE [stage_isetna] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [stage_isetna] SET DB_CHAINING OFF 
GO
USE [stage_isetna]
GO
/****** Object:  Table [dbo].[Entreprise]    Script Date: 13/11/2016 12:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entreprise](
	[id] [int] NOT NULL,
	[NomEntreprise] [varchar](50) NULL,
	[ville] [varchar](50) NULL,
	[tel] [varchar](15) NULL,
	[email] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Etudiant]    Script Date: 13/11/2016 12:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Etudiant](
	[cin] [varchar](15) NOT NULL,
	[nom] [varchar](20) NULL,
	[prenom] [varchar](20) NULL,
	[date_naissiance] [varchar](30) NULL,
	[adresse] [varchar](80) NULL,
	[code_postal] [int] NULL,
	[tel] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[idNiveau] [int] NULL,
	[idFiliere] [int] NULL,
	[idGroupe] [int] NULL,
	[idEntreprise] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Filiere]    Script Date: 13/11/2016 12:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Filiere](
	[id] [int] NOT NULL,
	[nomFiliere] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Groupe]    Script Date: 13/11/2016 12:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Groupe](
	[id] [int] NOT NULL,
	[nomGroupe] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Niveau]    Script Date: 13/11/2016 12:54:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Niveau](
	[id] [int] NOT NULL,
	[libelle] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Etudiant]  WITH CHECK ADD FOREIGN KEY([idEntreprise])
REFERENCES [dbo].[Entreprise] ([id])
GO
ALTER TABLE [dbo].[Etudiant]  WITH CHECK ADD FOREIGN KEY([idFiliere])
REFERENCES [dbo].[Filiere] ([id])
GO
ALTER TABLE [dbo].[Etudiant]  WITH CHECK ADD FOREIGN KEY([idGroupe])
REFERENCES [dbo].[Groupe] ([id])
GO
ALTER TABLE [dbo].[Etudiant]  WITH CHECK ADD FOREIGN KEY([idNiveau])
REFERENCES [dbo].[Niveau] ([id])
GO
USE [master]
GO
ALTER DATABASE [stage_isetna] SET  READ_WRITE 
GO
