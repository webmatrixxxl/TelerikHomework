-- 01. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN)
-- and Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing. 
-- Write a stored procedure that selects the full names of all persons.

CREATE DATABASE MyTestDB;

CREATE TABLE Persons (
        Id INT IDENTITY,
        FirstName NVARCHAR(50),
        LastName NVARCHAR(50),
        SSN NVARCHAR(50)
        CONSTRAINT PK_Id PRIMARY KEY(Id)
)

CREATE TABLE Accounts (
        Id INT IDENTITY,
		CONSTRAINT PK_Accounts PRIMARY KEY(Id),
        Balance MONEY NOT NULL,
		PersonId INT NOT NULL,
        CONSTRAINT FK_Id FOREIGN KEY(Id)
                REFERENCES Persons(Id)
)

INSERT INTO Persons (FirstName, LastName, SSN)
VALUES  ('Svetlin', 'Nakov', '1234123456'),
        ('Doncho', 'Minkov', '5511235796'),
        ('Nikolay', 'Kostov', '2984179551'),
        ('George', 'Georgiev', '9180041249')

INSERT INTO Accounts (Balance, PersonId)
VALUES
        (30000, 1),
        (60000, 1),
        (50000, 2),
        (77000.99, 3)

CREATE PROC dbo.usp_SelectPersonsFullName
AS
	SELECT FirstName + ' ' + LastName AS FullName
	FROM dbo.Persons
GO

EXEC dbo.usp_SelectPersonsFullName

 02. Create a stored procedure that accepts a number as a parameter and
 returns all persons who have more money in their accounts than the supplied number.

ALTER PROC dbo.usp_SelectMoreMoney (@leverageBalance INT = 200)
AS
	SELECT p.FirstName + ' ' + p.LastName AS FullName
	FROM Persons p 
	INNER JOIN Accounts a
	ON p.Id = a.PersonId
	WHERE a.Balance >= @leverageBalance

GO

EXEC usp_SelectMoreMoney 10

-- 03.Create a function that accepts as parameters – sum, yearly interest
-- rate and number of months. It should calculate and return the new sum. 
-- Write a SELECT to test whether the function works as expected.

ALTER PROC dbo.usp_CalculateNewSum (
        @SUM INT = 200,
        @interest INT = 10,
        @monthsN INT = 24,
        @RESULT INT OUTPUT
        )
AS
        SET @RESULT = @SUM + (@monthsN/12)*((@interest*@SUM)/100)
GO
 
DECLARE @answer INT
EXEC usp_CalculateNewSum 200, 10, 24, @answer OUTPUT
SELECT @answer

-- 04. Create a stored procedure that uses the function from the previous example
-- to give an interest to a person's account for one month. It should take the AccountId
-- and the interest rate as parameters.

ALTER PROC dbo.usp_GiveInterest ( @id INT, @interest INT, @RESULT money OUTPUT)
AS
    DECLARE @sumz money
    SET @sumz = (SELECT a.Balance
                    FROM Accounts a
                            INNER JOIN Persons p
                            ON p.Id = a.PersonId
                                    AND p.Id = @id)
   
    EXEC usp_CalculateNewSum
            @sumz,
            @interest,
            24,
            @RESULT OUTPUT         
GO
       
DECLARE @final money
EXEC usp_GiveInterest 2, 10, @final OUTPUT
SELECT @final

-- 05. Add two more stored procedures WithdrawMoney( AccountId, money)
-- and DepositMoney (AccountId, money) that operate in transactions.

 GO
 
--WithdrawMoney( AccountId, money)
CREATE PROCEDURE usp_WithdrawMoney
        (@accountId INT, @moneyToDraw MONEY)
AS
        BEGIN TRANSACTION
        DECLARE @availableMoney MONEY =
                (Select Balance
                From Accounts
                WHERE Id = @accountId)
 
        IF (@availableMoney >= @moneyToDraw)
        BEGIN
                UPDATE Accounts
                SET Balance = Balance - @moneyToDraw
                WHERE Id = @accountId
                COMMIT
        END
        ELSE
        BEGIN
                RAISERROR ('Not enough money in account.', 16, 1)
                ROLLBACK TRAN
        END
GO
 
EXEC usp_WithdrawMoney 1, 20000
 
--DepositMoney (AccountId, money)
GO
 
CREATE PROCEDURE usp_DepositMoney
        (@accountId INT, @moneyToDeposit MONEY)
