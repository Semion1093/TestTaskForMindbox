CREATE PROCEDURE[dbo].[GetAllProductsAndCategories] AS BEGIN 

SELECT 
  p.[Name] AS Product, 
  c.[Name] AS Category 
FROM 
  Product_Category cp 
  left join Category c ON c.Id = cp.CategoryId 
  left join Product p ON p.Id = cp.ProductId 
END

