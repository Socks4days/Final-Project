-- View to get list of stock items and details of the last audit/next audit due
CREATE VIEW [dbo].[StockLevelsView]
	AS SELECT
		[Stock].*,
		[Audit].AuditDate,
		[Audit].AuditedByStaffId,
		-- Combine staff forename and surname
		CONCAT([Staff].Forename, ' ', [Staff].Surname) AS AuditedByStaffFullName,
		-- Calculate when next audit is due based on last audit date plus the stock check frequency
		DATEADD(DAY, [Stock].StockCheckFrequency, AuditDate) AS NextAuditDueDate,
		-- Calculate the number of days to the next audit (next audit date minus last audit date)
		DATEDIFF(DAY, GETDATE(), DATEADD(DAY, [Stock].StockCheckFrequency, AuditDate)) AS DaysToNextAudit
	FROM [Stock]
	-- Use left outer joins to cater for stock items that haven't been audited yet
	LEFT OUTER JOIN [AuditItem] ON [Stock].StockId = [AuditItem].StockId
	LEFT OUTER JOIN [Audit] ON [Audit].AuditId = [AuditItem].AuditId
	LEFT OUTER JOIN [Staff] ON [Staff].StaffId = [Audit].AuditedByStaffId
	WHERE [Audit].AuditId = (SELECT MAX([AuditItem].AuditId) FROM [AuditItem] WHERE [AuditItem].StockId = [Stock].StockId)
	 -- Only include active stock items
	AND [Stock].Active = 1