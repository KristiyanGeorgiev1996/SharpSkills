# 🧑‍💻 Methods - Exercise – Programming Fundamentals with C#

This folder contains tasks from the **Methods - Exercise** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview

### 📝 Task 1: Smallest of Three Numbers  
**Problem Statement:**  
Create a method that prints out the smallest of three integer numbers.

---

### 📝 Task 2: Vowels Count  
**Problem Statement:**  
Create a method that receives a single string and prints out the number of vowels contained in it.

---

### 📝 Task 3: Characters in Range  
**Problem Statement:**  
Create a method that receives two characters and prints all the characters between them according to ASCII (on a single line).

> **Note:** If the second letter's ASCII value is less than that of the first one, the two initial letters should be swapped.

---

### 📝 Task 4: Password Validator  
**Problem Statement:**  
Create a program that checks if a given password is valid.

**Password validation rules:**

- It should contain **6 – 10 characters** (inclusive)  
- It should contain **only letters and digits**  
- It should contain **at least 2 digits**

**Invalid password messages:**

- `"Password must be between 6 and 10 characters"`  
- `"Password must consist only of letters and digits"`  
- `"Password must have at least 2 digits"`

---

### 📝 Task 5: Add and Subtract  
**Problem Statement:**  
You will receive 3 integers.  
Create a method that returns the sum of the first two integers, and another method that subtracts the third integer from the result of the sum method.

---

### 📝 Task 6: Middle Characters  
**Problem Statement:**  
You will receive a single string.  
Create a method that prints the character(s) found in the middle.  
If the length of the string is even, print the two middle characters.

---

### 📝 Task 7: NxN Matrix  
**Problem Statement:**  
Create a method that receives a single integer `n` and prints an `n x n` matrix using this number as filler.

---

### 📝 Task 8: Factorial Division  
**Problem Statement:**  
Read two integers. Calculate the factorial of each number.  
Divide the first result by the second and print the result formatted to the second decimal point.

---

### 📝 Task 9: Palindrome Integers  
**Problem Statement:**  
Create a program that reads positive integers until you receive the `"END"` command.  
For each number, print whether it is a palindrome (reads the same backward as forward).

> Examples: `323`, `1001` are palindromes.

---

### 📝 Task 10: Top Number  
**Problem Statement:**  
A top number is an integer that satisfies **both**:

- Its **sum of digits is divisible by 8**  
- It contains **at least one odd digit**

> Examples of top numbers: `17`, `161`, `251`, `4310`, `123200`

Create a program that prints all top numbers in the range `[1…n]`.

---

### 📝 Task 11: Array Manipulator  
**Problem Statement:**  
Peter must manipulate an array of integers using specific commands. The array may be manipulated by:

#### Commands:
- `exchange {index}` – splits and rearranges the array  
  > If the index is invalid → `"Invalid index"`  
- `max even/odd` – prints the index of the max even/odd element  
- `min even/odd` – prints the index of the min even/odd element  
  > If multiple equal values → return the **rightmost** index  
  > If not found → `"No matches"`  
- `first {count} even/odd` – returns first N even/odd numbers  
- `last {count} even/odd` – returns last N even/odd numbers  
  > If count is too big → `"Invalid count"`  
  > If fewer elements are found → return available ones  
- `end` – stop input and print the final state of the array

#### Input:
- First line: array of integers  
- Next lines: array manipulation commands  
- Input ends with `"end"`

#### Output:
- Each command's result (when needed)  
- Final array printed in `[element1, element2, ...]` format

---

### 📝 Task 12: Data Types  
**Problem Statement:**  
Read a value and a data type indicator. Based on the type:

- `int` → multiply by 2  
- `real` → multiply by 1.5 and format to 2 decimal places  
- `string` → surround the input with `'$'`

Print the result.

---

### 📝 Task 13: Center Point  
**Problem Statement:**  
You are given two points (X1, Y1) and (X2, Y2).  
Create a method that prints the point **closest to the origin (0,0)** in the format `(X, Y)`.

> If both are equally distant, print only the **first**.

---

### 📝 Task 14: Longer Line  
**Problem Statement:**  
You are given coordinates of four points.  
The first pair and the second pair form two lines.

Print the **longer line** in the format: `(X1, Y1)(X2, Y2)`  
Start with the point **closest to the origin (0, 0)**.

> If lengths are equal, print the **first line** only.

---

### 📝 Task 15: Multiplication Sign  
**Problem Statement:**  
You are given three numbers: `num1`, `num2`, `num3`.

Determine whether the **product** is `"positive"`, `"negative"`, or `"zero"` **without** multiplying the numbers.

---
