--AdditionalTask--------------------------------------------------

use AdventureWorks2012
go

select * from Production.Product
where StandardCost > 100

select * from Production.Product
where Name like 'ML%' and ProductNumber like 'RM%'

--Task1-----------------------------------------------------------

Create database HomeWork
on
(
	name = 'HomeWork',
	filename = 'D:\Homework\Lesson2\HomeWork.mdf',
	size = 10mb,
	maxsize = 100mb,
	filegrowth = 10mb
)
log on
(
	name = 'LogHomeWork',
	filename = 'D:\Homework\Lesson2\HomeWork.ldf',
	size = 5mb,
	maxsize = 50mb,
	filegrowth = 5mb
)
collate Cyrillic_General_CI_AS

use HomeWork
go

create table Product
(
	ProductID smallint identity not null,
	Name nvarchar(20) not null,
	ProductNum nvarchar(10) not null,
	Cost smallmoney not null,
	Quantity smallint null,
	SellStartDate date null
)
go

insert into Product
values
('Корона', 'AK-53818', 5, 50, '15/08/2011'),
('Милка', 'AM-51122', 6.1, 50, '15/07/2011'),
('Алёнка', 'AA-52211', 2.5, 20, '15/06/2011'),
('Snickers', 'BS-32118', 2.8, 50, '15/08/2011'),
('Snickers', 'BSL-3818', 5, 100, '20/08/2011'),
('Bounty', 'BB-38218', 3, 100, '01/08/2011'),
('Nuts', 'BN-37818', 3, 100, '21/08/2011'),
('Mars', 'BM-3618', 2.5, 50, '24/08/2011'),
('Свиточ', 'AS-54181', 5, 100, '12/08/2011'),
('Свиточ', 'AS-54182', 5, 100, '12/08/2011');
go

--Task3-----------------------------------------------------------

select Name, ProductNum from Product
where Quantity > 59

select * from Product
where Cost > 3 and SellStartDate >= '20/08/2011'

--Task4-----------------------------------------------------------

update Product
set Cost = Cost + 0.25
where Name = 'Свиточ' 

select * from Product








