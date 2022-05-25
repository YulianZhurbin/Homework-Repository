USE master
GO

DROP DATABASE MyJoinsDB
GO

CREATE DATABASE MyJoinsDB
ON
(
	NAME = 'MyJoinsDB',
	FILENAME = 'D:\Homework\Lesson7\MyJoinsDB.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogMyJoinsDB',
	FILENAME = 'D:\Homework\Lesson7\LogMyJoinsDB.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS 
GO

USE MyJoinsDB
GO

CREATE TABLE Employees
(
	EmpID int NOT NULL PRIMARY KEY,
	FName nvarchar(18) NOT NULL,
	MName nvarchar(18) NULL,
	LName nvarchar(18) NOT NULL,
	Phone nchar(11) NOT NULL UNIQUE
	CHECK (Phone LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')     
)

CREATE TABLE ProfInfo
(
	EmpID int NOT NULL PRIMARY KEY 
		FOREIGN KEY REFERENCES Employees(EmpID),
	Post nvarchar(15) NOT NULL,
	Salary money NOT NULL
)

CREATE TABLE PersInfo
(
	EmpID int NOT NULL PRIMARY KEY
		FOREIGN KEY REFERENCES Employees(EmpID),
	MaritalStatus nchar(9) DEFAULT 'Unmarried',
	BirthDate Date NOT NULL,
	[Address] nvarchar(50) NULL
)

GO

INSERT Employees
VALUES
(1,'Andrey','Fedorovich','Ivanov','81111111111'),
(2,'Vasily','Nikolaevich','Tyschenko','82222222222'),
(3,'Farkhat','Timurovich','Urazaliev','83333333333'),
(4,'Timofey','Sergeevich','Portnov','84444444444'),
(5,'Michael',NULL, 'Jones','85555555555'),
(6,'Oleg',NULL, 'Skvortsov','86666666666');
GO

INSERT ProfInfo
VALUES
(1, 'CEO', 5000),
(2, 'Manager', 3000),
(3, 'Manager', 2800),
(4, 'Worker', 1500),
(5, 'Worker', 2500),
(6, 'Worker', 1000) 
GO

INSERT PersInfo
VALUES
(1,'Married','12/12/1980','str 9, City01'),
(2,'Married','10/06/1979','str 9, City01'),
(3,'Married','04/05/1991','str 1, City01'),
(4,DEFAULT,'09/11/1994','str 2, City01'),
(5,'Unmarried','11/02/1996',NULL),
(6,'Married','01/01/1998',NULL)
GO

SELECT * FROM Employees
SELECT * FROM ProfInfo
SELECT * FROM PersInfo
GO

---------------------------------------------------------------------------------------------

CREATE VIEW PhoneAndAddress
AS SELECT FName, MName, LName, Phone, 
	   (SELECT [Address] FROM PersInfo WHERE Employees.EmpID = PersInfo.EmpID) AS [Address]
FROM Employees;
GO

SELECT * FROM PhoneAndAddress;

---------------------------------------------------------------------------------------------

CREATE VIEW UnmarriedPersonsInfo
AS SELECT 
	  (SELECT FName FROM Employees AS Emp WHERE Emp.EmpID = PersInfo.EmpID) AS FName,
	  (SELECT MName FROM Employees AS Emp WHERE Emp.EmpID = PersInfo.EmpID) AS MName,
	  (SELECT LName FROM Employees AS Emp WHERE Emp.EmpID = PersInfo.EmpID) AS LName,
	  (SELECT Phone FROM Employees AS Emp WHERE Emp.EmpID = PersInfo.EmpID) AS Phone, BirthDate
FROM PersInfo WHERE MaritalStatus = 'Unmarried';
GO

SELECT * FROM UnmarriedPersonsInfo;

---------------------------------------------------------------------------------------------

CREATE VIEW ManagersInfo
AS SELECT 
	  (SELECT FName FROM Employees AS Emp WHERE Emp.EmpID = ProfInfo.EmpID) AS FName,
	  (SELECT MName FROM Employees AS Emp WHERE Emp.EmpID = ProfInfo.EmpID) AS MName,
	  (SELECT LName FROM Employees AS Emp WHERE Emp.EmpID = ProfInfo.EmpID) AS LName,
	  (SELECT Phone FROM Employees AS Emp WHERE Emp.EmpID = ProfInfo.EmpID) AS Phone, 
	  (SELECT BirthDate FROM PersInfo WHERE PersInfo.EmpID = ProfInfo.EmpID) AS BirthDate
FROM ProfInfo WHERE Post = 'Manager';
GO

SELECT * FROM ManagersInfo;