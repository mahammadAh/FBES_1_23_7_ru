CREATE DATABASE Library

USE Library

CREATE TABLE Authors (
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
Surname VARCHAR(50) NOT NULL
)

CREATE TABLE Books (
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(100) NOT NULL,
PageCount INT ,
AuthorId INT REFERENCES Authors (Id)
)


INSERT INTO Authors VALUES('Rey','Bredbery')
INSERT INTO Authors VALUES('Lev','Tolstoy')
INSERT INTO Authors VALUES('Nizami','Gencavi')

INSERT INTO Books VALUES('Vino iz Oduvancikov', 432 , 1)
INSERT INTO Books VALUES('Voyna i Mir',3745,2)
INSERT INTO Books VALUES('7 Gozel',345,3)

SELECT * FROM Authors


CREATE PROCEDURE getPageCount
@BookName VARCHAR(50),
@PageCount INT OUTPUT
AS
BEGIN
SET @PageCount = (SELECT PageCount FROM Books WHERE Name = @BookName );
END