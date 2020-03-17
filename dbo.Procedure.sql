CREATE PROCEDURE sproc_tblItems_FilterByItemNo
-- parameter to store the item no 
	@ItemNo int
AS
-- select fields from the table where the item no matches the parameter data
		select * from tblItems where ItemNo = @ItemNo

RETURN 0