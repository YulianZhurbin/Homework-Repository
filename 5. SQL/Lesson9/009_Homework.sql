USE master
GO

DROP DATABASE MyFunkDB
GO

CREATE DATABASE MyFunkDB
ON
(
	NAME = 'MyFunkDB',
	FILENAME = 'D:\Homework\Lesson9\MyFunkDB.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogMyJoinsDB',
	FILENAME = 'D:\Homework\Lesson9\LogMyFunkDB.ldf',
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
	Phone nchar(11) NOT NULL
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

DROP TRIGGER IsCorrectPost;
GO

CREATE TRIGGER IsCorrectPost
	ON ProfInfo
	FOR INSERT, UPDATE
AS
	IF EXISTS
	(
		SELECT Post FROM Inserted 
		WHERE Post NOT IN ('CEO','Manager','Worker')
		
	)
	BEGIN
		PRINT 'Incorrect post! Only "CEO", "Manager", "Worker" are allowed';
		ROLLBACK TRANSACTION
	END
GO

INSERT Employees
VALUES
(7,'Svetlana','Viktorovna','Khinshtein','89999999999')
GO

INSERT ProfInfo	--ошибка
VALUES
(7,'Accountant', 3000)
GO

UPDATE ProfInfo --нет ошибки
SET Post = 'CEO'
WHERE EmpID = 6;

---------------------------------------------------------------------------------------------

DROP TRIGGER OnDeletion
GO

CREATE TRIGGER OnDeletion
	ON PersInfo
	FOR DELETE 
AS
    RAISERROR('You do not have an appropriate access level', 1, 17)
	ROLLBACK TRAN
GO

DELETE FROM PersInfo --ошибка
WHERE MaritalStatus = 'Married';
GO

---------------------------------------------------------------------------------------------
-- Триггер почему-то не работает корректно 

DROP TRIGGER IsDoubleEdited;
GO

CREATE TRIGGER IsDoubleEdited
	ON Employees
	FOR INSERT 
AS
	IF EXISTS
	(
		SELECT FName,MName,LName,Phone FROM Employees
		INTERSECT
		SELECT FName,MName,LName,Phone FROM Inserted
	)
	BEGIN
		RAISERROR('This employee is already added in the database', 1, 16);
		ROLLBACK TRANSACTION
	END
GO

INSERT Employees --ошибка
VALUES
(8,'Andrey','Fedorovich','Ivanov','81111111111'),
(9,'Irina','Olegovna','Pevchikh','89999999999')
GO

INSERT Employees --нет ошибки (НО ОНА ПОЧЕМУ-ТО ЕСТЬ)
VALUES
(15,'Katrina',NULL,'James','89160000555');
GO

---------------------------------------------------------------------------------------------
--							             Task 5   
---------------------------------------------------------------------------------------------

BEGIN TRAN;

DECLARE @Flag bit = 0; -- 0 -> ROLLBACK TRAN; 1 -> COMMIT TRAN

INSERT Employees
VALUES
(10, 'Stanislav', 'Sergeevich', 'Boyko', '89279999999'),
(11, 'Elizaveta', 'Germanovna', 'Miller', '89278888888');

UPDATE ProfInfo 
SET Post = 'System Administrator'
WHERE EmpID = 3;

INSERT Employees
VALUES
(12, 'Nadezhda', 'Vasilievna', 'Nikitina', '89273333333')

IF (@Flag = 0)
	BEGIN
		ROLLBACK TRAN;
	END
ELSE
	BEGIN
		COMMIT TRAN;
	END