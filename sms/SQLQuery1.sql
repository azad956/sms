USE [MobileDb]
CREATE TABLE mobileTAble
(
Id int IDENTITY (1,1)  PRIMARY KEY,
ModelName varchar(100),
IME varchar(15),
Price float 


SELECT * FROM mobileTAble
INSERT INTO mobileTAble (ModelName, IME, Price) VALUES ('Nokia', '123451234512345', 50000) 
INSERT INTO mobileTAble (ModelName, IME, Price) VALUES ('OPPO', '123451234512341', 4000) 
INSERT INTO mobileTAble (ModelName, IME, Price) VALUES ('Nokia', '123451234512346', 2000) 

UPDATE mobileTAble SET Price=5000 WHERE Id=3

Delete FROM mobileTAble WHERE Id>3

SELECT * FROM mobileTAble WHERE IME = '123451234512341'
SELECT * FROM mobileTAble WHERE price BETWEEN 2000 AND  4000
SELECT * FROM mobileTAble WHERE price BETWEEN 1 AND  5000