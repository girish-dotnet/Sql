use sqlpractice
go

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Donar') 
DROP TABLE Donar
GO

CREATE TABLE Donar
(
	DonorId INT Primary Key,
	DonorName VARCHAR(30),
	Gender CHAR(1),
	DateOfBirth Date,
	MobileNo VARCHAR(10),
	Organ VARCHAR(15)
	constraint CHK_Organ_Donar CHECK(ORGAN IN('Eyes','HEART',
		'LIVER','Kidney')),
	City VARCHAR(15)
	CONSTRAINT CHK_Donar_City CHECK(CITY IN('Bangalore',
		'Chennai','Mumbai',
		'Pune'))
)
GO


IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcDonarIdAutoGenerate') 
DROP PROC prcDonarIdAutoGenerate
GO


CREATE PROC prcDonarIdAutoGenerate
AS
BEGIN
	SELECT CASE WHEN MAX(DonorId) IS NULL THEN 1 ELSE 
	MAX(DonorId)+1 END DonarID  FROM Donar
END
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='PrcDonarInsert') 
DROP PROC PrcDonarInsert
GO
CREATE PROC PrcDonarInsert
					@DonarID INT,
					@DonarName VARCHAR(30),
					@Gender CHAR(1),
					@DateOfBirth DATE,
					@MobileNo VARCHAR(10),
					@Organ VARCHAR(15),
					@City VARCHAR(15)
AS
BEGIN
	INSERT INTO Donar VALUES(@DonarID,@DonarName,@Gender,@DateOfBirth,
				@MobileNo,@Organ,@City)
END
GO