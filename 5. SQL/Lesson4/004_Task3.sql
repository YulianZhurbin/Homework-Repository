USE master
GO

DROP DATABASE ArmamentDepot
GO

CREATE DATABASE ArmamentDepot
ON
(
	NAME = 'ArmamentDepot',
	FILENAME = 'D:\Homework\Lesson4\ArmamentDepot.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogArmamentDepot',
	FILENAME = 'D:\Homework\Lesson4\LogArmamentDepot.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS

USE ArmamentDepot
GO

EXEC sp_helpdb ArmamentDepot

CREATE TABLE Takers
(
	ID int NOT NULL IDENTITY PRIMARY KEY,
	Name varchar(40) NOT NULL,
	Office smallint NULL,
	Platoon smallint NOT NULL
)

CREATE TABLE Givers
(
	ID int NOT NULL IDENTITY PRIMARY KEY,
	Name varchar(40) NOT NULL,
	[Rank] varchar(30) NOT NULL,
	Gun varchar(10) NOT NULL
)

CREATE TABLE Acts
(
	ID int NOT NULL IDENTITY PRIMARY KEY,
	TakerID int NOT NULL 
		FOREIGN KEY REFERENCES Takers(ID),
	GiverID int NOT NULL
		FOREIGN KEY REFERENCES Givers(ID)
)

INSERT INTO Takers
VALUES
('Петров В.А.', 205, 222),
('Лодарев П.С.', 221, 232),
('Леонтьев К.В.', 201, 212),
('Духов Р.М.', NULL, 200)

INSERT INTO Givers
VALUES
('Буров О.С.', 'Майор', 'АК-47'),
('Рыбаков Н.Г.','Майор', 'Глок20'),
('Деребанов В.Я.','Подполковник','АК-74')

INSERT INTO Acts
VALUES
(1,1),
(1,2),
(2,3),
(2,2),
(3,1),
(3,2),
(4,1)


SELECT * FROM Takers 
SELECT * FROM Givers 
SELECT * FROM Acts