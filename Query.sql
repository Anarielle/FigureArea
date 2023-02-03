CREATE TABLE Product (
	product_id INT PRIMARY KEY IDENTITY,
	"name" VARCHAR(50)
	);

CREATE TABLE Category (
	category_id INT PRIMARY KEY IDENTITY,
	"name" VARCHAR(50)
	);

CREATE TABLE Category_Product (	
	product_id INT FOREIGN KEY (product_id) REFERENCES Product (product_id),
	category_id INT FOREIGN KEY (category_id) REFERENCES Category (category_id),
	PRIMARY KEY (product_id, category_id)
	);

INSERT INTO Category (name)
VALUES 
	('Выживание'),
	('Инди'),
	('Открытый мир'),
	('РПГ'),
	('Симулятор');

INSERT INTO Product (name)
VALUES
	('Papers, Please'),
	('Slime Rancher'),
	('Subnautica'),
	('The Elder Scrolls V'),
	('The Long Dark');

INSERT INTO Category_Product (product_id, category_id)
VALUES 
	(1, 2),
	(1, 5),
	(3, 1),
	(3, 2),
	(3, 3),
	(4, 3),
	(4, 4),
	(5, 1),
	(5, 2),
	(5, 3),
	(5, 5);

SELECT Product.name, Category.name
FROM Product
LEFT JOIN Category_Product
	ON Category_Product.product_id = Product.product_id
LEFT JOIN Category 
	ON Category_Product.category_id = Category.category_id;