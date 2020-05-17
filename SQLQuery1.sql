USE [E-Auction]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblItems_SelectAll]

SELECT	@return_value as 'Return Value'

GO
