-- Script de creación de la base de datos bd_telefonos, tabla telefonos y procedimiento almacenado

-- 1. Crear la base de datos
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'bd_telefonos')
BEGIN
    CREATE DATABASE bd_telefonos;
END
GO

USE bd_telefonos;
GO

-- 2. Crear la tabla telefonos
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'telefonos')
BEGIN
    CREATE TABLE telefonos (
        Nombre NVARCHAR(100) NOT NULL,
        Telefono NVARCHAR(20) NOT NULL PRIMARY KEY,
        Direccion NVARCHAR(200) NULL,
        Observaciones NVARCHAR(MAX) NULL
    );

    -- Insertar registros de prueba iniciales
    INSERT INTO telefonos (Nombre, Telefono, Direccion, Observaciones) VALUES
    ('Leticia Aguirre Soriano', '111222333', 'Triana, Sevilla', 'Ninguna'),
    ('Pedro Luis Perez', '222333444', 'Gran Vía, Madrid', 'Amigo de la universidad'),
    ('Pedro Aguado Rodriguez', '333444555', 'Calle Mayor, Alcalá de Henares', 'Compañero de trabajo');
END
GO

-- 3. Crear el procedimiento almacenado para actualizar registros
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'stproActualizarTelefono')
    DROP PROCEDURE stproActualizarTelefono;
GO

CREATE PROCEDURE stproActualizarTelefono
    @Telefono NVARCHAR(20),
    @Direccion NVARCHAR(200),
    @Observaciones NVARCHAR(MAX),
    @Nombre NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE telefonos
    SET Direccion = @Direccion,
        Observaciones = @Observaciones
    WHERE Telefono = @Telefono;
END
GO
