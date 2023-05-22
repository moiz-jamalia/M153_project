-- ------------------------------------------------------
-- If Exist Drop Database
-- ------------------------------------------------------

DROP DATABASE IF EXISTS olmadb;

-- ------------------------------------------------------
-- If not Exist Create Database
-- ------------------------------------------------------

CREATE DATABASE IF NOT EXISTS olmadb;

-- ------------------------------------------------------
-- If Exist Drop User
-- ------------------------------------------------------

DROP USER IF EXISTS 'olma_admin'@'localhost';

-- ------------------------------------------------------
-- If not Exist Create User
-- ------------------------------------------------------

CREATE USER IF NOT EXISTS 'olma_admin'@'localhost' IDENTIFIED BY 's@b-#+(Kc!uAGQwjh_MZ3v)5>f9,R';

GRANT ALL PRIVILEGES ON olmadb.* TO 'olma_admin'@'localhost';
FLUSH PRIVILEGES;


USE olmadb;

-- ------------------------------------------------------
-- Create Tables
-- ------------------------------------------------------

-- ------------------------------------------------------
-- Table user
-- ------------------------------------------------------

DROP TABLE IF EXISTS user;

CREATE TABLE IF NOT EXISTS user
(
    userID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    firstName NVARCHAR(50) NOT NULL,
    lastname NVARCHAR(50) NOT NULL,
    birthDate DATE NOT NULL,
    eMail NVARCHAR(50) UNIQUE NOT NULL,
    phoneNr NVARCHAR(50) UNIQUE NOT NULL,
    postCode NVARCHAR(50) NOT NULL,
    city NVARCHAR(255) NOT NULL,
    street NVARCHAR(255) NOT NULL,
    streetNr INT NOT NULL,
    image LONGBLOB NOT NULL,
    correctAnswer BIT NOT NULL
);

-- ------------------------------------------------------
-- Table Admin
-- ------------------------------------------------------

DROP TABLE IF EXISTS admin;

CREATE TABLE IF NOT EXISTS  admin
(
    adminID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    usernameAdmin NVARCHAR(100) NOT NULL,
    password NVARCHAR(50) NOT NULL
);

-- ------------------------------------------------------
-- Table Prize
-- ------------------------------------------------------

DROP TABLE IF EXISTS prize;

CREATE TABLE IF NOT EXISTS prize
(
    prizeID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name NVARCHAR(50) NOT NULL,
    amount INT(10) NOT NULL,
    worth DECIMAL(10, 2) NOT NULL,
    Currency NVARCHAR(50) DEFAULT 'CHF'
);

-- ------------------------------------------------------
-- Table Quiz
-- ------------------------------------------------------

DROP TABLE IF EXISTS quiz;

CREATE TABLE IF NOT EXISTS quiz
(
    quizID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    question NVARCHAR(255) NOT NULL,
    correctAnswer NVARCHAR(255) NOT NULL
);

-- ------------------------------------------------------
-- Table wrongAnswers
-- ------------------------------------------------------

DROP TABLE IF EXISTS wrongAnswers;

CREATE TABLE IF NOT EXISTS wrongAnswers
(
    wrongAnswersID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    FK_QuestionID INT NOT NULL,
    wrongAnswer1 NVARCHAR(255) NOT NULL,
    wrongAnswer2 NVARCHAR(255) NOT NULL,
    wrongAnswer3 NVARCHAR(255) NOT NULL,
    FOREIGN KEY (FK_QuestionID) REFERENCES quiz(quizID)
);

-- ------------------------------------------------------
-- Insert Data
-- ------------------------------------------------------

-- ------------------------------------------------------
-- insert data into table prize
-- ------------------------------------------------------

INSERT INTO prize(name, amount, worth) VALUES
('Auto', 1, 20000),
('Kreuzfahrt', 2, 8000),
('Einkaufsgutschein', 10, 250),
('Trostpreis Plüschmaskottchen', 20, 15);

-- ------------------------------------------------------
-- Insert data into table admin
-- ------------------------------------------------------

INSERT INTO admin (adminID, usernameAdmin, password) VALUES (1, 'olma_admin' ,'D?4PZ=Yq^_2zegmX');
