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

CREATE TABLE Direccion(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Id_Usuario INT NOT NULL,
Id_Ciudad INT NOT NULL,
Calle VARCHAR(50) NOT NULL,
Numero VARCHAR(50) NOT NULL,
CodigoPostal VARCHAR(6) NOT NULL,
Departamento VARCHAR(50) NOT NULL,
CONSTRAINT FK_DireccionUsuario_Usuario FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id),
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
Id_Usuario INT NOT NULL,
Id_Producto INT NOT NULL,
Id_Direccion INT NOT NULL,
Cantidad INT NOT NULL,
TotalAPagar INT NOT NULL,
FechaDePedido DATE NOT NULL,
FechaDeEntrega DATE,
PedidoRecibido BIT NOT NULL,
Comentarios VARCHAR(MAX),
CONSTRAINT FK_Pedidousuario_Usuario FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id),
CONSTRAINT FK_PedidoProducto_Producto FOREIGN KEY (Id_Producto) REFERENCES Producto(Id),
CONSTRAINT FK_PedidoDireccion_Direccion FOREIGN KEY (Id_Direccion) REFERENCES Direccion(Id)

);
GO
CREATE TABLE Comentario(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Comentario VARCHAR(MAX),
Id_Usuario INT NOT NULL,
Id_Producto INT NOT NULL,
FechaDePublicacion DATE NOT NULL,
Activo BIT NOT NULL,
CONSTRAINT FK_ComentarioUsuario_Usuario FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id),
CONSTRAINT FK_ComentarioProducto_Producto FOREIGN KEY (Id_Producto) REFERENCES Producto(Id)
);
GO
CREATE TABLE LikeProducto(
Id INT PRIMARY KEY IDENTITY NOT NULL,
[Like] BIT NOT NULL,
Id_Producto INT NOT NULL,
Id_Usuario INT NOT NULL,
CONSTRAINT FK_LikeProductoUsuario_Usuario FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id),
CONSTRAINT FK_LikeProductoProducto_Producto FOREIGN KEY (Id_Producto) REFERENCES Producto(Id)
);
GO