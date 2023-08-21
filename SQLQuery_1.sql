CREATE DATABASE MyTest;
USE MyTest;

CREATE TABLE Addresses
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StreetName VARCHAR(100),
    StreetNumber INT,
    City VARCHAR(50),
);

CREATE TABLE Customers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150),
    Age INT,
    AddressId INT REFERENCES Addresses(Id)
);

CREATE TABLE Orders
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Details VARCHAR(150),
    CustomerId INT REFERENCES Customers(Id)
);

CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150)
);

CREATE TABLE Orders_Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT REFERENCES Orders(Id),
    ProductId INT REFERENCES Products(Id)
);

INSERT INTO Addresses
VALUES ('Independentei', 10, 'Iasi');
INSERT INTO Addresses
VALUES ('Eroilor', 34, 'Brasov');
INSERT INTO Addresses
VALUES ('Unirii', 53, 'Bucuresti');
INSERT INTO Addresses
VALUES ('Independentei', 23, 'Brasov');
INSERT INTO Addresses
VALUES ('Eroilor', 35, 'Brasov');

SELECT *
FROM Addresses;

INSERT INTO Customers
VALUES ('Nico', 20, 1);
INSERT INTO Customers
VALUES ('Alex', 30, 2);
INSERT INTO Customers
VALUES ('Daniel', 40, 3);

SELECT *
FROM Customers;

INSERT INTO Orders
VALUES ('First Order for Nico', 1);
INSERT INTO Orders
VALUES ('Second Order for Nico', 1);
INSERT INTO Orders
VALUES ('First Order for Alex', 2);
INSERT INTO Orders (Details)
VALUES ('First Order for Unknown');

SELECT *
FROM Orders;

INSERT INTO Products
VALUES ('Book about cats');
INSERT INTO Products
VALUES ('Book about c# development');
INSERT INTO Products
VALUES ('Book about databases');
INSERT INTO Products
VALUES ('Book about neuroscience');

SELECT * 
FROM Products;

INSERT INTO Orders_Products
VALUES (1, 1);
INSERT INTO Orders_Products
VALUES (1, 2);
INSERT INTO Orders_Products
VALUES (2, 4);
INSERT INTO Orders_Products
VALUES (3, 1);

SELECT * 
FROM Orders_Products;


INSERT INTO Addresses
VALUES ('Sararie', 80, 'Iasi');
INSERT INTO Addresses
VALUES ('Vladimirescu', 22, 'Iasi');
INSERT INTO Addresses
VALUES ('Unirii', 76, 'Bucuresti');
INSERT INTO Addresses
VALUES ('Ana Ipatescu', 112, 'Sibiu');
INSERT INTO Addresses
VALUES ('I I Brad', 224, 'Sighisoara');

SELECT *
FROM Addresses;


INSERT INTO Customers
VALUES ('Gabi', 33, 4);
INSERT INTO Customers
VALUES ('Ionut', 42, 5);
INSERT INTO Customers
VALUES ('Miruna', 25, 6);
INSERT INTO Customers
VALUES ('Vasile', 37, 7);
INSERT INTO Customers
VALUES ('Mihaela', 47, 8);

SELECT *
FROM Customers;

INSERT INTO Orders
VALUES ('First Order for Miruna', 6);
INSERT INTO Orders
VALUES ('Second Order for Miruna', 6);
INSERT INTO Orders
VALUES ('First Order for Gabi', 4);
INSERT INTO Orders 
VALUES ('First Order for Mihaela', 8);
INSERT INTO Orders 
VALUES ('First Order for Vasile', 7);

SELECT *
FROM Orders;

INSERT INTO Products
VALUES ('Book about Batman');
INSERT INTO Products
VALUES ('Book about Physics');
INSERT INTO Products
VALUES ('Book about books');
INSERT INTO Products
VALUES ('Book about castels');
INSERT INTO Products
VALUES ('Book about eskimos');

SELECT * 
FROM Products;

INSERT INTO Orders_Products
VALUES (6, 8);
INSERT INTO Orders_Products
VALUES (6, 3);
INSERT INTO Orders_Products
VALUES (10, 5);
INSERT INTO Orders_Products
VALUES (7, 9);
INSERT INTO Orders_Products
VALUES (9, 7);

SELECT * 
FROM Orders_Products;

SELECT * FROM Customers
WHERE Age > 15;

SELECT COUNT(Id)
FROM Addresses;

UPDATE Products
SET Name = 'Shining'
WHERE Id = 1;

UPDATE Products
SET Name = 'Dune'
WHERE Id = 2;

UPDATE Products
SET Name = 'Game of Thrones'
WHERE Id = 3;

UPDATE Products
SET Name = 'Millenium'
WHERE Id = 4;

UPDATE Products
SET Name = 'Why we sleep'
WHERE Id = 5;

UPDATE Products
SET Name = 'Metro 2023'
WHERE Id = 6;

UPDATE Products
SET Name = 'Sherlock'
WHERE Id = 7;

UPDATE Products
SET Name = 'A fairytale'
WHERE Id = 8;

UPDATE Products
SET Name = 'Dr. Sleep'
WHERE Id = 9;

ALTER TABLE Products
ADD NoOfPages int;

UPDATE Products
SET NoOfPages = 427
WHERE Id = 1;

UPDATE Products
SET NoOfPages = 1253
WHERE Id = 2;

UPDATE Products
SET NoOfPages = 12767
WHERE Id = 3;

UPDATE Products
SET NoOfPages = 521
WHERE Id = 4;

UPDATE Products
SET Name = 'Random'
WHERE Id = 10;

SELECT *
FROM Customers
LEFT JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT *
FROM Customers
LEFT JOIN Addresses ON Customers.AddressId = AddressId
FULL JOIN Orders ON Customers.Id = Orders.CustomerId;

'stiu ca ultimul select cu join multiplu nu merge cum ar trebui...'

