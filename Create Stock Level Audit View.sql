CREATE VIEW [dbo].[StockLevelsView]
	AS SELECT [Stock].StockId, [Stock].StockName, [Stock].StockLevel, [Audit].AuditDate, [Audit].AuditedByStaffId, CONCAT([Staff].Forename, ' ', [Staff].Surname) AS [AuditedByStaffFullName]
	FROM [Stock]
	LEFT OUTER JOIN [StockAudit] ON [Stock].StockId = [StockAudit].StockId
	LEFT OUTER JOIN [Audit] ON [Audit].AuditId = [StockAudit].AuditId
	LEFT OUTER JOIN [Staff] ON [Staff].StaffId = [Audit].AuditedByStaffId