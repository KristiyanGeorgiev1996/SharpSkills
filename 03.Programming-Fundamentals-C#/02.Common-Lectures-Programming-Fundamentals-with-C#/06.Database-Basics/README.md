# 📚 Lecture: Database Basics and Management with SQL and NoSQL  
*Part of the course* **Programming Fundamentals with C#**

---

A comprehensive overview of databases, database management systems, and the use of SQL and NoSQL databases in modern software development.

Databases are organized collections of data designed for easy access, management, and updating. Modern databases are managed by Database Management Systems (DBMS), which define database structure (tables, collections, columns, relations, indexes), and support CRUD operations (Create, Read, Update, Delete) and querying.

There are two main types of databases:

- **Relational Databases (RDBMS):** Store data in tables with rows and columns with a strict schema. They use SQL (Structured Query Language) to query and modify data. Examples include MySQL, PostgreSQL, and Microsoft SQL Server.

- **NoSQL Databases:** These databases do not use tables or SQL. Instead, they store data as document collections, key-value pairs, graphs, or wide-column stores. They offer more scalability and flexibility for unstructured data. Examples include MongoDB, Cassandra, and Redis.

### Why use databases?

Databases are not just for storing data, but for efficient:

- Searching  
- Updating  
- Performance optimization  
- Ensuring accuracy and consistency  
- Security and access control  
- Reducing redundancy  

### SQL vs NoSQL comparison:

| Feature               | SQL (Relational)                        | NoSQL (Non-Relational)                 |
|-----------------------|---------------------------------------|---------------------------------------|
| Structure             | Tables with fixed schema               | Documents, key-value, graph, columns  |
| Scalability           | Vertical scaling (stronger hardware)  | Horizontal scaling (more servers)     |
| Use case              | Complex multi-row transactions         | Flexible schemas, big data             |

### Database Management Systems (DBMS)

DBMS software defines, manipulates, retrieves, and manages data within databases. Examples include MySQL, Oracle, PostgreSQL for SQL; MongoDB, Cassandra, Redis for NoSQL. DBMS commonly work using a client-server model.

### Relational Databases and SQL

- The main building block is a **table**, consisting of **rows** (records) and **columns** (fields).  
- SQL commands fall into four categories:  
  - Data Definition Language (DDL) — defines data structure  
  - Data Manipulation Language (DML) — manages data (insert, update, delete)  
  - Data Control Language (DCL) — controls access  
  - Transaction Control Language (TCL) — manages transactions  

### Example SQL queries:

- Retrieve all data from a table:  
```sql
SELECT * FROM people;
```
 - Create a database and table:
```sql
CREATE DATABASE employees;
```
```sql
CREATE TABLE people (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  email VARCHAR(40) NOT NULL,
  first_name VARCHAR(40) NOT NULL,
  last_name VARCHAR(40) NOT NULL
);
```
 - Insert data:
```sql
INSERT INTO people(email, first_name, last_name)
VALUES ('john@gmail.com', 'John', 'Smith');
```
 - Update records:
```sql
UPDATE people SET last_name = 'Adams' WHERE first_name = 'John';
```
 - Delete records and tables:
```sql
DELETE FROM people WHERE first_name = 'George';
DROP TABLE people;
DROP DATABASE employees;
```

---

## NoSQL Databases and MongoDB
NoSQL databases avoid SQL and tables, using document collections (usually JSON), key-value pairs, graphs, or wide-column stores. They provide flexible schemas, scalability, and superior performance for dynamic and large data.

Example JSON document in MongoDB:
```sql
{
  "_id": ObjectId("59d3fe7ed81452db0933a871"),
  "email": "peter@gmail.com",
  "age": 22
}
```
MongoDB is a free, open-source, cross-platform, document-oriented database system that stores data as JSON-like documents with or without schema. It supports indexing for performance and is often used in mobile backends, CMS, blogs, product catalogs, and poll systems.

## MongoDB common operations:
 - Create a collection:
 - ```sql
db.createCollection('people');
```
 - Insert a document:
```sql
db.getCollection('people').insert({
  firstName: 'Michael',
  lastName: 'Smith',
  email: 'michael@gmail.com'
});
```
 - Retrieve documents:
```sql
db.getCollection('people').find({});
db.getCollection('people').find({ firstName: 'Michael' });
 - Update documents:
db.getCollection('people').updateOne(
  { firstName: 'Kate' },
  { $set: { firstName: 'George', age: 25 } }
);
```
 - Delete documents:
```sql
db.getCollection('people').deleteOne({ firstName: 'George' });
db.getCollection('people').deleteMany({ firstName: 'George' });
```

---

## Summary
 - Database Management Systems (DBMS) are essential for storing and managing data efficiently.
 - Developers interact with databases via SQL commands (for relational DBs) or APIs (for NoSQL DBs).
 - MySQL is a widely-used open-source relational database using SQL.
 - NoSQL databases like MongoDB provide flexible data models and scalability by storing data in JSON-like documents.

