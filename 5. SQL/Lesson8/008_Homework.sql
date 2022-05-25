USE master
GO

DROP DATABASE MyFunkDB
GO

CREATE DATABASE MyFunkDB
ON
(
	NAME = 'MyFunkDB',
	FILENAME = 'D:\Homework\Lesson8\MyFunkDB.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogMyJoinsDB',
	FILENAME = 'D:\Homework\Lesson8\LogMyFunkDB.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS 
GO

USE MyFunkDB
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

CREATE PROC PhoneAndAddress
AS 
	SELECT FName, MName, LName, Phone, 
		   (SELECT [Address] FROM PersInfo WHERE Employees.EmpID = PersInfo.EmpID) AS [Address]
FROM Employees;
GO

EXEC PhoneAndAddress;
GO

---------------------------------------------------------------------------------------------

CREATE FUNCTION GetFName(@EmpID int)
RETURNS nvarchar(18)
AS
BEGIN
	RETURN (SELECT FName FROM Employees AS Emp WHERE Emp.EmpID = @EmpID)
END;
GO

CREATE FUNCTION GetMName(@EmpID int)
RETURNS nvarchar(18)
AS
BEGIN
	RETURN (SELECT MName FROM Employees AS Emp WHERE Emp.EmpID = @EmpID)
END;
GO

CREATE FUNCTION GetLName(@EmpID int)
RETURNS nvarchar(18)
AS
BEGIN
	RETURN (SELECT LName FROM Employees AS Emp WHERE Emp.EmpID = @EmpID)
END;
GO

CREATE FUNCTION GetPhone(@EmpID int)
RETURNS nvarchar(18)
AS
BEGIN
	RETURN (SELECT Phone FROM Employees AS Emp WHERE Emp.EmpID = @EmpID)
END;
GO

---------------------------------------------------------------------------------------------

CREATE FUNCTION GetInfoByMaritalStatus(@MaritalStatus nchar(9))
RETURNS TABLE
AS
RETURN(SELECT 
			 dbo.GetFName(PersInfo.EmpID) AS FName,
			 dbo.GetMName(PersInfo.EmpID) AS MName,
			 dbo.GetLName(PersInfo.EmpID) AS LName,
			 dbo.GetPhone(PersInfo.EmpID) AS Phone, BirthDate
	   FROM PersInfo WHERE MaritalStatus = @MaritalStatus);
GO

DECLARE @MarStat nchar(9) = 'Unmarried';

SELECT * FROM GetInfoByMaritalStatus(@MarStat);

---------------------------------------------------------------------------------------------

CREATE FUNCTION GetInfoByPost(@Post nvarchar(15))
RETURNS TABLE
AS 
RETURN (SELECT 
			  dbo.GetFName(ProfInfo.EmpID) AS FName,
			  dbo.GetMName(ProfInfo.EmpID) AS MName,
		      dbo.GetLName(ProfInfo.EmpID) AS LName,
			  dbo.GetPhone(ProfInfo.EmpID) AS Phone,
			  (SELECT BirthDate FROM PersInfo WHERE PersInfo.EmpID = ProfInfo.EmpID) AS BirthDate
FROM ProfInfo WHERE Post = @Post);
GO

DECLARE @Post nvarchar(15) = 'Manager';

SELECT * FROM GetInfoByPost(@Post);
