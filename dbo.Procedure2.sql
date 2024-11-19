CREATE PROCEDURE [dbo].[RemoveStock]
	@StockId int	
AS
	DELETE FROM Stock WHERE StockId = @StockId
RETURN 0
