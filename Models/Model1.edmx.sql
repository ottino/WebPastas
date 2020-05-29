
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/29/2020 00:15:36
-- Generated from EDMX file: C:\Users\maxi\source\repos\WebPastas\WebPastas\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [wi200122_pastas_t];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[wi200122_pastas_tModelStoreContainer].[usuario]', 'U') IS NOT NULL
    DROP TABLE [wi200122_pastas_tModelStoreContainer].[usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'usuario'
CREATE TABLE [dbo].[usuario] (
    [id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [nombre] varchar(100)  NULL,
    [email] varchar(255)  NULL,
    [password] varchar(255)  NULL,
    [rol_id] decimal(18,0)  NULL,
    [fecha_alta] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [PK_usuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------