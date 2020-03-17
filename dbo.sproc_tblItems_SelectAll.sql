CREATE PROCEDURE sproc_tblItems_FilterByItemNo
--- parameter to store the item no we are looking for
	@ItemNo int
AS
---------select all the records from the table - where the item no matches the parameter data
	SELECT * from tblItems where ItemNo = @ItemNo
RETURN 0