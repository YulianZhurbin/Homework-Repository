Create database MyDB
on
(
	Name = 'MyDB',
	Filename = 'D:\Homework\Lesson1\MyDB.mdf',
	Size = 10mb,
	Maxsize = 100mb,
	Filegrowth = 10mb
)
Log on
(
	Name = 'LogMyDB',
	Filename = 'D:\Homework\Lesson1\MyDB.ldf',
	Size = 5mb,
	Maxsize = 50mb,
	Filegrowth = 5mb
)
collate Cyrillic_General_CI_AS

Use MyDB
Go

Create table table1
(
	EmployeeID smallint identity not null,
	Name varchar(30) not null,
	PhoneNumber char(11) null
)

Create table table2
(
	EmployeeID smallint identity not null,
	Capacity varchar(30) not null,
	Salary int not null
)

Create table table3
(
	EmployeeID smallint identity not null,
	MaritalStatus varchar(9) null,
	BirthDate date null,
	LivingPlace varchar(100) null
)
Go