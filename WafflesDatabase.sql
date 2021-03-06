USE [WaflesJuice]
GO
/****** Object:  Table [dbo].[Binnacle]    Script Date: 31/05/2021 09:10:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Binnacle](
	[Sheet] [int] IDENTITY(1,1) NOT NULL,
	[Who] [int] NOT NULL,
	[What] [varchar](255) NOT NULL,
	[Wheree] [varchar](255) NOT NULL,
	[Whenn] [date] NOT NULL,
 CONSTRAINT [PK__Binnacle__089E60E759487E08] PRIMARY KEY CLUSTERED 
(
	[Sheet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 31/05/2021 09:10:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[BookType] [varchar](255) NOT NULL,
	[BookTitle] [varchar](255) NOT NULL,
	[BookPages] [int] NOT NULL,
	[BookTags] [varchar](255) NOT NULL,
	[BookAutor] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Books__3DE0C207CC7EF5C6] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Favorites]    Script Date: 31/05/2021 09:10:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Favorites](
	[FavoriteId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BookID] [int] NOT NULL,
 CONSTRAINT [PK__Favorite__CE74FAD5C027E2FC] PRIMARY KEY CLUSTERED 
(
	[FavoriteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trash]    Script Date: 31/05/2021 09:10:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trash](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserPassword] [varchar](255) NOT NULL,
	[UserType] [int] NOT NULL,
	[UserName] [varchar](255) NOT NULL,
	[UserEmail] [varchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeCharge]    Script Date: 31/05/2021 09:10:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeCharge](
	[TypeId] [int] NOT NULL,
	[PositionName] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 31/05/2021 09:10:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserPassword] [varchar](255) NOT NULL,
	[UserType] [int] NOT NULL,
	[UserName] [varchar](255) NOT NULL,
	[UserEmail] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Users__1788CC4C083658CB] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Binnacle] ON 

INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2153, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2154, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2155, 23, N'Add favorite book', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2156, 23, N'Add favorite book', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2157, 23, N'Add favorite book', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2158, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2159, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2160, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2161, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2162, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2163, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2164, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2165, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2166, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2167, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2168, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2169, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2170, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2171, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2172, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2173, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2174, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2175, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2176, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2177, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2178, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2179, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2180, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2181, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2182, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2183, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2184, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2185, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2186, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2187, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2188, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2189, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2190, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2191, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2192, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2193, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2194, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2195, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2196, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2197, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2198, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2199, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2200, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2201, 22, N'Login', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2202, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2203, 22, N'Login', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2204, 22, N'Login', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2205, 22, N'Login', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2206, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2207, 23, N'Backup created', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2208, 23, N'Login', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2209, 23, N'Modified Martin data', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
INSERT [dbo].[Binnacle] ([Sheet], [Who], [What], [Wheree], [Whenn]) VALUES (2210, 23, N'Modified Martin data', N'Toshokan Project', CAST(N'2021-05-31' AS Date))
SET IDENTITY_INSERT [dbo].[Binnacle] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookId], [BookType], [BookTitle], [BookPages], [BookTags], [BookAutor]) VALUES (1, N'
Animals', N'Guía para Entender al Gato', 50, N'-', N'Laura Trillo')
INSERT [dbo].[Books] ([BookId], [BookType], [BookTitle], [BookPages], [BookTags], [BookAutor]) VALUES (2, N'Art', N'La música en Latinoamérica', 323, N'-', N'Ricardo Miranda y Aurelio Tello')
INSERT [dbo].[Books] ([BookId], [BookType], [BookTitle], [BookPages], [BookTags], [BookAutor]) VALUES (6, N'Animals', N'Fauna Silvestre amenazada del Perú', 532, N'-', N'Ministerio de Agricultura y Riego y Servicio Nacional Forestal y de Fauna Silvestre')
INSERT [dbo].[Books] ([BookId], [BookType], [BookTitle], [BookPages], [BookTags], [BookAutor]) VALUES (10, N'Biology', N'Biodiversidad Marina Tropical', 38, N'-', N'Instituto Español de Oceanografía')
INSERT [dbo].[Books] ([BookId], [BookType], [BookTitle], [BookPages], [BookTags], [BookAutor]) VALUES (11, N'Biology', N'Biological and ecological traits of marine species', 29, N'-', N'Mark John Costello, Simon Claus y Harvey Tyler-Walters')
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Favorites] ON 

INSERT [dbo].[Favorites] ([FavoriteId], [UserId], [BookID]) VALUES (1014, 23, 1)
INSERT [dbo].[Favorites] ([FavoriteId], [UserId], [BookID]) VALUES (1015, 23, 2)
INSERT [dbo].[Favorites] ([FavoriteId], [UserId], [BookID]) VALUES (1016, 23, 6)
SET IDENTITY_INSERT [dbo].[Favorites] OFF
GO
SET IDENTITY_INSERT [dbo].[Trash] ON 

INSERT [dbo].[Trash] ([UserId], [UserPassword], [UserType], [UserName], [UserEmail]) VALUES (29, N'BrianBa3', 1, N'Brian Batres', N'BrianBa3@hormail.com')
INSERT [dbo].[Trash] ([UserId], [UserPassword], [UserType], [UserName], [UserEmail]) VALUES (30, N'admin', 1, N'admin', N'admin@gmail.com')
INSERT [dbo].[Trash] ([UserId], [UserPassword], [UserType], [UserName], [UserEmail]) VALUES (31, N'321', 0, N'Martin', N'Martin@gmail.com')
INSERT [dbo].[Trash] ([UserId], [UserPassword], [UserType], [UserName], [UserEmail]) VALUES (32, N'user', 0, N'user', N'user@gmail.com')
SET IDENTITY_INSERT [dbo].[Trash] OFF
GO
INSERT [dbo].[TypeCharge] ([TypeId], [PositionName]) VALUES (0, N'Usuario')
INSERT [dbo].[TypeCharge] ([TypeId], [PositionName]) VALUES (1, N'Administrator')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserPassword], [UserType], [UserName], [UserEmail]) VALUES (22, N'BrianBa3', 1, N'Brian Batres', N'BrianBa3@hormail.com')
INSERT [dbo].[Users] ([UserId], [UserPassword], [UserType], [UserName], [UserEmail]) VALUES (23, N'admin', 1, N'admin', N'admin@gmail.com')
INSERT [dbo].[Users] ([UserId], [UserPassword], [UserType], [UserName], [UserEmail]) VALUES (24, N'321', 0, N'Martin', N'Martin@gmail.com')
INSERT [dbo].[Users] ([UserId], [UserPassword], [UserType], [UserName], [UserEmail]) VALUES (25, N'user', 0, N'user', N'user@gmail.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Binnacle]  WITH CHECK ADD  CONSTRAINT [FK__Binnacle__Who__2F10007B] FOREIGN KEY([Who])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Binnacle] CHECK CONSTRAINT [FK__Binnacle__Who__2F10007B]
GO
ALTER TABLE [dbo].[Favorites]  WITH CHECK ADD  CONSTRAINT [FK__Favorites__BookI__2E1BDC42] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookId])
GO
ALTER TABLE [dbo].[Favorites] CHECK CONSTRAINT [FK__Favorites__BookI__2E1BDC42]
GO
ALTER TABLE [dbo].[Favorites]  WITH CHECK ADD  CONSTRAINT [FK__Favorites__UserI__2D27B809] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Favorites] CHECK CONSTRAINT [FK__Favorites__UserI__2D27B809]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK__Users__UserType__2C3393D0] FOREIGN KEY([UserType])
REFERENCES [dbo].[TypeCharge] ([TypeId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK__Users__UserType__2C3393D0]
GO
/****** Object:  StoredProcedure [dbo].[spAcDatos]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spAcDatos]
(
	@UserOr int,
	@UserID int,
	@UserPass varchar(255),
	@UserType int,
	@UserName varchar(255),
	@UserEmail varchar(255)

)
as
Begin
   Begin Try
       Begin Transaction
	      /*****************************************************************************/
          declare @Checar int
		  set @Checar=(select UserId from Users where UserId=@UserID)
		  if(@Checar is null)
		  Begin
		      print 'An error occurred with the data'
		  /*****************************************************************************/
		  End
		  else
		  Begin
		  /*****************************************************************************/
			DELETE FROM Trash
			SET IDENTITY_INSERT [dbo].[Users] ON 
			insert into Trash select UserPassword, UserType, UserName, UserEmail from Users
			SET IDENTITY_INSERT [dbo].[Users] OFF
			

		    update Users set UserPassword = @UserPass, UserType=@UserType,UserName=@UserName, UserEmail=@UserEmail Where UserId=@UserID

			insert into Binnacle values(@UserOr,'Modified '+@UserName + ' data','Toshokan Project',getdate())
		  /*****************************************************************************/
		  end
       Commit Tran
   End Try
   Begin Catch
       RollBack Tran
   End Catch
