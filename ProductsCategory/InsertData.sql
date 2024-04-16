-- Вставка данных в таблицу Products. Product 4 - значение без категории 
INSERT INTO Products (ProductID, ProductName) VALUES 
    (1, 'Product 1'),
    (2, 'Product 2'),
    (3, 'Product 3');
    (4, 'Product 4');

-- Вставка данных в таблицу Categories
INSERT INTO Categories (CategoryID, CategoryName) VALUES 
    (1, 'Category A'),
    (2, 'Category B'),
    (3, 'Category C');

-- Вставка данных в таблицу ProductCategory
INSERT INTO ProductCategory (ProductID, CategoryID) VALUES 
    (1, 1),
    (1, 2),
    (2, 2),
    (3, 3);