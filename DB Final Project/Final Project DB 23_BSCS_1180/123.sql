CREATE DATABASE BankDataBase;
USE BankDataBase;

CREATE TABLE Login_Credientials (
    A_Id INT NOT NULL,
    A_Name VARCHAR(255) NOT NULL,
    A_Pass VARCHAR(11) NOT NULL,
    CONSTRAINT LC_PK PRIMARY KEY (A_Id)
);
INSERT INTO Login_Credientials (A_Id, A_Name, A_Pass)
VALUES (1, 'Waqas', '123456');
SELECT *
FROM Login_Credientials;

CREATE TABLE Add_Account (
    AC_Num INT PRIMARY KEY IDENTITY(100,1),
    AcName VARCHAR(50) NOT NULL,
    AcPhone VARCHAR(50) NOT NULL,
    AcAddress VARCHAR(100) NOT NULL,
    ACGender VARCHAR(10) NOT NULL,
    ACEdu VARCHAR(50) NOT NULL,
    AcOccupation VARCHAR(50) NOT NULL,
    AcBal BIGINT NOT NULL
);
INSERT INTO Add_Account (AcName, AcPhone, AcAddress, ACGender, ACEdu, AcOccupation, AcBal)
VALUES ('Waqas', '03000000300', 'FSD', 'Male', 'FSC', 'Edu', 238739);
SELECT *
FROM Add_Account;

CREATE TABLE Manage_User (
    AgId INT PRIMARY KEY IDENTITY(1000, 1),
    AgName VARCHAR(50) NOT NULL,
    AgPass VARCHAR(50) NOT NULL,
    AgPhone VARCHAR(50) NOT NULL,
    AcAddress VARCHAR(50) NOT NULL
);
INSERT INTO Manage_User (AgName, AgPass, AgPhone, AcAddress)
VALUES ('Waqas', 'waqas1', '0303030303', 'FSD');
SELECT *
FROM Manage_User;


