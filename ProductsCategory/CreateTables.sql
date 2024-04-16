-- Создание таблицы Products
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100)
);

-- Создание таблицы Categories
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(100)
);

-- Создание таблицы ProductCategory для связи многие ко многим между Products и Categories
CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Добавление ограничения CHECK на положительные значения для ProductID
ALTER TABLE Products
ADD CONSTRAINT CHK_ProductID_Positive CHECK (ProductID > 0);