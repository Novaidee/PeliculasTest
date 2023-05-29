/*
 Navicat Premium Data Transfer

 Source Server         : LOCAL_SQLSERVER
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : localhost:1433
 Source Catalog        : Peliculas
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 28/05/2023 23:41:59
*/


-- ----------------------------
-- Table structure for Peliculas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Peliculas]') AND type IN ('U'))
	DROP TABLE [dbo].[Peliculas]
GO

CREATE TABLE [dbo].[Peliculas] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Titulo] nvarchar(max) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Director] nvarchar(max) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Productora] nvarchar(max) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [FechaEstreno] datetime  NOT NULL,
  [Actores] nvarchar(max) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [FotoCartel] nvarchar(max) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Peliculas] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Peliculas
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Peliculas] ON
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'1', N'Star Wars', N'George Lucas', N'Lucasfilm', N'2023-05-29 03:32:29.177', N'[{"Id":"0d8f09fb-46bd-47d3-a19e-e977d63197a9","Nombre":"Mark Hamill","Genero":"Masculino","FechaNacimiento":"1951-09-25","PaisNacimiento":"Estados Unidos"},{"Id":"ff39b512-bf41-49c5-8f5f-f2bf3df95424","Nombre":"Harrison Ford","Genero":"Masculino","FechaNacimiento":"1942-07-13","PaisNacimiento":"Estados Unidos"},{"Id":"92c0dac8-cf5d-45e8-a981-39a97e2691c0","Nombre":"Carrie Fisher","Genero":"Femenino","FechaNacimiento":"1956-10-21","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/star-wars-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'2', N'Avengers: Endgame', N'Anthony Russo, Joe Russo', N'Marvel Studios', N'2019-04-26 00:00:00.000', N'[{"Id":"a4bca6b9-274f-4f61-a417-2c1d5a583f13","Nombre":"Robert Downey Jr.","Genero":"Masculino","FechaNacimiento":"1965-04-04","PaisNacimiento":"Estados Unidos"},
   {"Id":"3c99e8e2-13e4-42d9-b6c7-b0e1f790bfdf","Nombre":"Chris Evans","Genero":"Masculino","FechaNacimiento":"1981-06-13","PaisNacimiento":"Estados Unidos"},
   {"Id":"8f6748ae-cdef-4aa5-9dc4-5913b4474e45","Nombre":"Scarlett Johansson","Genero":"Femenino","FechaNacimiento":"1984-11-22","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/avengers-endgame-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'3', N'Jurassic Park', N'Steven Spielberg', N'Universal Pictures', N'1993-06-11 00:00:00.000', N'[{"Nombre":"Sam Neill","Genero":"Masculino","FechaNacimiento":"1947-09-14","PaisNacimiento":"Nueva Zelanda"},
   {"Nombre":"Laura Dern","Genero":"Femenino","FechaNacimiento":"1967-02-10","PaisNacimiento":"Estados Unidos"},
   {"Nombre":"Jeff Goldblum","Genero":"Masculino","FechaNacimiento":"1952-10-22","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/jurassic-park-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'4', N'Pulp Fiction', N'Quentin Tarantino', N'Miramax Films', N'1994-10-14 00:00:00.000', N'[{"Nombre":"John Travolta","Genero":"Masculino","FechaNacimiento":"1954-02-18","PaisNacimiento":"Estados Unidos"},
       {"Nombre":"Samuel L. Jackson","Genero":"Masculino","FechaNacimiento":"1948-12-21","PaisNacimiento":"Estados Unidos"},
       {"Nombre":"Uma Thurman","Genero":"Femenino","FechaNacimiento":"1970-04-29","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/pulp-fiction-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'5', N'The Shawshank Redemption', N'Frank Darabont', N'Castle Rock Entertainment', N'1994-09-23 00:00:00.000', N'[{"Nombre":"Tim Robbins","Genero":"Masculino","FechaNacimiento":"1958-10-16","PaisNacimiento":"Estados Unidos"},
       {"Nombre":"Morgan Freeman","Genero":"Masculino","FechaNacimiento":"1937-06-01","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/shawshank-redemption-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'6', N'Inception', N'Christopher Nolan', N'Warner Bros.', N'2010-07-16 00:00:00.000', N'[{"Nombre":"Leonardo DiCaprio","Genero":"Masculino","FechaNacimiento":"1974-11-11","PaisNacimiento":"Estados Unidos"},
       {"Nombre":"Joseph Gordon-Levitt","Genero":"Masculino","FechaNacimiento":"1981-02-17","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/inception-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'7', N'The Godfather', N'Francis Ford Coppola', N'Paramount Pictures', N'1972-03-24 00:00:00.000', N'[{"Nombre":"Marlon Brando","Genero":"Masculino","FechaNacimiento":"1924-04-03","PaisNacimiento":"Estados Unidos"},
       {"Nombre":"Al Pacino","Genero":"Masculino","FechaNacimiento":"1940-04-25","PaisNacimiento":"Estados Unidos"},
       {"Nombre":"James Caan","Genero":"Masculino","FechaNacimiento":"1940-03-26","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/godfather-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'8', N'Forrest Gump', N'Robert Zemeckis', N'Paramount Pictures', N'1994-07-06 00:00:00.000', N'[{"Nombre":"Tom Hanks","Genero":"Masculino","FechaNacimiento":"1956-07-09","PaisNacimiento":"Estados Unidos"},
       {"Nombre":"Robin Wright","Genero":"Femenino","FechaNacimiento":"1966-04-08","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/forrest-gump-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'9', N'The Matrix', N'Lana Wachowski', N'Warner Bros.', N'1999-03-31 00:00:00.000', N'[{"Nombre":"Keanu Reeves","Genero":"Masculino","FechaNacimiento":"1964-09-02","PaisNacimiento":"Canadá"},
       {"Nombre":"Carrie-Anne Moss","Genero":"Femenino","FechaNacimiento":"1967-08-21","PaisNacimiento":"Canadá"}]', N'https://example.com/the-matrix-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'10', N'Spirited Away', N'Hayao Miyazaki', N'Studio Ghibli', N'2001-07-20 00:00:00.000', N'[{"Nombre":"Rumi Hiiragi","Genero":"Femenino","FechaNacimiento":"1967-08-01","PaisNacimiento":"Japón"},
       {"Nombre":"Miyu Irino","Genero":"Masculino","FechaNacimiento":"1988-02-19","PaisNacimiento":"Japón"}]', N'https://example.com/spirited-away-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'11', N'Akira', N'Katsuhiro Otomo', N'Tokyo Movie Shinsha', N'1988-07-16 00:00:00.000', N'[{"Id":null,"Nombre":"Mitsuo Iwata","Genero":"Masculino","FechaNacimiento":"1967-07-31","PaisNacimiento":"Japón"},{"Id":null,"Nombre":"Nozomu Sasaki","Genero":"Masculino","FechaNacimiento":"1967-01-25","PaisNacimiento":"Japón"},{"Id":"90611559-3ec7-4ecf-a82e-8f039dce2a11","Nombre":"Alejandro Narvaez","Genero":"M","FechaNacimiento":"1992-07-17","PaisNacimiento":"Colombia"},{"Id":"5e0891e1-a034-43b9-b510-23b78728211e","Nombre":"Ana Devia","Genero":"F","FechaNacimiento":"1999-07-17","PaisNacimiento":"Panamá"}]', N'https://example.com/akira-poster.jpg')
GO

INSERT INTO [dbo].[Peliculas] ([Id], [Titulo], [Director], [Productora], [FechaEstreno], [Actores], [FotoCartel]) VALUES (N'12', N'El Padrino', N'Francis Ford Coppola', N'Paramount Pictures', N'1972-03-15 00:00:00.000', N'[{"Nombre":"Marlon Brando","Genero":"Masculino","FechaNacimiento":"1924-04-03","PaisNacimiento":"Estados Unidos"},{"Nombre":"Al Pacino","Genero":"Masculino","FechaNacimiento":"1940-04-25","PaisNacimiento":"Estados Unidos"},{"Nombre":"James Caan","Genero":"Masculino","FechaNacimiento":"1940-03-26","PaisNacimiento":"Estados Unidos"}]', N'https://example.com/el-padrino-poster.jpg')
GO

SET IDENTITY_INSERT [dbo].[Peliculas] OFF
GO


-- ----------------------------
-- Auto increment value for Peliculas
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Peliculas]', RESEED, 12)
GO


-- ----------------------------
-- Primary Key structure for table Peliculas
-- ----------------------------
ALTER TABLE [dbo].[Peliculas] ADD CONSTRAINT [PK__Pelicula__3214EC07F910C335] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

