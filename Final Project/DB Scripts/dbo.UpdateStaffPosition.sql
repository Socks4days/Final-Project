USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[UpdateStaffPosition] Script Date: 27/01/2025 21:04:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateStaffPosition]
	@StaffId int,
	@StaffPosition nvarchar(50)
AS
	UPDATE Staff SET StaffPosition = @StaffPosition 
	WHERE StaffId = @StaffId
RETURN 0
