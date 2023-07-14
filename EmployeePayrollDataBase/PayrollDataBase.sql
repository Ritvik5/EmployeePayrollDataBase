--UC1(Creating Databse)

CREATE DATABASE Payroll_Service;

USE Payroll_Service;

--UC2(Creating Table/Structure)

CREATE TABLE Employee_Payroll
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(20),
	Salary MONEY,
	StartDate DATE
);

TRUNCATE TABLE Employee_Payroll;

--UC3(Inserting Records in Table)

INSERT INTO Employee_Payroll(Name,Salary,StartDate) 
VALUES('Jack',25000,'2019-05-08'),
      ('Smith',15000,'2022-01-01'),
      ('John',35000,'2019-08-19'),
      ('Snow',45000,'2018-09-20');

--UC4(Retrieving All the Records)

SELECT * FROM Employee_Payroll;

--UC5

SELECT Salary AS Jack_Salary FROM Employee_Payroll 
WHERE Name = 'Jack';

SELECT * FROM Employee_Payroll
WHERE StartDate between '2019-01-01' and getdate();

--UC6
INSERT INTO Employee_Payroll(Name,Salary,StartDate) 
VALUES('Julie',25000,'2019-01-02'),
	  ('Monica',22000,'2015-01-03');


ALTER TABLE Employee_Payroll ADD Gender CHAR(1);

UPDATE Employee_Payroll SET Gender = 'M'
WHERE Name = 'Jack' OR Name = 'Smith' OR Name = 'John' OR Name = 'Snow';

UPDATE Employee_Payroll SET Gender = 'F'
WHERE Name = 'Julie' OR NAME = 'Monica';

--UC7

SELECT SUM(Salary) AS Female_Salary FROM Employee_Payroll
WHERE Gender = 'F' GROUP BY Gender;

SELECT SUM(Salary) AS Male_Salary FROM Employee_Payroll
WHERE Gender = 'M' GROUP BY Gender;

SELECT AVG(Salary) AS Avg_Female_Salary FROM Employee_Payroll
WHERE Gender = 'F' GROUP BY Gender;

SELECT AVG(Salary) AS Avg_Male_Salary FROM Employee_Payroll
WHERE Gender = 'M' GROUP BY Gender;

SELECT MAX(Salary) AS Max_Female_Salary FROM Employee_Payroll
WHERE Gender = 'F' GROUP BY Gender;

SELECT MAX(Salary) AS Max_Male_Salary FROM Employee_Payroll
WHERE Gender = 'M' GROUP BY Gender;

SELECT MIN(Salary) AS Min_Female_Salary FROM Employee_Payroll
WHERE Gender = 'F' GROUP BY Gender;

SELECT MIN(Salary) AS Min_Male_Salary FROM Employee_Payroll
WHERE Gender = 'M' GROUP BY Gender;

--UC8

ALTER TABLE Employee_Payroll ADD Phone VARCHAR(20), Address VARCHAR(50), Department VARCHAR(20);


SELECT * FROM Employee_Payroll;