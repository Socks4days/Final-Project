USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: Table [dbo].[Delivery] Script Date: 14/12/2024 11:59:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Delivery] (
    [DeliveryNumber]           INT      IDENTITY (1, 1) NOT NULL,
    [OrderNumber]              INT      NOT NULL,
    [DeliveryDate]             DATETIME NOT NULL,
    [DeliveryCheckedByStaffId] INT      NOT NULL
);


