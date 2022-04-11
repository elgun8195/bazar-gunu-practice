CREATE DATABASE Course 

USE  Course

CREATE TABLE Students(
Id int primary key identity,
[Name] nvarchar(50) NOT NULL,
Surname nvarchar(50) DEFAULT ('XXX'),
Age tinyint NOT NULL,
Point int NOT NULL
)

DROP TABLE Students

INSERT INTO Students
VALUES('Ahmed','Ahmedov',19,77)

INSERT INTO Students (Name,Age,Point)
VALUES('Nergiz',19,100)

UPDATE Students Set Surname='susbe' WHERE Surname='XXX'

UPDATE Students Set Point=22 WHERE Id=1

SELECT * FROM Students WHERE Point>70 AND Point<90

SELECT Name,Surname FROM Students WHERE Age<21

SELECT * FROM Students WHERE Point>70 AND Point<90 ORDER BY Point DESC

ALTER TABLE Students
ADD Averagepoint FLOAT CHECK(AveragePoint BETWEEN 0 AND 100)