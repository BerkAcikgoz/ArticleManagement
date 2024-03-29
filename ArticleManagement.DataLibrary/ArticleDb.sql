USE [master]
GO
/****** Object:  Database [ArticleDb]    Script Date: 14.10.2019 23:23:40 ******/
CREATE DATABASE [ArticleDb] ON  PRIMARY 
( NAME = N'ArticleDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVERR\MSSQL\DATA\ArticleDb.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ArticleDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVERR\MSSQL\DATA\ArticleDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ArticleDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ArticleDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ArticleDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ArticleDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ArticleDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ArticleDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ArticleDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ArticleDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ArticleDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ArticleDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ArticleDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ArticleDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ArticleDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ArticleDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ArticleDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ArticleDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ArticleDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ArticleDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ArticleDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ArticleDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ArticleDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ArticleDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ArticleDb] SET RECOVERY FULL 
GO
ALTER DATABASE [ArticleDb] SET  MULTI_USER 
GO
ALTER DATABASE [ArticleDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ArticleDb] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ArticleDb', N'ON'
GO
USE [ArticleDb]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 14.10.2019 23:23:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Like] [int] NOT NULL CONSTRAINT [DF_Article_Like]  DEFAULT ((0)),
	[Title] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](300) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Author]    Script Date: 14.10.2019 23:23:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NULL,
	[Surname] [nvarchar](25) NULL,
	[Email] [nvarchar](50) NULL,
	[Gender] [nvarchar](5) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 14.10.2019 23:23:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comment]    Script Date: 14.10.2019 23:23:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArticleId] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Body] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Article] ON 

INSERT [dbo].[Article] ([Id], [AuthorId], [CategoryId], [Like], [Title], [Description], [Content], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (1, 1, 1, 1, N'TestRequestUpdate', N' - ', N' - ', CAST(N'2019-10-10 00:00:00.000' AS DateTime), CAST(N'2019-10-11 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Article] ([Id], [AuthorId], [CategoryId], [Like], [Title], [Description], [Content], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (2, 1, 1, 1, N'TestRequest', N' - ', N' - ', CAST(N'2019-10-10 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Article] ([Id], [AuthorId], [CategoryId], [Like], [Title], [Description], [Content], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (3, 1, 1, 1, N'TestRequest', N' - ', N' - ', CAST(N'2019-10-10 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Article] ([Id], [AuthorId], [CategoryId], [Like], [Title], [Description], [Content], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (4, 1, 1, 1, N'TestRequest', N' - ', N' - ', CAST(N'2019-10-10 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Article] ([Id], [AuthorId], [CategoryId], [Like], [Title], [Description], [Content], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (5, 1, 1, 1, N'TestRequest', N' - ', N' - ', CAST(N'2019-10-10 00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[Article] OFF
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([Id], [Name], [Surname], [Email], [Gender], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (1, N'Berk', N'Açıkgöz', N'berk.acikgoz1@gmail.com', N'Male', CAST(N'2019-10-10 00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Author] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (1, N'.Net', CAST(N'2019-10-10 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (2, N'Yazılım', CAST(N'2019-10-10 00:00:00.000' AS DateTime), CAST(N'2019-10-11 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_Article_Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([Id])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_Article_Author]
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_Article_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_Article_Category]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Article] FOREIGN KEY([ArticleId])
REFERENCES [dbo].[Article] ([Id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Article]
GO
USE [master]
GO
ALTER DATABASE [ArticleDb] SET  READ_WRITE 
GO
