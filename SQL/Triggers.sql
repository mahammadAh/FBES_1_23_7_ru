--USE BookCenter


CREATE TRIGGER TestTriger
ON Books
AFTER INSERT
AS 
PRINT 'inserted!'

DROP TRIGGER TestTriger


CREATE TRIGGER CountTrigger
ON Books
AFTER INSERT
AS
SELECT Count([Name]) FROM Books


DROP TRIGGER CountTrigger

INSERT INTO Books VALUES('Vino iz Oduvancikov','Rey Bredberi',8)


CREATE TRIGGER CheckTrigger
ON Books
INSTEAD OF INSERT
AS 
PRINT 'checked'

DROP TRIGGER CheckTrigger


INSERT INTO Books VALUES('Marsianskiye xroniki','Rey Bredberi',10)

SELECT * FROM Books


CREATE TRIGGER UpdateTrigger
ON Books
INSTEAD OF UPDATE
AS 
UPDATE Books SET [Name] = '49 Zakonov vlasti' WHERE Id = 6

DROP TRIGGER UpdateTrigger

UPDATE Books SET [Name] = 'Vodka iz oduvancikov' WHERE Id = 9




CREATE TRIGGER UpdateTrigger
ON Books
AFTER UPDATE
AS
SELECT * FROM deleted
SELECT * FROM inserted 

DROP TRIGGER UpdateTrigger


UPDATE Books SET [Name] = 'Viski iz oduvancikov' WHERE Id = 9


CREATE TRIGGER InsertTrigger
ON Books
AFTER INSERT
AS
SELECT * FROM inserted 

DROP TRIGGER InsertTrigger

INSERT INTO Books VALUES('V odno kasaniye','Farman Gadjiyev',13)


CREATE TRIGGER CheckPrice
ON Books
INSTEAD OF INSERT
AS 
BEGIN
IF (SELECT Price FROM inserted) > 100
   BEGIN
   RAISERROR (14000,1,1)
   END
ELSE 
INSERT INTO Books VALUES((SELECT [Name] FROM inserted),(SELECT Author FROM inserted),(SELECT Price FROM inserted))
END

DROP TRIGGER CheckPrice

SELECT * FROM Books

INSERT INTO Books VALUES('Robinzon Kruzo','Farman Gadjiyev',180)

select * from sys.messages