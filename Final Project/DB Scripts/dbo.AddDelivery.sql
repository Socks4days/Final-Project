USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[AddDelivery] Script Date: 27/01/2025 21:05:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddDelivery]
	@DeliveryNumber int OUTPUT,
	@OrderNumber int,
	@DeliveryDate DateTime,
	@DeliveryCheckedByStaffId int	
AS
	INSERT INTO Delivery VALUES (@OrderNumber, @DeliveryDate, @DeliveryCheckedByStaffId)
	SELECT @DeliveryNumber = SCOPE_IDENTITY()
RETURN 0
