USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[AddAuditItem] Script Date: 27/01/2025 21:05:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddAuditItem]
	@AuditId int,
	@StockId int,
	@PredictedAmount int,
	@ActualAmount int
AS
	INSERT INTO AuditItem VALUES (@AuditId, @StockId, @PredictedAmount, @ActualAmount)
RETURN 0
