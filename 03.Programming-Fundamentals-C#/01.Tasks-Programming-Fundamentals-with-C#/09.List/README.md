# 🧑‍💻 List – Programming Fundamentals with C#

This folder contains tasks from the **List** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview

### 📝 Task 1: Sum Adjacent Equal Numbers  
**Problem Statement:**  
Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, from left to right.

- After two numbers are summed, the result might be equal to some of its neighbors and should be summed as well.
- Always sum the **leftmost** two equal neighbors (if several exist).

---

### 📝 Task 2: Gauss' Trick  
**Problem Statement:**  
Create a program that sums all numbers in a list using Gauss' pairing method:

- Sum the first and last, the second and second-last, and so on.
- Continue this until all numbers are summed.

---

### 📝 Task 3: Merging Lists  
**Problem Statement:**  
You will receive two lists of numbers. Create a new list by alternating elements from each list:

- First element from the first list  
- Second element from the second list  
- And so on...  

If the lists are of different lengths, append the remaining elements at the end.

---

### 📝 Task 4: List of Products  
**Problem Statement:**  
Read a number `n` and then `n` product names (strings).  
Print a numbered list of all products **sorted alphabetically**.

---

### 📝 Task 5: Remove Negatives and Reverse  
**Problem Statement:**  
Read a list of integers.  
Remove all negative numbers and print the remaining elements **in reversed order**.

- If no elements are left → print `"empty"`.

---

### 📝 Task 6: List Manipulation Basics  
**Problem Statement:**  
Create a program that reads a list of integers. Then, until `"end"` is received, execute one of the following commands:

- `Add {number}` – Add number to the end of the list.  
- `Remove {number}` – Remove the number (first occurrence).  
- `RemoveAt {index}` – Remove the number at the given index.  
- `Insert {number} {index}` – Insert the number at the given index.  

> All indices are guaranteed to be valid.

At the end, print the final state of the list (space-separated).

---

### 📝 Task 7: List Manipulation Advanced  
**Problem Statement:**  
Extend the previous task with more complex list operations. Read the initial list and continue reading commands until `"end"` is received.

#### Available commands:

- `Contains {number}` – Print `"Yes"` if present, otherwise `"No such number"`.  
- `PrintEven` – Print all even numbers.  
- `PrintOdd` – Print all odd numbers.  
- `GetSum` – Print the sum of all elements.  
- `Filter {condition} {number}` – Print elements matching the condition: `<`, `>`, `>=`, `<=`.

> After the `"end"` command, print the final list **only if it has been modified** (via the commands from Task 6).

---
