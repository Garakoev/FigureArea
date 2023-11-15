# Radius
-В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, 
в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
-- SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID;
