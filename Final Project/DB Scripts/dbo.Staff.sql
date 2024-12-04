USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: Table [dbo].[Staff] Script Date: 04/12/2024 19:24:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Staff] (
    [StaffId]       INT           IDENTITY (1, 1) NOT NULL,
    [Forename]      NVARCHAR (50) NOT NULL,
    [Surname]       NVARCHAR (50) NOT NULL,
    [StaffPosition] NVARCHAR (50) NOT NULL,
    [Username]      NVARCHAR (50) NOT NULL,
    [Password]      NVARCHAR (50) NOT NULL,
    [Active]        INT           NULL
);


