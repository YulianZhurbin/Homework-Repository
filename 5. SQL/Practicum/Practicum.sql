USE master
GO

DROP DATABASE PracticumDB
GO

CREATE DATABASE PracticumDB
ON
(
	NAME = 'PracticumDB',
	FILENAME = 'D:\Homework\Practicum\Practicum.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogPracticumDB',
	FILENAME = 'D:\Homework\Practicum\LogPracticum.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)

USE PracticumDB
GO

CREATE TABLE Customers
(
	CustNum int NOT NULL PRIMARY KEY,
	Company nvarchar(max) NOT NULL,
	CustRep int NOT NULL FOREIGN KEY REFERENCES Salespeople(EmplNum),
	CreditLimit money NULL
)
GO

CREATE TABLE Salespeople
(
	EmplNum int NOT NULL PRIMARY KEY,
	Name nvarchar(255) NOT NULL,
	Age int NULL,
	Quota money NULL
)
GO

INSERT INTO Salespeople
VALUES
(101, 'Oan Roberts', 45, 300000),
(102, 'Sue Smith', 48, 350000),
(103, 'Paul Cruz', 29, 275000),
(104, 'Bob Smith', 33, 200000),
(105, 'Bill Adams', 37, 350000),
(106, 'Sam Clark', 52, 275000),
(107, 'Nancy Angel', 49, 300000),
(108, 'Larry Fitch', 62, 350000),
(109, 'Mary Jones', 31, 300000),
(110, 'Tom Snyder', 41, NULL),
(113, 'M. Jordan', 50, NULL)
GO

INSERT INTO Customers
VALUES 
(2101, 'Jones Hfg.', 106, 65000),
(2102, 'First Corp.', 101, 65000),
(2103, 'Acne Hfg.', 105, 50000),
(2105, 'AAA Investments', 101, 45000),
(2106, 'Fred Lewis Corp.', 102, 65000),
(2107, 'Ace International', 110, 35000),
(2108, 'Holm & Landis', 109, 55000),
(2109, 'Chen Associates', 103, 25000),
(2111, 'JCP Inc.', 103, 50000),
(2112, 'Zetacorp', 108, 50000),
(2113, 'Ian & Schmidt', 104, 20000),
(2114, 'Orion Corp.', 102, 20000),
(2115, 'Smithson Corp.', 101, 20000),
(2117, 'J.P.Sinclair', 106, 35000),
(2118, 'Midwest Systems', 108, 60000),
(2119, 'Solomon Inc.', 109, 25000),
(2120, 'Rico Enterprises', 102, 50000),
(2121, 'QUA Assoc.', 103, 45000),
(2122, 'Three-Way Lines', 105, 30000),
(2123, 'Carter A Sons', 102, 40000),
(2124, 'Peter Brothers', 107, 40000),
(2200, 'MyCompany', 101, 15),
(2201, 'MyCompany2', 101, 150),
(2203, 'MyCompnay3', 101, 200),
(2204, 'MyCompany4', 101, 150)
GO

