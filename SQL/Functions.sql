USE Shop

CREATE FUNCTION FirstFunc (@min float , @max float)
RETURNS  FLOAT
AS
BEGIN
DECLARE @result FLOAT
SET @result = (SELECT MIN(UnitPrice)
FROM Product
WHERE UnitPrice BETWEEN @min AND @max )
RETURN (@result)
END


SELECT dbo.FirstFunc (50 ,100)


DECLARE @funcResult FLOAT
SET @funcResult = ( SELECT dbo.FirstFunc (50 , 100) )
PRINT @funcResult


SELECT *
FROM Product
WHERE UnitPrice = ( SELECT dbo.FirstFunc(120,240))