AS
        BEGIN TRANSACTION
        IF (@moneyToDeposit >= 0)
        BEGIN
                UPDATE Accounts
                SET Balance = Balance + @moneyToDeposit
                WHERE Id = @accountId
                COMMIT
        END
        ELSE
        BEGIN
                RAISERROR('Deposit money cannott be negative.', 16, 1)
                ROLLBACK TRAN
        END
GO
 
EXEC usp_DepositMoney 1, 20000

-- 06. Create another table – Logs(LogID, AccountID, OldSum, NewSum). 
-- Add a trigger to the Accounts table that enters a new entry into the Logs 
-- table every time the sum on an account changes.

CREATE TABLE Logs
(
        LogId INT IDENTITY,
                CONSTRAINT PK_Logs PRIMARY KEY(LogId),
        OldSum MONEY,
        NewSum MONEY,
        AccountId INT,
                CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountId)
                        REFERENCES Accounts(Id)
)
 
GO
 
CREATE TRIGGER tr_AccountUpdate ON Accounts FOR UPDATE
AS
        DECLARE deletedCursor CURSOR READ_ONLY FOR
                SELECT Balance, Id FROM deleted
        DECLARE insertedCursor CURSOR READ_ONLY FOR
                SELECT Balance FROM inserted
 
        OPEN deletedCursor
        OPEN insertedCursor
 
        DECLARE @oldSum MONEY, @accountId INT
        FETCH NEXT FROM deletedCursor INTO @oldSum, @accountId
 
        DECLARE @newSum MONEY
        FETCH NEXT FROM insertedCursor INTO @newSum
 
        WHILE @@FETCH_STATUS = 0
        BEGIN
                INSERT INTO Logs (OldSum, NewSum, AccountId)
                VALUES (@oldSum, @newSum, @accountId)
                FETCH NEXT FROM deletedCursor INTO @oldSum, @accountId
                FETCH NEXT FROM insertedCursor INTO @newSum
        END
 
        CLOSE deletedCursor
        DEALLOCATE deletedCursor
        CLOSE insertedCursor
        DEALLOCATE insertedCursor
GO
 
UPDATE Accounts
SET Balance = Balance + Balance * 0.1
WHERE Id = 1 OR Id = 2

 
-- 07. Divided the searches into different, each selecting a distinct tale of results,
--instead of one table for all. Can easily combine them all if one needs to.
-- Procedure to search through First Names
CREATE PROC [dbo].[usp_FindNames](
        @lettersToSearch NVARCHAR(50)
        )
        AS
                DECLARE @valid bit
                SET @valid = 0
                                       
                        SELECT e.FirstName AS [FIRST Names]
                        FROM Employees e
                        WHERE
                                1 = (SELECT [dbo].[fn_NameContainingLetters](
                                        e.FirstName,
                                        @lettersToSearch)
                                        )
        GO
 
--Procedure to search through Middle Names
CREATE PROC [dbo].[usp_FindMiddleNames](
        @lettersToSearch NVARCHAR(50)
        )
        AS
                DECLARE @valid bit
                SET @valid = 0
                                       
                        SELECT e.MiddleName AS [Middle Names]
                        FROM Employees e
                        WHERE
                                1 = (SELECT [dbo].[fn_NameContainingLetters](
                                        e.MiddleName,
                                        @lettersToSearch)
                                        )
        GO
 
--Procedure to search through Last Names
CREATE PROC [dbo].[usp_FindLastNames](
        @lettersToSearch NVARCHAR(50)
        )
        AS
                DECLARE @valid bit
                SET @valid = 0
                                       
                        SELECT e.LastName AS [LAST Names]
                        FROM Employees e
                        WHERE
                                1 = (SELECT [dbo].[fn_NameContainingLetters](
                                        e.LastName,
                                        @lettersToSearch)
                                        )
        GO
 
 
