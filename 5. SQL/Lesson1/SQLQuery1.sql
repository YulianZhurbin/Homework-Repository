Create database EmptyDataBase 
on
(
	Name = 'EmptyDataBase',
	Filename = 'D:\Homework\Lesson1\EmptyDataBase.mdf',
	Size = 10mb,
	Maxsize = 100mb,
	Filegrowth = 10mb
)
Log on
(
	Name = 'LogEmptyDataBase',
	Filename = 'D:\Homework\Lesson1\EmptyDataBase.ldf',
	Size = 5mb,
	Maxsize = 50mb,
	Filegrowth = 5mb
)
collate Cyrillic_General_CI_AS