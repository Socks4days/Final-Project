USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[UpdateStaffMember] Script Date: 27/01/2025 21:04:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateStaffMember]
	@StaffId int,
	@Forename nvarchar(50),
	@Surname nvarchar(50),
	@Username nvarchar(50),
	@Password nvarchar(50)
AS
	UPDATE Staff SET Forename = @Forename, Surname = @Surname, Username = @Username, Password = @Password
	WHERE StaffId = @StaffId
RETURN 0
