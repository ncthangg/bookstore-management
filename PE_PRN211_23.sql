Create database BookManagement2023DB

-- Create BookManagementMember table
CREATE TABLE BookManagementMember (
    MemberId INT PRIMARY KEY,
    Password VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    FullName VARCHAR(255) NOT NULL,
    MemberRole VARCHAR(255) NOT NULL
);

-- Create BookCategory table
CREATE TABLE BookCategory (
    BookCategoryId INT PRIMARY KEY,
    BookGenreType VARCHAR(255) NOT NULL,
    Description VARCHAR(255)
);

-- Create Book table
CREATE TABLE Book (
    BookId INT PRIMARY KEY,
    BookName VARCHAR(255) NOT NULL,
    Description VARCHAR(255),
    ReleaseDate DATE,
    Quantity INT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    BookCategoryId INT NOT NULL,
    Author VARCHAR(255) NOT NULL,
    FOREIGN KEY (BookCategoryId) REFERENCES BookCategory(BookCategoryId)
);

-- Insert data into BookManagementMember table
INSERT INTO BookManagementMember (MemberId, Password, Email, FullName, MemberRole)
VALUES
(1, 'password123', 'john@example.com', 'John Doe', 'Admin'),
(2, 'pass456', 'jane@example.com', 'Jane Smith', 'Member'),
(3, 'secret789', 'bob@example.com', 'Bob Johnson', 'Member');

-- Insert data into BookCategory table
INSERT INTO BookCategory (BookCategoryId, BookGenreType, Description)
VALUES
(1, 'Fiction', 'Novels and stories that are imaginative works'),
(2, 'Non-Fiction', 'Books based on facts and real events'),
(3, 'Biography', 'Books about the lives of real people');

-- Insert data into Book table
INSERT INTO Book (BookId, BookName, Description, ReleaseDate, Quantity, Price, BookCategoryId, Author)
VALUES
(1, 'The Great Gatsby', 'A novel about the decadence of the 1920s', '1925-04-10', 50, 12.99, 1, 'F. Scott Fitzgerald'),
(2, 'To Kill a Mockingbird', 'A classic novel about racial injustice', '1960-07-11', 30, 9.99, 1, 'Harper Lee'),
(3, 'Sapiens: A Brief History of Humankind', 'A book about the history of the human race', '2014-02-10', 20, 16.99, 2, 'Yuval Noah Harari'),
(4, 'Steve Jobs', 'A biography of the co-founder of Apple Inc.', '2011-10-24', 15, 19.99, 3, 'Walter Isaacson');