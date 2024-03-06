CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_register DATE NULL
)

CREATE TABLE categories (
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL,
)

CREATE TABLE products (
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	price FLOAT NULL,
	stock INT NULL,
	image VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL
)

CREATE TABLE orders (
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	regular_price FLOAT NULL,
	quantity INT NULL,
	status VARCHAR(MAX) NULL,
	date_order DATE NULL
)

CREATE TABLE transactions (
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	prod_id VARCHAR(MAX) NULL,
	total_price FLOAT,
	status VARCHAR(MAX) NULL,
	date_trans DATE NULL
)

SELECT * FROM orders

SELECT * FROM transactions

SELECT * FROM users

SELECT * FROM categories

SELECT * FROM products

SELECT * FROM categories WHERE status = 'Active';

SELECT * FROM users WHERE username = 'test' and id != '5';

UPDATE categories SET status = 'Active' where id = '2';

DELETE FROM products WHERE id = '3';

INSERT INTO users (username, password, role, status, date_register) VALUES ('admin', 'admin123', 'Admin', 'Active', '2024-2-23');