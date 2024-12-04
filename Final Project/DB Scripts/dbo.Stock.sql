USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: Table [dbo].[Stock] Script Date: 04/12/2024 19:24:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Stock] (
    [StockId]              INT            IDENTITY (1, 1) NOT NULL,
    [StockName]            NVARCHAR (50)  NOT NULL,
    [StockDescription]     NVARCHAR (100) NOT NULL,
    [Price]                DECIMAL (18)   NOT NULL,
    [DeliveryTimeDays]     INT            NULL,
    [MaximumLevel]         INT            NOT NULL,
    [MinimumLevel]         INT            NOT NULL,
    [OrderQuantity]        INT            NULL,
    [StockCheckFrequency]  INT            NULL,
    [StockLevel]           INT            NOT NULL,
    [LastUpdatedByStaffId] INT            NULL,
    [Active]               INT            NOT NULL
);


