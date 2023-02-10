SELECT Products.Name AS Product, coalesce(Categories.Name, "No Category Assigned") AS Category
FROM Products
LEFT JOIN ProductCategories
	ON Products.Id = ProductCategories.ProductId
LEFT JOIN Categories
	ON ProductCategories.CategoryId = Categories.Id;