End
GO
/****** Object:  StoredProcedure [dbo].[spAddFavorite]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spAddFavorite]
(
	@idLibro int,
	@idUsuario int
)
as
Begin
   Begin Try
      Begin Transaction
	       declare @idAltaU int
		   set @idAltaU=(select FavoriteId from Favorites where @idLibro = BookID and @idUsuario = UserId )
		   if(@idAltaU is null)
		   begin
		       INSERT INTO Favorites VALUES(@idUsuario, @idLibro)
			   INSERT INTO Binnacle VALUES(@idUsuario, 'Add favorite book', 'Toshokan Project', GETDATE())
			   print 'Libro agregado correctamente'
		   end
		   else
		   begin
		   --EL LIBRO YA EXISTE
				DELETE FROM Favorites WHERE @idLibro = BookID and @idUsuario = UserId 
				INSERT INTO Binnacle VALUES(@idUsuario, 'Deleted favorite book', 'Toshokan Project', GETDATE())
		        print 'Libro eliminado correctamente'
		   end

	  commit Transaction
	End Try
	Begin Catch
	   rollback Transaction
    End Catch
End
GO
/****** Object:  StoredProcedure [dbo].[spAltaUsuarios]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spAltaUsuarios]
(
  @UsuarioAlta varchar(255),
  @Contra varchar(255),
  @Email varchar(255)

)
as
Begin
   Begin Try
      Begin Transaction
	       declare @idAltaU int
		   set @idAltaU=(select UserId from Users where @UsuarioAlta=UserName and @Contra=UserPassword and 0 = UserType and @Email = UserEmail )
		   if(@idAltaU is null)
		   begin
				
				insert into Users values(@Contra, 0, @UsuarioAlta, @Email)

				DECLARE @newiduser INT
				SET @newiduser = (select UserId from Users where @UsuarioAlta=UserName and @Contra=UserPassword)
				insert into Binnacle values(@newiduser, 'Registered user "'+@UsuarioAlta+'"', 'Toshokan Project', GETDATE())
				print 'Usuario dado de alta exitosamente'
		   end
		   else
		   begin
		       print 'El usuario que pretendes dar de alta ya existe en la base de datos'
		   end

	  commit Transaction
	End Try
	Begin Catch
	   rollback Transaction
    End Catch
End
GO
/****** Object:  StoredProcedure [dbo].[spBacBD]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spBacBD]
(
	@idUsuario int,
	@directorio varchar(255)
)
as
Begin
		DECLARE @ruta VARCHAR(255)= @directorio+'\WAJLibrary.bak'
		backup database WaflesJuice to disk = @ruta WITH NOFORMAT, NOINIT, NAME = 'WaflesJuice-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10, DESCRIPTION='Copia de seguridad de proyecto WaflesJuice'	       
		
		insert into Binnacle values(@idUsuario, 'Backup created', 'Toshokan Project', GETDATE())
End
GO
/****** Object:  StoredProcedure [dbo].[spBajaUsuario]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spBajaUsuario]
(
	@idLogueado int,
	@UserId int
)
as
Begin
   Begin Try
      Begin Transaction
	       declare @idAltaU int
		   declare @idUs int
		   set @idAltaU=(select UserId from Users where @idLogueado = UserId)
		   set @idUs = (select UserId from Users where @UserId = UserId)
		   if(@idAltaU is null and @idUs is null)
		   begin
		       print 'Error, porfavor comprueba que la id exista'
		   end
		   else
		   begin
			   DELETE FROM Users WHERE @UserId = UserId
			   INSERT INTO Binnacle VALUES(@idLogueado, 'User deleted' , 'Toshokan Project', GETDATE())
			   print 'Usuario Eliminado correctamente'
		   end

	  commit Transaction
	End Try
	Begin Catch
	   rollback Transaction
    End Catch
End
GO
/****** Object:  StoredProcedure [dbo].[spDelteFa]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDelteFa]
(
	@FavoriteId int,
	@idUsuario int
)
as
Begin
   Begin Try
      Begin Transaction
	       declare @idAltaU int
		   declare @idUs int
		   set @idAltaU=(select FavoriteId from Favorites where @FavoriteId = FavoriteId )
		   set @idUs = (select UserId from Users where @idUsuario = UserId)
		   if(@idAltaU is null and @idUs is null)
		   begin
		       print 'Error, porfavor comprueba que la id exista'
		   end
		   else
		   begin
			   DELETE FROM Favorites WHERE @FavoriteId = FavoriteId
			   INSERT INTO Binnacle VALUES(@idUsuario, 'favorite boo deleted' , 'Toshokan Project', GETDATE())
			   print 'Libro Eliminado correctamente'
		   end

	  commit Transaction
	End Try
	Begin Catch
	   rollback Transaction
    End Catch
End
GO
/****** Object:  StoredProcedure [dbo].[spLogueo]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spLogueo]
(
	@UserName VARCHAR(255),
	@UserPassword VARCHAR(255),
	@UserId int output,
	@UserType int output,
	@Status bit output
)

AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DECLARE @Mensaje varchar(50)
			SET @UserId = (SELECT UserId FROM Users WHERE @UserName = UserName AND @UserPassword = UserPassword)
	        SET @UserType = (SELECT UserType FROM Users WHERE @UserName = UserName AND @UserPassword = UserPassword)
			IF(@UserId is null)
			BEGIN
				SET @Status = 'false'
				SET @Mensaje = 'Wrong password or username :('
				PRINT @Mensaje
			END
			ELSE
			BEGIN
				INSERT INTO Binnacle VALUES(@UserId,'Login', 'Toshokan Project',GETDATE())
				SET @Status = 'True'
				SET @Mensaje = 'Welcome ' + @UserName
				PRINT @Mensaje
			END
			
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[spRestaurar]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spRestaurar]

as
Begin
   Begin Try
      Begin Transaction
			DELETE FROM Users
	        SET IDENTITY_INSERT [dbo].[Trash] ON 
			insert into Users select UserPassword, UserType, UserName, UserEmail from Trash
			SET IDENTITY_INSERT [dbo].[Trash] OFF

	  commit Transaction
	End Try
	Begin Catch
	   rollback Transaction
    End Catch
End
GO
/****** Object:  StoredProcedure [dbo].[spRPass]    Script Date: 31/05/2021 09:10:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spRPass]
(
	@idResponsable int,
	@idResetear int,
	@nuevaContra varchar(10) output

)
as
Begin
   Begin Try
       Begin Transaction
          declare @longitud int
		  declare @min tinyint = 48
		  declare @rango tinyint = 74
		  declare @excluir varchar(50) = ':;<>=\^_`@ ?¿¡![]'
		  declare @NombreContraResetear varchar(100)

		  set @longitud=10
		  declare @idUResetear int
		  set @idUResetear=(select UserId from Users where UserId=@idResponsable)
		  if(@idUResetear is null)
		  Begin
		      print 'The user you want to change the password for does not exist in the BD'
		  End
		  else
		  Begin
		      set @NombreContraResetear=(select UserName from Users where UserId=@idResetear )
			  declare @caracter char
			  set @nuevaContra=''
			  while @longitud>0
			  Begin
			      select @caracter=CHAR(Round(rand()*@rango+@min,0))
				  if (Charindex(@caracter,@excluir)=0)
				  begin
				       set @nuevaContra+=@caracter
					   set @longitud = @longitud -1
				  end
			  End
			  update Users set UserPassword=@nuevaContra where UserId=@idResetear
			  insert into Binnacle values(@idResponsable,'Change '+@NombreContraResetear +'s password','Toshokan Project',getdate())
			  print 'The new password is '+@nuevaContra

		  end
       Commit Tran
   End Try
   Begin Catch
       RollBack Tran
   End Catch
End
GO
