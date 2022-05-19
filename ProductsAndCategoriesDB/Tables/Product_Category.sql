CREATE TABLE [dbo].[Product_Category]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	ProductId INT NULL,
	CategoryId INT NULL, 
    CONSTRAINT [FK_Category_Product_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id]),
	CONSTRAINT [FK_Category_Product_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id])
)
