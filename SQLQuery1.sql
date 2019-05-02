

--drop table Students
Create table Students
 (
 StudentID int identity(1,1),
 StudentName varchar(20),
 CityId int
 )

 insert into Students values('Tom',1)
 insert into Students values('Pranav',1)
 insert into Students values('Dinesh',2)
 insert into Students values('Gupta',2)
 insert into Students values('Varsha',3)

 select * from Students