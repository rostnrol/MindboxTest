USE FirstDB

CREATE TABLE Products
(
ProductId smallint IDENTITY NOT NULL PRIMARY KEY,
ProductName Varchar (20) NOT NULL,
)

CREATE TABLE Categories
(
CategoryId smallint IDENTITY NOT NULL PRIMARY KEY,
CategoryName Varchar (20) NOT NULL,
)

ALTER TABLE Products
ADD CategoryId smallint FOREIGN KEY REFERENCES Categories(CategoryId) 

ALTER TABLE Categories
ADD ProductId smallint NOT NULL FOREIGN KEY REFERENCES Products(ProductId)

INSERT INTO Products
VALUES
('�������', 1),
('����', 2),
('�������', 1),
('����������', 3),
('������', NULL),
('���������', NULL),
('��������', 3),
('������', 1);

INSERT INTO Categories
(CategoryName)
VALUES 
('�����', 1, 3), ('�������', 2, NULL), ('���������', 4, 7);

SELECT * FROM Categories
SELECt * FROM Products

SELECT Products.ProductName AS ProductName, Categories.CategoryName AS CategoryName FROM Products LEFT JOIN Categories 
ON Products.CategoryId = Categories.CategoryId;





