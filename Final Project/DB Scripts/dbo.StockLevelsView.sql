USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: View [dbo].[StockLevelsView] Script Date: 04/12/2024 19:25:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[StockLevelsView]
	AS SELECT [Stock].StockId, [Stock].StockName, [Stock].StockLevel, [Audit].AuditDate, [Audit].AuditedByStaffId, CONCAT([Staff].Forename, ' ', [Staff].Surname) AS [AuditedByStaffFullName]
	FROM [Stock]
	LEFT OUTER JOIN [StockAudit] ON [Stock].StockId = [StockAudit].StockId
	LEFT OUTER JOIN [Audit] ON [Audit].AuditId = [StockAudit].AuditId
	LEFT OUTER JOIN [Staff] ON [Staff].StaffId = [Audit].AuditedByStaffId
