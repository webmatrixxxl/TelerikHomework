-- 01. What is SQL ?
-- is a special-purpose programming language designed for managing data held in
-- a relational database management system (RDBMS)
-- What is DML ?
-- A data manipulation language (DML) is a family of syntax elements similar to a 
-- computer programming language used for inserting, deleting and updating data in a
-- database. Performing read-only queries of data is sometimes also considered a component
-- of DML.

-- 02. What is Ttansact-SQL ?
-- Transact-SQL (T-SQL) is Microsoft's and Sybase's proprietary extension to SQL.
-- Supports if statements, loops, exceptions
-- Constructions used in the high-level procedural programming languages
-- T-SQL is used for writing stored procedures, functions, triggers, etc.

-- 03. Done

-- 04. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

SELECT * FROM Departments

-- 05. Write a SQL query to find all department names.

SELECT Name FROM Departments

-- 06. Write a SQL query to find the salary of each employee.

SELECT FirstName + ' ' + LastName AS [Full Name], Salary FROM Employees

-- 07. Write a SQL to find the full name of each employee.

SELECT FirstName + ' ' + LastName AS [Full Name] FROM Employees

-- 08. Write a SQL query to find the email addresses of each employee 
-- (by his first and last name). Consider that the mail domain is telerik.com.
-- Emails should look like “John.Doe@telerik.com". The produced column should be
-- named "Full Email Addresses".

SELECT FirstName +'.'+ LastName+'@telerik.com' AS [Full Email Addresses] FROM Employees

-- 09. Write a SQL query to find all different employee salaries.

SELECT DISTINCT FirstName + ' ' + LastName AS [Full Name], Salary  FROM Employees

-- 10. Write a SQL query to find all information about the employees whose 
-- job title is “Sales Representative“.

SELECT *  FROM Employees WHERE JobTitle = 'Sales Representative'

--  11. Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT *  FROM Employees WHERE FirstName Like 'SA%'

-- 12.Write a SQL query to find the names of all employees whose last name contains "ei".

SELECT *  FROM Employees WHERE LastName Like '%ei%'

-- 13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

SELECT *  FROM Employees WHERE Salary BETWEEN 20000 AND 30000

-- 14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT FirstName + ' ' + LastName AS [Full Name], Salary  FROM Employees WHERE Salary IN (25000, 14000, 12500, 23600)

-- 15. Write a SQL query to find all employees that do not have manager.

SELECT * FROM Employees WHERE ManagerID IS NULL

-- 16. Write a SQL query to find all employees that have salary more than 
-- 50000. Order them in decreasing order by salary.

SELECT FirstName + ' ' + LastName AS [Full Name], Salary  FROM Employees WHERE Salary > 5000 Order BY Salary DESC

-- 17. Write a SQL query to find the top 5 best paid employees.

SELECT TOP(5) Salary FROM Employees 

-- 18. Write a SQL query to find all employees along with their address. Use inner join with ON
-- clause.

SELECT * FROM Employees e JOIN Addresses a ON e.AddressID = a.AddressID

-- 19. Write a SQL query to find all employees and their address. Use equijoins
-- (conditions in the WHERE clause).

SELECT e.EmployeeID, e.LastName, 
      d.AddressText AS Addresses
FROM Employees e, Addresses d 
WHERE e.AddressID = d.AddressID


-- 20. Write a SQL query to find all employees along with their manager.

SELECT e.FirstName + ' ' + e.LastName 
AS [Employees], m.FirstName +' '+ m.LastName 
AS [Employees Manager] 
FROM Employees e 
Join Employees m 
ON e.ManagerID = m.EmployeeID

-- 21. Write a SQL query to find all employees, along with their manager and their address.
-- Join the 3 tables: Employees e, Employees m and Addresses a.

SELECT e.FirstName + ' ' + e.LastName 
AS [Employees], m.FirstName +' '+ m.LastName 
AS [Employees Manager],
a.AddressText [Employee Adress]
FROM Employees e 
Join Employees m 
ON e.ManagerID = m.EmployeeID
JOIN Addresses a
ON a.AddressID = e.EmployeeID

-- 22. Write a SQL query to find all departments and all town names as a single list. Use UNION.

SELECT Name
FROM Departments
UNION
SELECT Name
FROM Towns

-- 23. Write a SQL query to find all the employees and the manager for each of 
-- them along with the employees that do not have manager. Use right outer join.
-- Rewrite the query to use left outer join.

SELECT e.FirstName + ' ' + e.LastName 
AS [Employees], m.FirstName +' '+ m.LastName 
AS [Employees Manager] 
FROM Employees e 
LEFT OUTER Join Employees m 
ON e.ManagerID = m.EmployeeID

-- 24. Write a SQL query to find the names of all employees from the departments 
-- "Sales" and "Finance" whose hire year is between 1995 and 2005.

SELECT e.FirstName + ' ' + e.LastName, e.HireDate 
FROM Employees e JOIN Departments d 
ON e.DepartmentID = d.DepartmentID AND d.Name = 'Sales' OR  d.Name = 'Finance'
WHERE   FORMAT(HireDate, 'yyyy') BETWEEN 1995 AND 2005