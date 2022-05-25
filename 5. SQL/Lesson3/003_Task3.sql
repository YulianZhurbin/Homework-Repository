USE master
GO

DROP DATABASE WholesaleStore
GO

CREATE DATABASE WholesaleStore
ON
(
	NAME = 'WholesaleStore',
	FILENAME = 'D:\WholesaleStore.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogWholesaleStore',
	FILENAME = 'D:\LogWholesaleStore.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS

USE WholesaleStore
GO

EXEC sp_helpdb WholesaleStore

CREATE TABLE Employees
(
	EmployeeID int IDENTITY NOT NULL
		PRIMARY KEY,
	FName nvarchar(15) NOT NULL,
	LName nvarchar(15) NOT NULL,
	Salary money NOT NULL,
	HireDate date NOT NULL
)

CREATE TABLE Providers
(
	ProviderID int IDENTITY NOT NULL
		PRIMARY KEY,
	Name nvarchar(20) NOT NULL UNIQUE,
	Product nvarchar(15) NOT NULL,
	[Address] nvarchar(30) NOT NULL,
	Phone char(11) NOT NULL CHECK 
		(Phone LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)

CREATE TABLE Customers
(
	CustomerID int IDENTITY NOT NULL
		PRIMARY KEY,
	Name nvarchar(15) NOT NULL UNIQUE,
	[Address] nvarchar(30) NOT NULL,
	Phone char(11) NOT NULL CHECK 
		(Phone LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO 

INSERT INTO Providers
VALUES 
('Farmer1', 'apples', 'Village1', '00000000001'), 
('Farmer2', 'peaches', 'Village2', '00000000002'), 
('Farmer3', 'apricots', 'Village3', '00000000003'), 
('Farmer4', 'oranges', 'Village4', '00000000004'), 
('Farmer5', 'pears', 'Village5', '00000000005')
GO

INSERT INTO Customers
VALUES 
('Shop1', 'Str1, 10', '11111111111'), 
('Shop2', 'Str2, 20', '22222222222'), 
('Shop3', 'Str3, 30', '33333333333')
GO


ALTER TABLE Employees
ADD 
AttachedProvider nvarchar(20) NULL
GO

ALTER TABLE Employees
ADD CONSTRAINT FK_ProvidersName
FOREIGN KEY (AttachedProvider) REFERENCES Providers(Name)
GO

INSERT INTO Employees
VALUES
('Egor', 'Egorov', 50000, '01/01/2018', 'Farmer1'),
('Stepan', 'Stepanov', 70000, '15/11/2018', 'Farmer2'),
('Andrey', 'Andreev', 70000, '03/06/2019', 'Farmer3'),
('Nikolay', 'Nikolayev', 30000, GETDATE(), NULL)
GO
