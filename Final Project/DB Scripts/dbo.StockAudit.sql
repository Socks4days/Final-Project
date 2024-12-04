USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: Table [dbo].[StockAudit] Script Date: 04/12/2024 19:24:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StockAudit] (
    [AuditId]         INT NOT NULL,
    [StockId]         INT NOT NULL,
    [PredictedAmount] INT NULL,
    [ActualAmount]    INT NULL
);