--Procedure to search through Towns
CREATE PROC [dbo].[usp_FindTowns](
        @lettersToSearch NVARCHAR(50)
        )
        AS
                DECLARE @valid bit
                SET @valid = 0
                                       
                        SELECT t.Name AS [Towns]
                        FROM Towns t
                        WHERE
                                1 = (SELECT [dbo].[fn_NameContainingLetters](
                                        t.Name,
                                        @lettersToSearch)
               
 
-- The Function For Every String
CREATE FUNCTION [dbo].[fn_NameContainingLetters](
        @name NVARCHAR(50),
        @letters NVARCHAR(50)
        )
        RETURNS bit
AS
BEGIN
        DECLARE @contains bit
        SET @contains = 1
        DECLARE @curLetter NVARCHAR(1)
        DECLARE @counter INT
        SET @counter = 1
 
        WHILE(@counter <= LEN(@name))
                BEGIN
                SET @curLetter = SUBSTRING(@name, @counter, 1)
                IF (CHARINDEX(@curLetter, @letters) = 0)
                        SET @contains = 0
                SET @counter = @counter + 1
                END
        RETURN @contains
END
 
EXEC [dbo].[usp_FindNames] @letterstosearch = 'oistmiahf'
EXEC [dbo].[usp_FindMiddleames] @letterstosearch = 'oistmiahf'
EXEC [dbo].[usp_FindLastNames] @letterstosearch = 'oistmiahf'
EXEC [dbo].[usp_FindTowns] @letterstosearch = 'oistmiahf'
 
 
-- 08. Using database cursor write a T-SQL script that scans all employees and their 
-- addresses and prints all pairs of employees that live in the same town.

 
DECLARE empCursor CURSOR READ_ONLY FOR
        SELECT e.FirstName, e.LastName, t.Name,
                o.FirstName, o.LastName
        FROM Employees e
                INNER JOIN Addresses a
                        ON a.AddressID = e.AddressID
                INNER JOIN Towns t
                        ON t.TownID = a.TownID,
        Employees o
                INNER JOIN Addresses a1
                        ON a1.AddressID = o.AddressID
                INNER JOIN Towns t1
                        ON t1.TownID = a1.TownID               
 
        OPEN empCursor
        DECLARE @firstName1 NVARCHAR(50)
        DECLARE @lastName1 NVARCHAR(50)
        DECLARE @town NVARCHAR(50)
        DECLARE @firstName2 NVARCHAR(50)
        DECLARE @lastName2 NVARCHAR(50)
        FETCH NEXT FROM empCursor
                INTO @firstName1, @lastName1, @town, @firstName2, @lastName2
 
        WHILE @@FETCH_STATUS = 0
                BEGIN
                        PRINT @firstName1 + ' ' + @lastName1 +
                                '     ' + @town + '      ' + @firstName2 + ' ' + @lastName2
                        FETCH NEXT FROM empCursor
                                INTO @firstName1, @lastName1, @town, @firstName2, @lastName2
                END
 
        CLOSE empCursor
        DEALLOCATE empCursor
 
 
-- 09. * Write a T-SQL script that shows for each town a list of all 
-- employees that live in it. Sample output:
-- Sofia -> Svetlin Nakov, Martin Kulov, George Denchev
-- Ottawa -> Jose Saraiva


 
-- Create another table to hold people fromeach city, ordered by city
CREATE TABLE UsersTowns (
        ID INT IDENTITY,
        FullName NVARCHAR(50),
        TownName NVARCHAR(50)
)
INSERT INTO UsersTowns
SELECT e.FirstName + ' ' + e.LastName, t.Name
                FROM Employees e
                        INNER JOIN Addresses a
                                ON a.AddressID = e.AddressID
                        INNER JOIN Towns t
                                ON t.TownID = a.TownID
                GROUP BY t.Name, e.FirstName, e.LastName
 
 
 
-- Nested cursors to fetch info
DECLARE @name NVARCHAR(50)
        DECLARE @town NVARCHAR(50)
 
        DECLARE empCursor1 CURSOR READ_ONLY FOR
                SELECT DISTINCT ut.TownName
                        FROM UsersTowns ut     
 
        OPEN empCursor1
        FETCH NEXT FROM empCursor1
                INTO @town
 
                WHILE @@FETCH_STATUS = 0
                BEGIN
                        PRINT @town
 
                        DECLARE empCursor2 CURSOR READ_ONLY FOR
                                SELECT ut.FullName
                                FROM UsersTowns ut
                                        WHERE ut.TownName = @town
                        OPEN empCursor2
                       
                        FETCH NEXT FROM empCursor2
                                INTO @name
                               
                                WHILE @@FETCH_STATUS = 0
                                BEGIN
                                        PRINT '   ' + @name
                                        FETCH NEXT FROM empCursor2 INTO @name
                                END
 
                                CLOSE empCursor2
                                DEALLOCATE empCursor2
                        FETCH NEXT FROM empCursor1 INTO @town
                END
 
        CLOSE empCursor1
        DEALLOCATE empCursor1
 
 
-- 10. Define a .NET aggregate function StrConcat that takes as input a 
-- sequence of strings and return a single string that consists of the
-- input strings separated by ','. For example the following SQL statement 
-- should return a single string:

 
DECLARE @name nvarchar(MAX);
SET @name = N'';
SELECT @name+=e.FirstName+N','
FROM Employees e
SELECT LEFT(@name,LEN(@name)-1);