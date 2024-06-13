CREATE DATABASE Anbar


--USE Anbar
--CREATE TABLE Products 
--(
--Id INT ,
--ProductName VARCHAR(50),
--Price INT
--PRIMARY KEY(Id,ProductName)
--)


--USE Anbar
--CREATE TABLE Products 
--(
--Id INT PRIMARY KEY ,
--ProductName VARCHAR(50),
--Price INT,
--BarCode VARCHAR(40) UNIQUE
----UNIQUE(BarCode,Price)
--)

USE Anbar
CREATE TABLE Categorie 
(
Id INT PRIMARY KEY IDENTITY (1,1),
[Name]  VARCHAR(50)
)



USE Anbar
CREATE TABLE Products 
(
Id INT PRIMARY KEY IDENTITY (1,5),
ProductName VARCHAR(50),
Price INT NOT NULL,
BarCode VARCHAR(40) UNIQUE, --CONSTRAINT UN_BarCode_Unique UNIQUE,
[ExpireDate] DATETIME ,
[Weight] INT 
CHECK ([Weight] < 100 AND [Weight] > 50),
CatigorieId INT
FOREIGN KEY (CatigorieId) REFERENCES Categorie (Id) -- ON DELETE | ON UPDATE       CASCADE | NO ACTION 
)



--DROP DATABASE Anbar
--USE Anbar
DROP TABLE Products



ALTER TABLE Products
ADD Kkal INT

ALTER TABLE Products
DROP UN_BarCode_Unique

ALTER TABLE Products
ALTER COLUMN ProductName VARCHAR(100)


SELECT *
FROM Products



--INSERT INTO Categorie([Name]) VALUES ('Fruit')
--INSERT INTO Categorie([Name]) VALUES ('Vegetables')
--INSERT INTO Categorie([Name]) VALUES ('Candy')
--INSERT INTO Categorie([Name]) VALUES ('Juice')

SELECT *
FROM Categorie

USE Anbar
INSERT INTO Products (ProductName,Price,BarCode,[ExpireDate],[Weight],CatigorieId) VALUES ('Apple',3,'KKSD-2443F-4TD','2024-06-25',55,2)
INSERT INTO Products (ProductName,Price,BarCode,[ExpireDate],[Weight],CatigorieId) VALUES ('OranggeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeDDDDDDDDDDDDDDDDDDDDDDDDD',3,'KKSD-2442F-4TD','2024-06-25',55,2)
INSERT INTO Products (ProductName,Price,BarCode,[ExpireDate],[Weight],CatigorieId) VALUES ('Apple',3,'KKSD-2443F-4TD','2024-06-25',55,2)



ALTER TABLE Products
DROP UN_BarCode_Unique



--ALTER TABLE Products
--ALTER COLUMN ProductName VARCHAR(20)

SELECT *
FROM Products