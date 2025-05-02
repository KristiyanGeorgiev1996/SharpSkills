# Exercise - Lists – Programming Fundamentals and Unit Testing 🧑💻

This folder contains tasks from the **Exercise - Lists** section of the _Programming Fundamentals and Unit Testing_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Change List]  
**Problem Statement:**  
Create a program, that reads a list of integers from the console and receives commands to manipulate the list.

Your program may receive the following commands:

- "Delete {element}" – delete all elements in the array, which are equal to the given element.
- "Insert {element} {position}" – insert the element at the given position.

You should exit the program when you receive the "end" command. Print all numbers in the array, separated by a single whitespace.

---

### 📝 Task 2: [House Party]  
**Problem Statement:**  
Create a program that keeps track of the guests that are going to a house party.

On the first line, of input you are going to receive the number of commands that will follow.

On the next lines, you are going to receive some of the following:

- "{name} is going!"  
  - You have to add the person, if they are not on the guestlist already.
  - If the person is on the list print the following to the console: "{name} is already in the list!"

- "{name} is not going!"  
  - You have to remove the person, if they are on the list.
  - If not, print out: "{name} is not in the list!"

Finally, print all of the guests, each on a new line.

---

### 📝 Task 3: [List Operations]  
**Problem Statement:**  
The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.

The possible commands are:

- "Add {number}" – add the given number to the end of the list
- "Insert {number} {index}" – insert the number at the given index
- "Remove {index}" – remove the number at the given index
- "Shift left {count}" – first number becomes last. This has to be repeated the specified number of times
- "Shift right {count}" – last number becomes first. To be repeated the specified number of times

Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".

---

### 📝 Task 4: [List Manipulation Basics]  
**Problem Statement:**  
Write a program that:

- Reads a list of integers
- Then until you receive "end", you will receive different commands:
  - "Add {number}": add a number to the end of the list
  - "Remove {number}": remove a number from the list
  - "RemoveAt {index}": remove a number at a given index
  - "Insert {number} {index}": insert a number at a given index
- When you receive the "end" command, print the final state of the list (separated by spaces)

Note: All the indices will be valid!

---

### 📝 Task 5: [Bomb Numbers]  
**Problem Statement:**  
Write a program that:

- Reads a sequence of integer numbers from the first line of the console
- Read a special bomb number (integer) and its power (integer) from the second line of the console
- Detonate every occurrence of the special bomb number and according to its power - its neighbors from left and right
- Detonations are performed from left to right, and all detonated numbers disappear
- Print the sum of the remaining elements in the sequence

---
