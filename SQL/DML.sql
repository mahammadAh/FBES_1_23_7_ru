USE Jobs

SELECT * 
FROM MOCK_DATA

INSERT INTO MOCK_DATA (id,first_name,last_name,email,gender,Company,Job) 
VALUES (1001,'Ayaz','Bagirzade','ayaz@gmail.com','Male','KFC','Cashier')

INSERT INTO MOCK_DATA (id,first_name,last_name,email,gender,Company) 
VALUES (1001,'Nazim','Dovlatov','nazim@gmail.com','Male','Steam')


SELECT first_name , last_name , email
INTO Basic_Data
FROM MOCK_DATA

SELECT *
FROM Basic_Data



SELECT  *
FROM MOCK_DATA

SELECT TOP 5 *
FROM MOCK_DATA

SELECT TOP 40 PERCENT *
FROM MOCK_DATA


SELECT * 
FROM MOCK_DATA
WHERE gender = 'Female'

SELECT * 
FROM MOCK_DATA
ORDER BY first_name , last_name

SELECT DISTINCT Job
FROM MOCK_DATA
WHERE gender = 'Female'



SELECT  md.Job, COUNT(email) AS [Count]
FROM MOCK_DATA md
--WHERE Job LIKE '%Developer%'
GROUP BY Job
HAVING COUNT(email) > 10
ORDER BY Count DESC


