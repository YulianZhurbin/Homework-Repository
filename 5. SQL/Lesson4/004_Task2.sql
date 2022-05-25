DROP DATABASE SecondTaskDB
GO

CREATE DATABASE SecondTaskDB
ON
(
	NAME = 'SecondTaskDB',
	FILENAME = 'D:\SecondTask.mdf',
	SIZE = 30mb,
	MAXSIZE = 100mb,
	FILEGROWTH = 10mb
)
LOG ON
(
	NAME = 'LogSecondTaskDB',
	FILENAME = 'E:\LogSecondTaskBD.ldf',
	SIZE = 15mb,
	MAXSIZE = 50mb,
	FILEGROWTH = 5mb
)
COLLATE Cyrillic_General_CI_AS
GO

EXEC sp_helpdb SecondTaskDB


  