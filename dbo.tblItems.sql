CREATE TABLE [dbo].[tblItems] (
    [ItemNo]          INT  IDENTITY (1, 1) NOT NULL,
    [ItemDescription] TEXT NOT NULL,
    [ItemQuantity]    INT  NOT NULL,
    [ItemPricePerUnit] DECIMAL NOT NULL, 
    [ItemDateofAvailabiliy] DATETIME NOT NULL, 
    PRIMARY KEY CLUSTERED ([ItemNo] ASC)
);

