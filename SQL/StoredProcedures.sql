DECLARE @num int = 12;

PRINT @num


SELECT * 
FROM Product
WHERE UnitPrice = (SELECT Max(UnitPrice) FROM Product)


DECLARE @maxPrice float = (SELECT MAX(UnitPrice) FROM Product);

SELECT * 
FROM Product
WHERE UnitPrice =  @maxPrice 


CREATE PROCEDURE FirstProcedure
AS
SELECT * FROM Product


EXECUTE FirstProcedure



CREATE PROCEDURE DiapazonProcdure
	@minPrice float,
	@maxPrice float
AS
SELECT * 
FROM Product
WHERE UnitPrice BETWEEN @minPrice AND @maxPrice

DROP PROC DiapazonProcdure

--EXECUTE DiapazonProcdure 200 , 500
EXEC DiapazonProcdure 1000 , 1500


CREATE PROCEDURE AddProductProcedure
	@ProductName  nvarchar(50),
	@SupplierId int ,
	@UnitPrice decimal(12,2),
	@Package nvarchar(30),
	@IsDiscontinued  bit
AS
INSERT INTO Product VALUES(@ProductName,@SupplierId,@UnitPrice,@Package,@IsDiscontinued)


DECLARE @i int = 0;

while (@i < 10 ) 
BEGIN
PRINT @i
SET @i = (@i + 1)
END


EXEC AddProductProcedure 'Iphone 15',18,1200,'10',1



CREATE PROCEDURE GetMinPricerocedure
@minPrice FLOAT OUTPUT
AS
SET @minPrice = (SELECT MIN(UnitPrice) FROM Product)



DECLARE @myMinPrice float;
EXEC GetMinPricerocedure @myMinPrice OUTPUT   
PRINT @myMinPrice
