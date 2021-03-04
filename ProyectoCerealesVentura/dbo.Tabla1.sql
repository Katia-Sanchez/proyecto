CREATE TABLE [dbo].[Tabla1] (
    [IDusuario]  INT          IDENTITY (1, 1) NOT NULL,
    [Usuario]    VARCHAR (50) NOT NULL,
    [Contraseña] VARCHAR (50) NOT NULL,
    [Correo]     VARCHAR (50) NOT NULL,
    [Telefono]   VARCHAR (08) NOT NULL,
    PRIMARY KEY CLUSTERED ([IDusuario] ASC)
);

