CREATE TABLE [dbo].[Tabla1]
(
	[IDusuario] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Usuario] VARCHAR(50) NOT NULL, 
    [Contraseña] VARCHAR(50) NOT NULL, 
    [Correo] VARCHAR(50) NOT NULL, 
    [Telefono] VARCHAR(50) NOT NULL
)
