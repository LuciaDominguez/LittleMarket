/*
Equipo: 8
Integrantes:
1603177 Yassiel De Leon Barrionuevo 
1809683 Roberto Romo Rodriguez
1743673 Lucía Guadalupe Domínguez De la Cruz

Query #1
Descripcion:
Creacion de Base de Datos y sus Tablas


fecha de creacion 2021-03-5
*/


CREATE DATABASE LittleMarketBD;
GO

USE LittleMarketBD;
GO

CREATE TABLE Pais(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Nombre VARCHAR(50)
);
GO
CREATE TABLE Estado(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Id_Pais INT NOT NULL,
Nombre VARCHAR(50) NOT NULL,
CONSTRAINT FK_EstadoPais_Pais FOREIGN KEY (Id_Pais) REFERENCES Pais(Id)
);
GO
CREATE TABLE Ciudad(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Id_Estado INT NOT NULL,
Nombre VARCHAR(50) NOT NULL,
CONSTRAINT FK_CiudadEstado_Estado FOREIGN KEY (Id_Estado) REFERENCES Estado(Id)
);
GO

CREATE TABLE  Usuario(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Nombre VARCHAR(50) NOT NULL,
ApellidoPaterno VARCHAR(50)NOT NULL,
ApellidoMaterno VARCHAR(50)NOT NULL,
Correo VARCHAR(50) NOT NULL,
Contra VARCHAR(50) NOT NULL,
Id_Pais INT NOT NULL,
Id_Ciudad INT NOT NULL,
Id_Estado INT NOT NULL,
Activo BIT NOT NULL,
UltimaConexion DATE NOT NULL,
Telefono VARCHAR(13) NOT NULL,
FechaDeRegistro DATE NOT NULL,
FechaDeNacimiento DATE NOT NULL,
Id_MetodoDePago INT,
CONSTRAINT FK_UsuarioPais_Pais FOREIGN KEY (Id_Pais) REFERENCES Pais(Id),
CONSTRAINT FK_UsuarioEstado_Estado FOREIGN KEY (Id_Estado) REFERENCES Estado(Id),
CONSTRAINT FK_UsuarioCiudad_Ciudad FOREIGN KEY (Id_Ciudad) REFERENCES Ciudad(Id)
);
GO

ALTER TABLE AspNetUsers
ADD Id_Pais Int;

ALTER TABLE AspNetUsers
ALTER COLUMN Id_Ciudad int NOT NULL;

sp_help 'AspNetUsers'

ALTER TABLE AspNetUsers
ADD FOREIGN KEY (Id_Pais) REFERENCES Pais(Id);
ALTER TABLE AspNetUsers
ADD CONSTRAINT FK_UsuarioEstado_Estado FOREIGN KEY (Id_Estado) REFERENCES Estado(Id);
ALTER TABLE AspNetUsers
ADD CONSTRAINT FK_UsuarioCiudad_Ciudad FOREIGN KEY (Id_Ciudad) REFERENCES Ciudad(Id);

ALTER TABLE AspNetUsers
DROP CONSTRAINT fk_inv_product_id;

//////////////////////////////////////////////////////////// coso aspnetusers ////////////////////////////////////////////////////////////////////////////

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 27/03/2021 11:05:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 27/03/2021 11:05:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 27/03/2021 11:05:23 a. m. ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 27/03/2021 11:05:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 27/03/2021 11:05:23 a. m. ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[ApellidoPaterno] [nvarchar](50) NULL,
	[ApellidoMaterno] [nvarchar](50) NULL,
	[Correo] [nvarchar](50) NULL,
	[Contra] [nvarchar](50) NULL,
	[Id_Pais] [int] NULL,
	[Id_Ciudad] [int] NULL,
	[Id_Estado] [int] NULL,
	[Activo] [bit] NULL,
	[UltimaConexion] [Date] NULL,
	[Telefono] [nvarchar](13) NULL,
	[FechaDeRegistro] [date] NULL,
	[FechaDeNacimiento] [date] NULL,
	[Id_MetodoDePago] [int] NULL
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 27/03/2021 11:05:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO

//////////////////////////////////////////////////////////////// coso aspnetusers //////////////////////////////////////////////////////////////////

CREATE TABLE Direccion(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Id_Usuario NVARCHAR(450) NOT NULL,
Id_Ciudad INT NOT NULL,
Calle VARCHAR(50) NOT NULL,
Numero VARCHAR(50) NOT NULL,
CodigoPostal VARCHAR(6) NOT NULL,
Departamento VARCHAR(50) NOT NULL,
CONSTRAINT FK_DireccionUsuario_Usuario FOREIGN KEY (Id_Usuario) REFERENCES AspNetUsers(Id),
CONSTRAINT FK_DireccionCiudad_Ciudad FOREIGN KEY (Id_Ciudad) REFERENCES Ciudad(Id)
);
GO

