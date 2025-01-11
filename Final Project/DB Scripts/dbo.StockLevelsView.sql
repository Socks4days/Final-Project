USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: View [dbo].[StockLevelsView] Script Date: 11/01/2025 15:05:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[StockLevelsView]
	AS SELECT [Stock].StockId, [Stock].StockName, [Stock].StockLevel, [Audit].AuditDate, [Audit].AuditedByStaffId, CONCAT([Staff].Forename, ' ', [Staff].Surname) AS [AuditedByStaffFullName]
	FROM [Stock]
	LEFT OUTER JOIN [AuditItem] ON [Stock].StockId = [AuditItem].StockId
	LEFT OUTER JOIN [Audit] ON [Audit].AuditId = [AuditItem].AuditId
	LEFT OUTER JOIN [Staff] ON [Staff].StaffId = [Audit].AuditedByStaffId
	WHERE [Audit].AuditId = (SELECT MAX([AuditItem].AuditId) FROM [AuditItem] WHERE [AuditItem].StockId = [Stock].StockId)
