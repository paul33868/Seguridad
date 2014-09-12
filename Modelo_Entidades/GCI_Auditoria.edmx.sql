
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/12/2014 11:50:59
-- Generated from EDMX file: C:\Users\Pablo\Downloads\Modulo de Seguridad\Modelo_Entidades\GCI_Auditoria.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Seguridad_Auditoria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Auditorias_Log]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Auditorias_Log];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Auditorias_Log'
CREATE TABLE [dbo].[Auditorias_Log] (
    [id] int IDENTITY(1,1) NOT NULL,
    [usuario] nvarchar(max)  NOT NULL,
    [fecha] datetime  NOT NULL,
    [accion] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Auditorias_Log'
ALTER TABLE [dbo].[Auditorias_Log]
ADD CONSTRAINT [PK_Auditorias_Log]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------