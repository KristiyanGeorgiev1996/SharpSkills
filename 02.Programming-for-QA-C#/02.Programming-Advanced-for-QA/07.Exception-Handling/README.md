# Exception Handling – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Exception Handling** section of the _Programming Advanced for QA_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview:

### 📝 Task 1: Square Root

**Problem Statement:**  
Write a program that reads an integer number and calculates and prints its square root.

**Requirements:**
- If the number is negative, print:
Invalid number.
- In all cases, print:
Goodbye.

**Hint:**
- Use `try-catch-finally` structure.

---

### 📝 Task 2: Enter Numbers

**Problem Statement:**  
Write a method `ReadNumber(int start, int end)` that enters an integer number in a given range `(start…end)`, excluding `start` and `end`.  
If an invalid number or non-number text is entered, the method should throw an exception.

**Main Program Logic:**
- Read 10 numbers: `a1, a2, ..., a10`, such that:
1 < a1 < a2 < ... < a10 < 100
  - If the user enters an invalid number, continue prompting until 10 valid numbers are entered.
- Print the numbers, separated by comma and space `", "`.

**Messages:**
- If the entered value is not an integer:
Invalid Number!
- If the integer is out of range:
Your number is not in range {start} - 100!

---

### 📝 Task 3: Sum of Integers

**Problem Statement:**  
You will receive a sequence of elements of different types, separated by space.  
Your task is to calculate the sum of all **valid integer numbers** in the input.

**For each element:**
- If the element is not a valid format (e.g. string or special characters):  
The element '{element}' is in wrong format!
- If the element is out of the integer range:  
The element '{element}' is out of range!

**After each processed element:**
- Print:  
Element '{element}' processed - current sum: {sum}

**Final Output:**
- After all elements are processed, print:  
The total sum of all integers is: {sum}

---
