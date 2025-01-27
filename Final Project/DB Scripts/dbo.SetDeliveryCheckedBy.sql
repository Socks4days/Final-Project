USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[SetDeliveryCheckedBy] Script Date: 27/01/2025 21:03:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SetDeliveryCheckedBy]
	@DeliveryNumber int,
	@DeliveryCheckedByStaffId int
AS
	UPDATE Delivery SET DeliveryCheckedByStaffId = @DeliveryCheckedByStaffId 
	WHERE DeliveryNumber = @DeliveryNumber
RETURN 0
