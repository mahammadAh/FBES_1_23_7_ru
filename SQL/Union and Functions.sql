CREATE DATABASE NovademyCourse

USE NovademyCourse

CREATE TABLE Teachers 
(
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(50),
Surname VARCHAR(50),
Salary MONEY
)


CREATE TABLE Students 
(
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(50),
Surname VARCHAR(50),
)


INSERT INTO Teachers 
VALUES
('Djamil','Abbasov',-1245),
('314','Dadashov',200.874),
('Faxri','Gozalov',2000.3455),
('Narmina','Suleymanova',3241.334),
('Rufat','Guliyev',1213.3440),
('Zaur','Dadashov',200.874)


INSERT INTO Students 
VALUES
('Farid','Jalilov'),
('Kamran','Aslanov'),
('Yusif','Aliyev'),
('Fikret','Zeynalov'),
('Rufat','Guliyev'),
('Aytac','Murquzova'),
('Sara','Aliyeva'),
('Zaur','Dadashov'),
('Samin','Efendiyev')

INSERT INTO Students 
VALUES
('   Fidan  ','Aliyeva')


SELECT *
FROM Teachers


SELECT *
FROM Students


SELECT T.[Name] , T.Surname 
FROM Teachers T
UNION SELECT S.[Name] , S.Surname 
FROM Students S

SELECT T.[Name] , T.Surname 
FROM Teachers T
EXCEPT SELECT S.[Name] , S.Surname 
FROM Students S

SELECT T.[Name] , T.Surname 
FROM Teachers T
INTERSECT SELECT S.[Name] , S.Surname 
FROM Students S



SELECT *
FROM Students S
WHERE LEN(S.[Name]) = 4

SELECT *
FROM Students S
WHERE LTRIM(S.[Name]) = 'Leyla'

SELECT *
FROM Students S
WHERE RTRIM(S.[Name]) = 'Gulzar'


SELECT *
FROM Students S
WHERE TRIM(S.[Name]) = 'Fidan'


SELECT S.[Name] , CHARINDEX('a',S.[Name])
FROM Students S


SELECT S.[Name] , PATINDEX('_a%',S.[Name])
FROM Students S


SELECT LEFT(S.[Name],3)
FROM Students S


SELECT RIGHT(S.[Name],3)
FROM Students S

SELECT SUBSTRING(S.[Name],1,3)
FROM Students S


SELECT REVERSE(S.[Name])
FROM Students S

SELECT CONCAT(S.[Name],' ',Surname) AS FIO
FROM Students S


SELECT LOWER(S.[Name]) AS FIO
FROM Students S

SELECT *
FROM Students S
WHERE S.[Name] = LOWER('FARID')



SELECT T.[Name] , T.Surname , ROUND(T.Salary,2)
FROM Teachers T

SELECT ISNUMERIC(T.[Name]) 
FROM Teachers T

SELECT ABS(T.Salary) 
FROM Teachers T


SELECT CEILING(T.Salary) 
FROM Teachers T   -- до верхней границе 

SELECT FLOOR(T.Salary) 
FROM Teachers T  -- до нижней границе

SELECT SQUARE(T.Salary) 
FROM Teachers T

SELECT SQRT(T.Salary) 
FROM Teachers T

SELECT RAND()

	
SELECT GETDATE() -- datetime

SELECT SYSDATETIME()  -- datetime2


SELECT GETUTCDATE()    -- datetime

SELECT SYSUTCDATETIME()   -- datetime2

SELECT DAY('2024-06-22')
SELECT DAY(GETDATE())

SELECT MONTH('2024-06-22')
SELECT MONTH(GETDATE())

SELECT YEAR('2024-06-22')
SELECT YEAR(GETDATE())

SELECT DATENAME(MONTH,GETDATE())
SELECT DATENAME(MONTH,'2024-09-22')

SELECT DATENAME(weekday ,GETDATE())

SELECT DATENAME(tzoffset,GETDATE())

SELECT DATEADD(day, 30, GETDATE()) 


SELECT DATEDIFF(day, '2000-10-19', GETDATE())  


SELECT EOMONTH(GETDATE())


SELECT (CAST(T.Salary AS nvarchar) + ' AZN') AS Salary
FROM Teachers T


SELECT CONVERT(nvarchar,GETDATE(),1)
SELECT CONVERT(nvarchar,GETDATE(),14)
SELECT CONVERT(nvarchar,GETDATE(),8)