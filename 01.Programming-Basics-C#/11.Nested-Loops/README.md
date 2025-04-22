# Nested Loops – Programming Basics with C# 🧑‍💻

This folder contains tasks from the **Nested Loops** section of the _Programming Basics with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Clock]  
**Problem Statement:**  
Write a program that prints the hours of the day from 0:0 to 23:59, each on a separate line. The hours should be displayed in the format "{hour}:{minutes}".

---

### 📝 Task 2: [Multiplication Table]  
**Problem Statement:**  
Print the multiplication table for the numbers from 1 to 10 in the format: "{first multiplier} * {second multiplier} = {result}".

---

### 📝 Task 3: [Combinations]  
**Problem Statement:**  
Write a program that calculates how many solutions exist in natural numbers (including zero) for the equation:

x1 + x2 + x3 = n

The number n is an integer entered from the console.

---

### 📝 Task 4: [Sum of Two Numbers]  
**Problem Statement:**  
Write a program that checks all possible pairs of numbers within a given range. The output should display the combination number where the sum of the numbers equals a given magic number. If no combination meets the condition, print a message stating that no combination was found.

**Input:**

The input is read from the console and consists of three lines:
- First line – start of the range – an integer in the range [1...999]
- Second line – end of the range – an integer greater than the first one, in the range [start number...1000]
- Third line – magic number – an integer in the range [1...10000]

**Output:**

On the console, print one of the following lines:
- If a combination whose sum equals the magic number is found:
  - "Combination N:{combination number} ({first number} + {second number} = {magic number})"
- If no combination matching the condition is found:
  - "{total number of combinations} combinations - neither equals {magic number}"

---

### 📝 Task 5: [Travel]  
**Problem Statement:**  
Ani loves traveling and wants to visit several different destinations this year. After choosing a destination, she will determine how much money she needs to get there and will start saving. Once she has saved enough, she will be able to travel.

The program will read the destination and the required minimum budget first.

Then, several amounts of money will be read as Ani saves money by working, and when she saves enough to go on the trip, the program should print:
- "Going to {destination}!"

When she has visited all the destinations she wanted, instead of a destination, she will enter "End" and the program will terminate.

---

### 📝 Task 6: [Building]  
**Problem Statement:**  
Write a program that prints the room numbers in a building (in descending order) while following these conditions:

- Every even floor contains only offices
- Every odd floor contains only apartments
- Each apartment is labeled as: A{floor number}{apartment number}, where apartment numbers start from 0.
- Each office is labeled as: O{floor number}{office number}, where office numbers also start from 0.
- The top floor always has apartments, and they are larger than the others, so they are labeled with 'L' instead of 'A'. If there is only one floor, it only contains large apartments!

Two integers are read from the console: the number of floors and the number of rooms on each floor.
