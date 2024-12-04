USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: Table [dbo].[Order] Script Date: 04/12/2024 19:23:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Order] (
    [OrderNumber]          INT           IDENTITY (1, 1) NOT NULL,
    [OrderDate]            DATETIME      NOT NULL,
    [OrderPlacedByStaffId] INT           NOT NULL,
    [OrderStatus]          NVARCHAR (50) NOT NULL
);


