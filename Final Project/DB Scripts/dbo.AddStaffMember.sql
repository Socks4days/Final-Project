USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[AddStaffMember] Script Date: 27/01/2025 21:05:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddStaffMember]
	@Username nvarchar(50),
	@Password nvarchar(50),
	@Forename nvarchar(50),
	@Surname nvarchar(50),
	@StaffPosition nvarchar(50),
	@Active int
AS
	INSERT INTO Staff VALUES(@Forename, @Surname, @StaffPosition, @Username, @Password, @Active)
RETURN 0
