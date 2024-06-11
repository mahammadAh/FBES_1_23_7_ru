SELECT CustomerName
FROM Customers

SELECT CustomerName , Country
FROM Customers

SELECT *
FROM Customers

SELECT CustomerName AS Imya
FROM Customers

SELECT CustomerName AS [Customer Name]
FROM Customers

SELECT *
FROM Products
WHERE Price > 18

SELECT *
FROM Products
WHERE Price > 18 AND Price < 30

SELECT *
FROM Products
WHERE Price < 18 OR Price > 30

SELECT *
FROM Products
WHERE NOT Price < 18 

SELECT *
FROM Products
WHERE NOT (Price > 18 AND Price < 30)

SELECT *
FROM Products
WHERE Price BETWEEN 10 AND 30

SELECT *
FROM Products
--WHERE Price = 18 OR Price = 10 OR Price = 20
WHERE Price IN(19,10,20)

SELECT *
FROM Customers
WHERE Country = "Germany"

SELECT *
FROM Customers
WHERE Country LIKE "A%"

SELECT *
FROM Customers
WHERE Country LIKE "%A%"

SELECT *
FROM Customers
WHERE Country LIKE "_e%"

SELECT * 
FROM Products
ORDER BY Price 

SELECT * 
FROM Products
ORDER BY Price DESC

SELECT * 
FROM Products
ORDER BY Price ASC