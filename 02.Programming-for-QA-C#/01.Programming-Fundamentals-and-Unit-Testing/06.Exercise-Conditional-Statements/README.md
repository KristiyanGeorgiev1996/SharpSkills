# Exercise - Conditional Statements – Programming Fundamentals and Unit Testing 🧑💻

This folder contains tasks from the **Exercise - Conditional Statements** section of the _Programming Fundamentals and Unit Testing_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview

### Task 1: Number Type Classification

Create a program that reads an integer from the console and determines its type by value:

- Print `"negative"` if the number is less than zero  
- Print `"positive"` if the number is greater than zero  
- Print `"zero"` if the number equals zero

---

### Task 2: ATM Withdrawal Simulation

Develop a program that simulates an ATM withdrawal process by reading three integers: current balance, withdrawal amount, and withdrawal limit. Based on these values:

- Print `"The withdraw was successful."` if the withdrawal amount does not exceed both the balance and the limit  
- Print `"The limit was exceeded."` if the withdrawal amount is greater than the allowed limit  
- Print `"Insufficient availability."` if the balance is insufficient to cover the withdrawal

---

### Task 3: Find the Largest Number Among Five

Write a program to read five distinct integers from the user and output the largest of them. Assume no duplicates in input.

---

### Task 4: Basic Arithmetic Operations

Implement a program that:

- Reads two floating-point numbers and a mathematical operator (`+`, `-`, `*`, or `/`)  
- Performs the specified operation  
- Prints the operation and the result in the format:  
  `"N1 operator N2 = result"`  
- Ensure the result is displayed with two decimal places

---

### Task 5: Vacation Cost Calculator

Create a program that calculates the total cost of a vacation based on:

- Season (`"Spring"`, `"Summer"`, `"Autumn"`, or `"Winter"`)  
- Accommodation type (`"Hotel"` or `"Camping"`)  
- Number of days  
- Use a predefined pricing table for price per night depending on season and accommodation  
- Output the total cost formatted to two decimal places

---

### Task 6: Sign of Product of Three Numbers

Design a program that:

- Reads three real numbers  
- Determines the sign of their product without calculating the actual product  
- Prints:
  - `"positive"` if the product is positive  
  - `"negative"` if the product is negative  
  - `"zero"` if any of the input numbers is zero

---

### Task 7: Office Working Hours Checker

Write a program to verify if a company office is open based on the input hour and day of the week.

- The office operates Monday to Saturday from 10:00 AM to 6:00 PM  
- Print `"open"` if the office is open at the given hour and day  
- Print `"closed"` otherwise

---

### Task 8: Identify Fruit or Vegetable

Create a program that:

- Reads a product name  
- Prints `"fruit"` if the product is one of: banana, apple, kiwi, cherry, lemon  
- Prints `"vegetable"` if the product is one of: cucumber, pepper, carrot  
- Prints `"unknown"` for any other product

---

### Task 9: Total Time in Minutes and Seconds

Write a program that:

- Reads the times in seconds (integers between 1 and 50) for three athletes  
- Calculates the total time  
- Prints the total in the format `"minutes:seconds"`, ensuring seconds always have two digits (with leading zero if necessary)

---

### Task 10: Clothing Recommendation Based on Temperature and Time

Develop a program that:

- Reads the temperature (integer between 10 and 42) and time of day (`"Morning"`, `"Afternoon"`, `"Evening"`)  
- Suggests appropriate clothing and footwear according to the following chart:

| Temperature Range     | Morning              | Afternoon           | Evening             |
|----------------------|----------------------|---------------------|---------------------|
| 10 ≤ temp ≤ 18       | Sweatshirt & Sneakers | Shirt & Moccasins   | Shirt & Moccasins   |
| 18 < temp ≤ 24       | Shirt & Moccasins    | T-Shirt & Sandals   | Shirt & Moccasins   |
| temp ≥ 25            | T-Shirt & Sandals    | Swim Suit & Barefoot| Shirt & Moccasins   |

- Output format:  
  `"It's {temperature} degrees, get your {clothing} and {shoes}."`

**Note:** The tasks are adapted from the SoftUni course and have been reformulated to present clearer and more illustrative descriptions of each exercise.
