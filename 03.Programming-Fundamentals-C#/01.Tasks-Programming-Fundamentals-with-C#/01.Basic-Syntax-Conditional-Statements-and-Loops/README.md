# Basic Syntax, Conditional Statements and Loops – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Basic Syntax, Conditional Statements and Loops** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview

### 📝 Task 1: [Student Information]  
**Problem Statement:**  
Create a program that receives 3 lines of input:
- student name  
- age  
- average grade  

Your task is to print all of the info about the student in the following format:  
`Name: {student name}, Age: {student age}, Grade: {student grade}`

---

### 📝 Task 2: [Passed]  
**Problem Statement:**  
Create a program that receives a single number as input representing a grade.

**Print in the console:**
- `"Passed!"` if the grade is equal or more than 3.00.

**Input:**  
A single floating-point number.  

**Output:**  
The output is either `"Passed!"` or nothing (if the grade is lower than 3.00).

---

### 📝 Task 3: [Passed or Failed]  
**Problem Statement:**  
Modify the program from the previous problem, so it will print `"Failed!"` if the grade is lower than 3.00.

**Input:**  
A single double number.

**Output:**  
- `"Passed!"` if the grade is more than 2.99  
- `"Failed!"` otherwise

---

### 📝 Task 4: [Back in 30 Minutes]  
**Problem Statement:**  
Create a program that prints the time after 30 minutes.

**Input:**  
Two numbers are read from the console:  
- The first number is hours (0–23)  
- The second number is minutes (0–59)

**Output:**  
Print the time after 30 minutes in format `hh:mm`.  
Hours may have 1 or 2 digits, minutes always have 2 digits (with leading zero).

---

### 📝 Task 5: [Month Printer]  
**Problem Statement:**  
Create a program that receives an integer and prints the matching month.  
If the number is more than 12 or less than 1, print `"Error!"`.

**Input:**  
A single integer on a single line.

**Output:**  
If the number is valid, print the corresponding month; otherwise print `"Error!"`.

---

### 📝 Task 6: [Foreign Languages]  
**Problem Statement:**  
Create a program that prints the spoken language in a country.

**Rules:**
- English → England, USA  
- Spanish → Spain, Argentina, Mexico  
- All others → `"unknown"`

**Input:**  
A single line representing the country name.

**Output:**  
Print the spoken language or `"unknown"`.

---

### 📝 Task 7: [Theatre Promotions]  
**Problem Statement:**  
A theatre sells tickets at discount. Create a program that calculates the ticket price.

| Day      | 0 ≤ age ≤ 18 | 18 < age ≤ 64 | 64 < age ≤ 122 |
|----------|--------------|---------------|----------------|
| Weekday  | 12$          | 18$           | 12$            |
| Weekend  | 15$          | 20$           | 15$            |
| Holiday  | 5$           | 12$           | 10$            |

**Input:**  
- First line: type of day  
- Second line: person's age

**Output:**  
Print the ticket price according to the table, or `"Error!"` if the age is invalid.

**Constraints:**  
- Age will be in the interval [-1000…1000]  
- Day type will always be valid

---

### 📝 Task 8: [Divisible by 3]  
**Problem Statement:**  
Create a program that prints all numbers from 1 to 100 divisible by 3.  
Use a single `for` loop.  
The program should **not** receive any input.

---

### 📝 Task 9: [Sum of Odd Numbers]  
**Problem Statement:**  
Create a program that prints the next _n_ odd numbers (starting from 1).  
On the last row, print the sum of all _n_ odd numbers.

**Input:**  
A single number _n_ (how many odd numbers to print)

**Output:**  
Each odd number on a new line, then the total sum on the last line.

**Constraints:**  
- _n_ will be in the interval [1…100]

---

### 📝 Task 10: [Multiplication Table]  
**Problem Statement:**  
Create a program that receives an integer as input.  
Print its multiplication table (1 to 10).

**Output Format:**  
`{theInteger} X {times} = {product}`

**Constraints:**  
- The integer will be in the interval [1…100]

---

### 📝 Task 11: [Multiplication Table 2.0]  
**Problem Statement:**  
Extend the previous task.  
Now also receive the multiplier as input.

- If the multiplier ≤ 10 → print the table from it up to 10  
- If the multiplier > 10 → print only one row

**Output Format:**  
`{theInteger} X {times} = {product}`

**Constraints:**  
- The integer will be in the interval [1…100]

---

### 📝 Task 12: [Even Number]  
**Problem Statement:**  
Create a program that reads a sequence of numbers.

- If the number is even → print: `"The number is: {number}"` and stop  
- If the number is odd → print: `"Please write an even number."` and continue

---

### 📝 Task 13: [Debug the Code: Holidays Between Two Dates]  
**Problem Statement:**  
You are given a buggy program.  
Use the Visual Studio debugger to identify and fix incorrect logic.

- The program counts non-working days (Saturdays and Sundays) between two dates  
- Dates are in the format `day.month.year` (e.g., 1.05.2015 to 15.05.2015)

---
