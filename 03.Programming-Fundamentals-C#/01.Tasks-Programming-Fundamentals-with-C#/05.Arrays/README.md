# Arrays – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Arrays** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: Day of Week
**Problem Statement:**  
Enter a number in range 1-7 and print out the word representing it or "Invalid day!". Use an array of strings.

---

### 📝 Task 2: Print Numbers in Reverse Order  
**Problem Statement:**  
Read n numbers and print them in reverse order, separated by a single space.

Hints:

First, we need to read n from the console.

---

### 📝 Task 3: Rounding Numbers 
**Problem Statement:**  
Read an array of real numbers (space separated), round them in "away from 0" style and print the output.

---

### 📝 Task 4: Reverse Array of Strings 
**Problem Statement:**  
Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence of space-separated strings. Print the output on a single line (space separated).

---

### 📝 Task 5: Sum Even Numbers 
**Problem Statement:**  
Read an array from the console and sum only its even values.

---

### 📝 Task 6: Even and Odd Subtraction  
**Problem Statement:**  
Create a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.

---

### 📝 Task 7: Equal Arrays  
**Problem Statement:**  
Read two arrays and determine whether they are identical or not. The arrays are identical if all their elements are equal.  
If the arrays are identical, find the sum of the elements of one of them and print the following message to the console:  
`"Arrays are identical. Sum: {sum}"`  
Otherwise, find the first index where the arrays differ and print:  
`"Arrays are not identical. Found difference at {index} index"`

---

### 📝 Task 8: Condense Array to Number  
**Problem Statement:**  
Create a program to read an array of integers and condense them by summing all adjacent couples of elements until a single integer remains.

For example:  
Given the array `{2, 10, 3}`, sum the first two and the second two elements to get `{12, 13}`, then sum adjacent elements again to get `{25}`.

Hints:

While we have more than one element in the array `nums[]`, repeat the following:

- Allocate a new array `condensed[]` of size `nums.length - 1`.

- Sum the numbers from `nums[]` to `condensed[]`:  
  `condensed[i] = nums[i] + nums[i + 1]`

- Assign `nums = condensed`

---
