--CREATE DATABASE BookCenter 

--USE BookCenter

CREATE TABLE Books (
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(50) NOT NULL,
Author NVARCHAR(50) NOT NULL,
Price DECIMAL NOT NULL
)

CREATE TABLE Students (
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) NOT NULL,
GroupName NVARCHAR(20)NOT NULL,
)

CREATE TABLE Orders (
Id INT IDENTITY(1,1) PRIMARY KEY,
StudentId INT FOREIGN KEY REFERENCES Students (Id),
BookId INT FOREIGN KEY REFERENCES Books (Id),
TotalPrice DECIMAL NOT NULL
)


INSERT INTO Books ([Name],Author,Price) 
VALUES ('1984','Jorj Oruel',8),
 ('Qraf Monte Kristo','Aleksandr Dyuma',11),
('Portret Doriana Grey','Oskar Uald',9),
('Qosudar','Makiavelli',13),
('Vlastelin Kolec','Tolkien',15),
('48 Zakonov vlasti','Robert Qrin',17),
('Harry Potter',' Rouling',17)



INSERT INTO Students ([Name],Surname,GroupName) 
VALUES ('Anvar','Sadiq','222'),
 ('Dinara','Qasimova','222'),
 ('Faxri','Gozalov','TK102'),
 ('Alyona','Vishevetskaya','221'),
 ('David','Sladkov','TK102'),
 ('Elnur','Aliyev','705'),
 ('Farman','Gadjiyev','DB212'),
 ('Murad','Nurmamedli','813'),
 ('Ayaz','Bagirzade','682SI')




 INSERT INTO Orders (StudentId,BookId,TotalPrice) 
 VALUES ( 24 , (SELECT Id FROM Books WHERE [Name] = 'Portret Doriana Grey'),19)




 SELECT *
 FROM Orders
 WHERE StudentId > SOME (SELECT Id FROM Students WHERE [Name] LIKE '%a%')   -- 1 , 2 , 3 , 4, 5 ,7 , 8, 9


 SELECT *
 FROM Orders
 WHERE StudentId = SOME (SELECT Id FROM Students WHERE [Name] LIKE '%a%') 


 SELECT *
 FROM Orders
 WHERE TotalPrice >= ( SELECT MAX(TotalPrice) FROM Orders )



  
 SELECT *
 FROM Orders
 WHERE EXISTS (SELECT * FROM Books WHERE TotalPrice = Books.Price)


   
 SELECT *
 FROM Orders
 WHERE TotalPrice = ANY (SELECT Price FROM Books)

-- Коррелирующие подзапросы

-- Не Коррелирующие подзапросы


 SELECT *
 FROM Students

 SELECT *
 FROM Books

 SELECT * 
 FROM Orders