# Arrays - Exercise – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Arrays - Exercise** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Train]  
**Problem Statement:**  
A train has n number of wagons (integer, received as input). On the next n lines, you will receive the number of people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the total number of passengers on the train.

---

### 📝 Task 2: [Common Elements]  
**Problem Statement:**  
Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.

---

### 📝 Task 3: [Zig-Zag Arrays]  
**Problem Statement:**  
Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers. Form 2 new arrays in a zig-zag pattern as shown below.

---

### 📝 Task 4: [Array Rotation]  
**Problem Statement:**  
Create a program that receives an array and several rotations that you have to perform. The rotations are done by moving the first element of the array from the front to the back. Print the resulting array.

---

### 📝 Task 5: [Top Integers]  
**Problem Statement:**  
Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the elements to its right.

---

### 📝 Task 6: [Equal Sums]  
**Problem Statement:**  
Create a program that determines if an element exists in an array for which the sum of all elements to its left is equal to the sum of all elements to its right. If there are no elements to the left or right, their sum is considered to be 0. Print the index of the element that satisfies the condition or "no" if there is no such element.

---

### 📝 Task 7: [Max Sequence of Equal Elements]  
**Problem Statement:**  
Create a program that finds the longest sequence of equal elements in an array of integers. If several equal sequences are present in the array, print out the leftmost one.

---

### 📝 Task 8: [Magic Sum]  
**Problem Statement:**  
Create a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.

---

### 📝 Task 9: [Kamino Factory]  
**Problem Statement:**  
The clone factory in Kamino got another order to clone troops. But this time you are tasked to find the best DNA sequence to use in the production.

You will receive the DNA length and until you receive the command "Clone them!", you will be receiving a DNA sequence of ones and zeroes, split by '!' (one or several).

You should select the sequence with the longest subsequence of ones. If there are several sequences with the same length of the subsequence of ones, print the one with the leftmost starting index, if there are several sequences with the same length and starting index, select the sequence with the greater sum of its elements.

After you receive the last command "Clone them!" you should print the collected information in the following format:

Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.
{DNA sequence, joined by space}

Input / Constraints

- The first line holds the length of the sequences – integer in the range [1…100].
- On the next lines, until you receive "Clone them!", you will be receiving sequences (at least one) of ones and zeroes, split by '!' (one or several).

Output

- Print the output as specified above.

---

### 📝 Task 10: [LadyBugs]  
**Problem Statement:**  
You are given a field size and the indexes where ladybugs can be found on the field. On every new line, until the "end" command is given, a ladybug changes its position either to its left or to its right by a given fly length.

A movement command looks like: "0 right 1". This means the ladybug at index 0 flies one step to the right. If the ladybug lands on another ladybug, it continues flying in the same direction by the fly length. If it flies outside the field, it is gone.

If the initial index does not contain a ladybug or is outside the field, nothing happens.

Print the final state of the field, where '1' represents a ladybug and '0' an empty cell, separated by spaces.

Input

- On the first line: integer - the size of the field.
- On the second line: initial indexes of all ladybugs (space separated).
- Next lines until "end": commands in the format "{ladybug index} {direction} {fly length}".

Output

- Print the field cells separated by spaces, with '1' for ladybugs and '0' for empty cells.

---

### 📝 Task 11: [Encrypt, Sort, and Print Array]  
**Problem Statement:**  
Write a program that reads a sequence of strings from the console. Encrypt every string by summing:

- The code of each vowel multiplied by the string length.
- The code of each consonant divided by the string length.

Sort the resulting numbers in ascending order and print them.

Input

- On the first line, receive the number of strings to read.

---

### 📝 Task 12: [Pascal Triangle]  
**Problem Statement:**  
Construct Pascal's Triangle as follows:  
Row 0 contains a single number 1. Each element in a subsequent row is the sum of the element above and to the left plus the element above and to the right (treating missing entries as 0).

Print each row with elements separated by spaces.

Hints:

- Input n will be between 1 and 60.
- Use an appropriate data type for the elements.
- You may use multiple arrays.

More info: https://en.wikipedia.org/wiki/Pascal's_triangle

---

### 📝 Task 13: [Recursive Fibonacci]  
**Problem Statement:**  
Implement a recursive function to calculate the nth Fibonacci number. The sequence starts as 1, 1, 2, 3, 5, 8, ... where each number is the sum of the two preceding ones.

Base cases:

- GetFibonacci(1) = 1
- GetFibonacci(2) = 1

Input:

- One integer n (1 ≤ n ≤ 50).

Output:

- The nth Fibonacci number.

---

### 📝 Task 14: [Fold and Sum]  
**Problem Statement:**  
Read an array of 4*k integers, fold it as shown below, and print the sum of the upper and lower two rows (each holding 2*k integers).

---

### 📝 Task 15: [Longest Increasing Subsequence (LIS)]  
**Problem Statement:**  
Read a list of integers and find the longest increasing subsequence (LIS). If several such subsequences exist, print the leftmost one.

Hints:

- Let `len[p]` be the length of the LIS ending at position p.
- For each p from 0 to n-1, find the leftmost position `left < p` where `len[left]` is largest.
- Then `len[p] = 1 + len[left]`. If no such left exists, `len[p] = 1`.
- Store previous indices in `prev[]` to reconstruct the LIS.
- After filling arrays, reconstruct LIS by backtracking from the position with the maximum length.

Example:

| index | 0 | 1  | 2 | 3  | 4  | 5 | 6 | 7 | 8 | 9 | 10 |
|-------|---|----|---|----|----|---|---|---|---|---|----|
| nums  | 3 | 14 | 5 | 12 | 15 | 7 | 8 | 9 |11 |10 | 1  |
| len   | 1 | 2  | 2 | 3  | 4  | 3 | 4 | 5 | 6 | 6 | 1  |
| prev  | -1| 0  | 0 | 2  | 3  | 2 | 5 | 6 | 7 | 7 | -1 |

LIS examples:

- {3}
- {3, 14}
- {3, 5}
- {3, 5, 12}
- {3, 5, 12, 15}
- {3, 5, 7}
- {3, 5, 7, 8}
- {3, 5, 7, 8, 9}
- {3, 5, 7, 8, 9, 11}
- {3, 5, 7, 8, 9, 10}
- {1}

---
