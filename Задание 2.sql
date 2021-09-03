CREATE TABLE Products (
	Id INT PRIMARY KEY,	"Name" TEXT
);

INSERT INTO Products
VALUES
	(1,'Product1'),(2,'Product2'),(3,'Product3'),(4,'Product4'),(5,'Product4');

CREATE TABLE Categories (
	Id INT PRIMARY KEY, "Name" TEXT
);

INSERT INTO Categories
VALUES
	(1,'Cat1'),(2,'Cat2'),(3,'Cat3');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1,2),(1,1),(1,3),(2,1),(2,3),(4,1),(5,2);

SELECT Products."Name",Categories."Name"
FROM Products
LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
LEFT JOIN Categories 	ON ProductCategories.CategoryId = Categories.Id;