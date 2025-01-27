USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[SetOrderPlacedBy] Script Date: 27/01/2025 21:03:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SetOrderPlacedBy]
	@OrderNumber int,
	@OrderPlacedByStaffId int
AS
	UPDATE [Order] SET OrderPlacedByStaffId = @OrderPlacedByStaffId
	WHERE OrderNumber = @OrderNumber
RETURN 0
