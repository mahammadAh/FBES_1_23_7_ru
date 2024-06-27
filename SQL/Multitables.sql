CREATE DATABASE University

USE University

CREATE TABLE Teachers (
[Name] VARCHAR(50),
BirthDate date,
Department VARCHAR(50),
Phone VARCHAR(20),
[Group] VARCHAR(20),
[Subject] VARCHAR(50),
)



INSERT INTO Teachers 
VALUES 
('Anar Abbasov','1998-07-23','IT','055-454-33-33','FBES_23_1','IT Essential'),
('Cavid Atamanoglanov','1999-05-31','Programming','070-354-11-23','FBES_12_14','C#'),
('Lali Kerimli','1997-04-21','Design','050-122-95-65','DSG_33_1','Ilustrator'),
('Ali Novruzov','2000-08-11','IT','055-454-33-33','FBES_12_14','IT Essential'),
('Namik Cavadov','1996-08-26','Programming','070-354-11-23','FBES_22_11','C++'),
('Anar Abbasov','1998-07-23','IT','055-454-33-33','DevOps_223','Kubernets'),
('Natik Aliyev','1999-07-21','Programming','070-354-11-23','PRG_87_3','ASP.NET'),
('Lali Kerimli','1997-04-23','Design','050-122-95-65','DSG_45_1','Photoshop'),
('Ali Novruzov','2000-08-11','IT','055-454-33-33','PRG_87_3','Network')


SELECT *
FROM Teachers

DROP TABLE Teachers


CREATE TABLE Departments 
(
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(50) NOT NULL,
Phone VARCHAR(20) NOT NULL
)

CREATE TABLE Teachers 
(
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(50) NOT NULL,
Surname VARCHAR (50) NOT NULL,
BirthDate DATE NOT NULL,
DepartmentId INT FOREIGN KEY REFERENCES Departments (Id)
)


CREATE TABLE Groups 
(
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(50) NOT NULL,
)


CREATE TABLE Subjects 
(
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] VARCHAR(50) NOT NULL,
)


CREATE TABLE TeachersToGroups
(
Id INT IDENTITY(1,1) PRIMARY KEY,
TeacherId INT FOREIGN KEY REFERENCES Teachers (Id),
GroupId INT FOREIGN KEY REFERENCES Groups (Id),
)

CREATE TABLE TeachersToSubjects
(
Id INT IDENTITY(1,1) PRIMARY KEY,
TeacherId INT FOREIGN KEY REFERENCES Teachers (Id),
SubjectId INT FOREIGN KEY REFERENCES Subjects (Id),
)



INSERT INTO Teachers 
VALUES 
('Anar Abbasov','1998-07-23','IT','055-454-33-33','FBES_23_1','IT Essential'),
('Cavid Atamanoglanov','1999-05-31','Programming','070-354-11-23','FBES_12_14','C#'),
('Lali Kerimli','1997-04-21','Design','050-122-95-65','DSG_33_1','Ilustrator'),
('Ali Novruzov','2000-08-11','IT','055-454-33-33','FBES_12_14','IT Essential'),
('Namik Cavadov','1996-08-26','Programming','070-354-11-23','FBES_22_11','C++'),
('Anar Abbasov','1998-07-23','IT','055-454-33-33','DevOps_223','Kubernets'),
('Natik Aliyev','1999-07-21','Programming','070-354-11-23','PRG_87_3','ASP.NET'),
('Lali Kerimli','1997-04-23','Design','050-122-95-65','DSG_45_1','Photoshop'),
('Ali Novruzov','2000-08-11','IT','055-454-33-33','PRG_87_3','Network')


INSERT INTO Departments 
VALUES
('IT','055-454-33-33'),
('Programming','070-354-11-23'),
('Design','050-122-95-65')