CREATE TABLE Categoria(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Nombre VARCHAR(50) NOT NULL,
Descripcion VARCHAR(MAX) NOT NULL,
);
GO

CREATE TABLE Imagen(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Foto varbinary(max) NOT NULL /*Equivalente a blob pero no cheque bien el tamaño*/
 );
 GO

 CREATE TABLE Video(
Id INT PRIMARY KEY IDENTITY NOT NULL,
LinkVideo VARCHAR(MAX) NOT NULL /*Equivalente a blob pero no cheque bien el tamaño*/
 );
 GO

CREATE TABLE Producto(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Precio INT NOT NULL,
CantidadAlmacen INT NOT NULL,
Descripcion VARCHAR(MAX) NOT NULL,
FechaDePublicacion DATE NOT NULL,
Nombre VARCHAR(50) NOT NULL,
Activo BIT NOT NULL,
Id_Categoria INT NOT NULL
CONSTRAINT FK_ProductoCategoria_Categoria FOREIGN KEY (Id_Categoria) REFERENCES Categoria(Id)
)
GO

CREATE TABLE Multimedia(
 Id INT PRIMARY KEY IDENTITY NOT NULL,
 Id_Producto INT NOT NULL,
 Tipo BIT NOT NULL,
 Id_Imagen INT NOT NULL,
 Id_Video INT NOT NULL,
 CONSTRAINT FK_MultimediaImagen_Imagen FOREIGN KEY (Id_Imagen) REFERENCES Imagen(Id),
 CONSTRAINT FK_MultimediaVideo_Video FOREIGN KEY (Id_Video) REFERENCES Video(Id),
 CONSTRAINT FK_MultimediaProducto_Producto FOREIGN KEY (Id_Producto) REFERENCES Producto(Id)

 );
 GO

CREATE TABLE Pedido(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Id_Usuario NVARCHAR(450) NOT NULL,
Id_Producto INT NOT NULL,
Id_Direccion INT NOT NULL,
Cantidad INT NOT NULL,
TotalAPagar INT NOT NULL,
FechaDePedido DATE NOT NULL,
FechaDeEntrega DATE,
PedidoRecibido BIT NOT NULL,
Comentarios VARCHAR(MAX),
CONSTRAINT FK_Pedidousuario_Usuario FOREIGN KEY (Id_Usuario) REFERENCES AspNetUsers(Id),
CONSTRAINT FK_PedidoProducto_Producto FOREIGN KEY (Id_Producto) REFERENCES Producto(Id),
CONSTRAINT FK_PedidoDireccion_Direccion FOREIGN KEY (Id_Direccion) REFERENCES Direccion(Id)

);
GO
CREATE TABLE Comentario(
Id INT PRIMARY KEY IDENTITY NOT NULL,
TextoComentario VARCHAR(MAX),
Id_Usuario NVARCHAR(450) NOT NULL,
Id_Producto INT NOT NULL,
FechaDePublicacion DATE NOT NULL,
Activo BIT NOT NULL,
CONSTRAINT FK_ComentarioUsuario_Usuario FOREIGN KEY (Id_Usuario) REFERENCES AspNetUsers(Id),
CONSTRAINT FK_ComentarioProducto_Producto FOREIGN KEY (Id_Producto) REFERENCES Producto(Id)
);
GO
CREATE TABLE LikeProducto(
Id INT PRIMARY KEY IDENTITY NOT NULL,
[Like] BIT NOT NULL,
Id_Producto INT NOT NULL,
Id_Usuario NVARCHAR(450) NOT NULL,
CONSTRAINT FK_LikeProductoUsuario_Usuario FOREIGN KEY (Id_Usuario) REFERENCES AspNetUsers(Id),
CONSTRAINT FK_LikeProductoProducto_Producto FOREIGN KEY (Id_Producto) REFERENCES Producto(Id)
);
GO

select * from AspNetUsers

select * from Usuario

UPDATE AspNetUsers
SET LockoutEnd = '20211114 08:54:00 +10:00'
WHERE Id = '61363d49-e3c2-4105-b5bc-aea8dc87fe64';

drop table Usuario
drop table Ciudad
drop table Estado
drop table Pais
drop table AspNetRoleClaims
drop table AspNetRoles
drop table AspNetUserClaims
drop table AspNetUserLogins
drop table AspNetUserRoles
drop table AspNetUsers
drop table AspNetUserTokens
drop table Direccion
drop table Categoria
drop table Imagen
drop table Video
drop table Producto
drop table Multimedia
drop table Pedido
drop table Comentario
drop table LikeProducto