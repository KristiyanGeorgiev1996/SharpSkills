# Database Basics – MySQL Queries

This lab demonstrates basic MySQL operations: creating a database, creating a table, inserting data, querying data, truncating a table, and dropping tables/databases.  
Each section contains the SQL commands needed to perform the task.

---

## 01.Create New Database 
Creates a new database called `softuni` and sets it as the current database.
```
CREATE DATABASE softuni;
USE softuni;
```

## 02.Create Table
Creates a table students with columns for id, first name, last name, age, and grade.
```
CREATE TABLE students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NULL,
    last_name VARCHAR(50) NULL,
    age INT NULL,
    grade DOUBLE NULL
);
```

## 03.Insert Data
Inserts 6 sample students into the students table.
```
INSERT INTO students (first_name, last_name, age, grade) VALUES
('Guy', 'Gilbert', 15, 4.5),
('Kevin', 'Brown', 17, 5.4),
('Roberto', 'Tamburello', 19, 6),
('Linda', 'Smith', 18, 5),
('John', 'Stones', 16, 4.25),
('Nicole', 'Nelson', 17, 5.5);
```

## 04.Find All Records
Selects all records from the students table.
```
SELECT * FROM students;
```

## 05.Find Last Name, Age and Grade
Selects only the last name, age, and grade of each student.
```
SELECT last_name, age, grade FROM students;
```

## 06.Find First 5 Records
Selects the first 5 records from the table.
```
SELECT * FROM students
LIMIT 5;
```

## 07.Find First 5 Last Name and Grade
Selects only last name and grade for the first 5 records.
```
SELECT last_name, grade FROM students
LIMIT 5;
```

## 08.Truncate Table
Removes all records from the students table but keeps the table structure.
```
TRUNCATE TABLE students;
```

## 09.Drop Table
Deletes the students table completely.
```
DROP TABLE students;
```

## 10.Drop Database
Deletes the softuni database completely.
```
DROP DATABASE softuni;
```
