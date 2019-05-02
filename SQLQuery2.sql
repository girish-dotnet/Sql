--drop table Employee
IF EXISTS(SELECT * FROM sysobjects WHERE Name='Employee') 
DROP TABLE Employee
GO

create table Employee
(
EmployeeId int identity(100,1),
EmployeeName varchar(30),
Salary numeric(10,2)
)
GO

alter table Employee add DA numeric(10,2),PF numeric(8,2)
Go

insert into Employee(EmployeeName,Salary) values('Tim',67000)
GO

update Employee set DA=15000 ,PF=4500

IF EXISTS(SELECT * FROM sysobjects WHERE Name='Customer') 
DROP TABLE Customer
GO

Create table Customer 
(
CustomerId int primary key,
CustomerName varchar(20),
City varchar(20),
CreditLimit varchar(20)
)
GO

insert into Customer values(1002,'Bharat','Hyderabad','65000')
GO

IF EXISTS(SELECT * FROM sysobjects WHERE Name='Person') 
DROP TABLE Person
GO

Create table Person
(PersonID int identity(1,1) , PersonName varchar(30),MaritalStatus bit)
GO

 insert into Person values('Sai',1)
 insert into Person values('Rahul',0)

IF EXISTS(SELECT * FROM sysobjects WHERE Name='Students') 
DROP TABLE Students
GO


 Create table Students
 (
 StudentID int identity(1,1),
 StudentName varchar(20),
 City varchar(20)
 )

 insert into Students values('Rakshan','Pune')