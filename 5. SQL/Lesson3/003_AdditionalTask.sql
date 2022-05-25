-- Самостоятельная работа:
-- 1. Создайте БД ShopDB
-- 2. Создайте таблицу Employees (смотрите 003_ClassWork_CREATE_TABLE.jpg).
-- 3. Допишите таблицы и задайте связи заданые на картинке 003_ClassWork_Constraints.jpg
-- 4. Удалите таблицы: Employees, Customers, Orders.

USE master
GO

DROP DATABASE ShopDB
GO

CREATE DATABASE ShopDB
ON
(
	NAME = 'ShopDB',
	FILENAME = 'D:\ShopDB.mdf',
	SIZE = 10mb,
	MAXSIZE = 100mb,
	FILEGROWTH = 10mb
)
LOG ON
(
	NAME = 'LogShopDB',
	FILENAME = 'D:\LogShopDB.ldf',
	SIZE = 5mb,
	MAXSIZE = 50mb,
	FILEGROWTH = 5mb
)
COLLATE Cyrillic_General_CI_AS
GO

USE ShopDB
GO


CREATE TABLE Employees
(
	EmployeeID int IDENTITY NOT NULL 
		PRIMARY KEY,
	FName nvarchar(15) NOT NULL,
	LName nvarchar(15) NOT NULL,
	MName nvarchar(15) NOT NULL,
	Salary money NOT NULL,
	PriorSalary money NOT NULL,
	HireDate date NOT NULL,
	TerminationDate date NULL,
	ManagerEmpID int NULL
)

CREATE TABLE Customers
(
	CustomerNo int IDENTITY NOT NULL 
		PRIMARY KEY,
	FName nvarchar(15) NOT NULL,
	LName nvarchar(15) NOT NULL,
	MName nvarchar(15) NULL,
	Address1 nvarchar(50) NOT NULL,
	Address2 nvarchar(50) NULL,
	City nchar(10) NOT NULL,
	Phone char(12) UNIQUE CHECK (Phone LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	DateInSystem date NULL
)

CREATE TABLE Orders
(
	OrderID int IDENTITY NOT NULL
		PRIMARY KEY,
	CustomerNo int NULL,
	OrderDate date NOT NULL,
	EmployeeID int NULL
)
GO


ALTER TABLE Orders
ADD CONSTRAINT FK_CustomersCustomerNo
FOREIGN KEY (CustomerNo) REFERENCES Customers(CustomerNo)
	ON DELETE CASCADE
GO

ALTER TABLE Orders 
ADD CONSTRAINT FK_EmployeesEmployeeID
FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
	ON DELETE CASCADE
GO


ALTER TABLE Orders
DROP CONSTRAINT FK_CustomersCustomerNo
GO

ALTER TABLE Orders
DROP CONSTRAINT FK_EmployeesEmployeeID
GO


DROP TABLE Customers
GO 

DROP TABLE Employees
GO

DROP TABLE Orders
GO

