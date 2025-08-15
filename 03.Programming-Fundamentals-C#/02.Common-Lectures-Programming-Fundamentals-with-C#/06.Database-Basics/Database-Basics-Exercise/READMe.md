# Create New Database

CREATE DATABASE softuni;
USE softuni;


# Create Table

CREATE TABLE students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NULL,
    last_name VARCHAR(50) NULL,
    age INT NULL,
    grade DOUBLE NULL
);


# Insert Data

INSERT INTO students (first_name, last_name, age, grade) VALUES
('Guy', 'Gilbert', 15, 4.5),
('Kevin', 'Brown', 17, 5.4),
('Roberto', 'Tamburello', 19, 6),
('Linda', 'Smith', 18, 5),
('John', 'Stones', 16, 4.25),
('Nicole', 'Nelson', 17, 5.5);


# Find All Records

SELECT * FROM students;


# Find Last Name, Age and Grade

SELECT last_name, age, grade FROM students;


# Find First 5 Records

SELECT * FROM students
LIMIT 5;


# Find First 5 Last Name and Grade

SELECT last_name, grade FROM students
LIMIT 5;


# Truncate Table

TRUNCATE TABLE students;


# Drop Table

DROP TABLE students;


# Drop Database

DROP DATABASE softuni;