INSERT INTO Teachers 
VALUES
('Samir','Aliyev','2000-08-11', (SELECT Id FROM Departments WHERE [Name] = 'IT'))
('Anar','Abbasov','1998-07-23', (SELECT Id FROM Departments WHERE [Name] = 'IT')),
('Cavid','Atamanoglanov','1999-05-31', (SELECT Id FROM Departments WHERE [Name] = 'Programming')),
('Lali','Kerimli','1997-04-21', (SELECT Id FROM Departments WHERE [Name] = 'Design')),
('Namik','Cavadov','1996-08-26', (SELECT Id FROM Departments WHERE [Name] = 'Programming')),
('Natik','Aliyev','1999-07-21', (SELECT Id FROM Departments WHERE [Name] = 'Programming')),
('Ali','Novruzov','2000-08-11', (SELECT Id FROM Departments WHERE [Name] = 'IT'))



INSERT INTO Groups 
VALUES
('FBES_23_1'),
('FBES_12_14'),
('DSG_33_1'),
('FBES_22_11'),
('DevOps_223'),
('PRG_87_3'),
('DSG_45_1')



INSERT INTO Subjects 
VALUES
('IT Essential'),
('C#'),
('Ilustrator'),
('C++'),
('Kubernets'),
('ASP.NET'),
('Photoshop'),
('Network')




INSERT INTO TeachersToGroups 
VALUES
((SELECT Id FROM Teachers WHERE [Name] = 'Anar'),(SELECT Id FROM Groups WHERE [Name] = 'FBES_23_1')),
((SELECT Id FROM Teachers WHERE [Name] = 'Cavid'),(SELECT Id FROM Groups WHERE [Name] = 'FBES_12_14')),
((SELECT Id FROM Teachers WHERE [Name] = 'Lali'),(SELECT Id FROM Groups WHERE [Name] = 'DSG_33_1')),
((SELECT Id FROM Teachers WHERE [Name] = 'Ali'),(SELECT Id FROM Groups WHERE [Name] = 'FBES_12_14')),
((SELECT Id FROM Teachers WHERE [Name] = 'Namik'),(SELECT Id FROM Groups WHERE [Name] = 'FBES_22_11')),
((SELECT Id FROM Teachers WHERE [Name] = 'Anar'),(SELECT Id FROM Groups WHERE [Name] = 'DevOps_223')),
((SELECT Id FROM Teachers WHERE [Name] = 'Natik'),(SELECT Id FROM Groups WHERE [Name] = 'PRG_87_3')),
((SELECT Id FROM Teachers WHERE [Name] = 'Lali'),(SELECT Id FROM Groups WHERE [Name] = 'DSG_45_1')),
((SELECT Id FROM Teachers WHERE [Name] = 'Ali'),(SELECT Id FROM Groups WHERE [Name] = 'PRG_87_3'))


INSERT INTO TeachersToSubjects 
VALUES
((SELECT Id FROM Teachers WHERE [Name] = 'Anar'),(SELECT Id FROM Subjects WHERE [Name] = 'IT Essential')),
((SELECT Id FROM Teachers WHERE [Name] = 'Anar'),(SELECT Id FROM Subjects WHERE [Name] = 'Kubernets')),
((SELECT Id FROM Teachers WHERE [Name] = 'Cavid'),(SELECT Id FROM Subjects WHERE [Name] = 'C#')),
((SELECT Id FROM Teachers WHERE [Name] = 'Lali'),(SELECT Id FROM Subjects WHERE [Name] = 'Ilustrator')),
((SELECT Id FROM Teachers WHERE [Name] = 'Lali'),(SELECT Id FROM Subjects WHERE [Name] = 'Photoshop')),
((SELECT Id FROM Teachers WHERE [Name] = 'Ali'),(SELECT Id FROM Subjects WHERE [Name] = 'IT Essential')),
((SELECT Id FROM Teachers WHERE [Name] = 'Ali'),(SELECT Id FROM Subjects WHERE [Name] = 'Network')),
((SELECT Id FROM Teachers WHERE [Name] = 'Namik'),(SELECT Id FROM Subjects WHERE [Name] = 'C++')),
((SELECT Id FROM Teachers WHERE [Name] = 'Natik'),(SELECT Id FROM Subjects WHERE [Name] = 'ASP.NET'))



