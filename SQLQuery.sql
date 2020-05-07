USE Mindbox

CREATE TABLE categories
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL
);

CREATE TABLE products
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	CategoryId INT NOT NULL
);
 
INSERT INTO categories VALUES
	('Транспорт'),
    ('Военная техника'),
    ('Продукты');

INSERT INTO products VALUES
	('Вертолет', 1),
    ('Вертолет', 2),
    ('Молоко', 3),
	('Телефон', 4);
 
SELECT products.Name AS ProductName, categories.Name AS CategoryName FROM products LEFT JOIN categories ON products.CategoryId = categories.id;