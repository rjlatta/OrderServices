CREATE TABLE [dbo].[OrderTable]
(
	[OrderId] INT NOT NULL PRIMARY KEY, 
    [CustomerName] VARCHAR(50) NOT NULL, 
    [CustomerAddress] VARCHAR(50) NOT NULL, 
    [OrderDate] DATETIME NOT NULL, 
    [DeliveryDate] DATE NOT NULL, 
    [ProductOrder] VARCHAR(MAX) NOT NULL 
)