CREATE TABLE TeachersToGroupsToSubject
(
Id INT IDENTITY(1,1) PRIMARY KEY,
TeacherId INT FOREIGN KEY REFERENCES Teachers (Id),
GroupId INT FOREIGN KEY REFERENCES Groups (Id),
SubjectId INT FOREIGN KEY REFERENCES Subjects (Id),
)

INSERT INTO TeachersToGroupsToSubject 
VALUES
((SELECT Id FROM Teachers WHERE [Name] = 'Anar'),(SELECT Id FROM Groups WHERE [Name] = 'FBES_23_1'),(SELECT Id FROM Subjects WHERE [Name] = 'IT Essential')),
((SELECT Id FROM Teachers WHERE [Name] = 'Cavid'),(SELECT Id FROM Groups WHERE [Name] = 'FBES_12_14'),(SELECT Id FROM Subjects WHERE [Name] = 'C#')),
((SELECT Id FROM Teachers WHERE [Name] = 'Lali'),(SELECT Id FROM Groups WHERE [Name] = 'DSG_33_1'),(SELECT Id FROM Subjects WHERE [Name] = 'Ilustrator')),
((SELECT Id FROM Teachers WHERE [Name] = 'Ali'),(SELECT Id FROM Groups WHERE [Name] = 'FBES_12_14'),(SELECT Id FROM Subjects WHERE [Name] = 'IT Essential')),
((SELECT Id FROM Teachers WHERE [Name] = 'Namik'),(SELECT Id FROM Groups WHERE [Name] = 'FBES_22_11'),(SELECT Id FROM Subjects WHERE [Name] = 'C++')),
((SELECT Id FROM Teachers WHERE [Name] = 'Anar'),(SELECT Id FROM Groups WHERE [Name] = 'DevOps_223'),(SELECT Id FROM Subjects WHERE [Name] = 'Kubernets')),
((SELECT Id FROM Teachers WHERE [Name] = 'Natik'),(SELECT Id FROM Groups WHERE [Name] = 'PRG_87_3'),(SELECT Id FROM Subjects WHERE [Name] = 'ASP.NET')),
((SELECT Id FROM Teachers WHERE [Name] = 'Lali'),(SELECT Id FROM Groups WHERE [Name] = 'DSG_45_1'),(SELECT Id FROM Subjects WHERE [Name] = 'Photoshop')),
((SELECT Id FROM Teachers WHERE [Name] = 'Ali'),(SELECT Id FROM Groups WHERE [Name] = 'PRG_87_3'),(SELECT Id FROM Subjects WHERE [Name] = 'Network'))




SELECT T.Name , T.Surname , S.Name 
FROM TeachersToSubjects TtoS
--INNER JOIN
JOIN Teachers T ON T.Id = TtoS.TeacherId
JOIN Subjects S ON S.Id = TtoS.SubjectId

--OUTER JOIN 

SELECT T.Name , T.Surname , TtoS.SubjectId
FROM TeachersToSubjects TtoS
--INNER JOIN
RIGHT JOIN Teachers T ON T.Id = TtoS.TeacherId


SELECT *
FROM Teachers



SELECT T.Name , T.Surname , T.BirthDate , D.Name , D.Phone , G.Name , S.Name 
FROM Teachers T
JOIN Departments D ON D.Id = T.DepartmentId
JOIN TeachersToGroupsToSubject TtoGtoS ON TtoGtoS.TeacherId = T.Id
JOIN Subjects S ON TtoGtoS.SubjectId = S.Id
JOIN Groups G ON TtoGtoS.GroupId = G.Id






