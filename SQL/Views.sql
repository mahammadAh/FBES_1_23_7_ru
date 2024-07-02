CREATE View ShowAllOrders (Student , Book)
AS 
SELECT S.[Name] , B.[Name]
FROM Orders O
JOIN Students S ON O.StudentId = S.Id
JOIN Books B ON O.BookId = B.Id



SELECT * FROM ShowAllOrders

UPDATE ShowAllOrders SET Student = 'DAVID' WHERE Student = 'David'


SELECT * FROM Students


