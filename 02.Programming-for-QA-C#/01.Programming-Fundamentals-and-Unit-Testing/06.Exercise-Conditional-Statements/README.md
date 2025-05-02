# Exercise - Conditional Statements – Programming Fundamentals and Unit Testing 🧑💻

This folder contains tasks from the **Exercise - Conditional Statements** section of the _Programming Fundamentals and Unit Testing_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview

### 📝 Task 1: Number Type
**Problem Statement:**  
Write a program that:

- Reads an integer number from the console  
- Based on the value:
  - Print `"negative"` if the number is less than 0  
  - Print `"positive"` if the number is greater than 0  
  - Print `"zero"` if the number is 0

---

### 📝 Task 2: ATM
**Problem Statement:**  
Write a program to simulate an ATM withdrawal:

- Reads 3 integers: `balance`, `withdraw`, and `limit`  
- Based on the values:
  - Print `"The withdraw was successful."` if balance is enough  
  - Print `"The limit was exceeded."` if withdraw exceeds the limit  
  - Print `"Insufficient availability."` if balance is not enough

---

### 📝 Task 3: Biggest of Five Numbers
**Problem Statement:**  
Write a program to find the biggest among 5 numbers:

- Reads 5 integers from the console  
- Prints the biggest number

> Note: The input will not contain equal numbers.

---

### 📝 Task 4: Number Operations
**Problem Statement:**  
Write a program to evaluate operations:

- Reads 2 real numbers and a math operator (`+`, `-`, `*`, `/`)  
- Applies the operation  
- Prints the result in format:  
  `"N1 operator N2 = result"` (formatted to 2 decimal places)

---

### 📝 Task 5: Vacation Expenses
**Problem Statement:**  
Write a program that calculates vacation expenses:

- Reads `season` (`"Spring"`, `"Summer"`, `"Autumn"`, `"Winter"`), `accommodation` (`"Hotel"` or `"Camping"`), and `number of days`  
- Uses a predefined price table per night (based on season and accommodation type)  
- Calculates total expense = `price per night × days`  
- Prints the total formatted to 2 decimal places

---

### 📝 Task 6: Product of Three Numbers
**Problem Statement:**  
Write a program that determines the sign of the product of three real numbers:

- Reads 3 real numbers  
- Prints:
  - `"positive"` if product is positive  
  - `"negative"` if product is negative  
  - `"zero"` if any number is zero  

> Try to solve without performing the actual multiplication.

---

### 📝 Task 7: Working Hours
**Problem Statement:**  
Write a program that checks if the company's office is open:

- Reads an integer hour and a string (day of week)  
- Office is open from 10 AM to 6 PM, Monday to Saturday  
- Prints:
  - `"open"` if within working hours  
  - `"closed"` otherwise

---

### 📝 Task 8: Fruit or Vegetable
**Problem Statement:**  
Write a program that:

- Reads a product (string)  
- Prints:
  - `"fruit"` if it’s `"banana"`, `"apple"`, `"kiwi"`, `"cherry"`, or `"lemon"`  
  - `"vegetable"` if it’s `"cucumber"`, `"pepper"`, or `"carrot"`  
  - `"unknown"` otherwise

---

### 📝 Task 9: Sum Seconds
**Problem Statement:**  
Three athletes finish in a certain number of seconds (1–50).  
Write a program that:

- Reads 3 integers (their times in seconds)  
- Calculates total time  
- Outputs the result in format `"minutes:seconds"`  
> Seconds should have leading zero (e.g., `"02"`, `"07"`, `"35"`)

---

### 📝 Task 10: Summer Outfit
**Problem Statement:**  
Victor needs clothing advice based on temperature and time of day.  
Write a program that:

- Reads:
  - Temperature (integer from 10 to 42)  
  - Time of day (`"Morning"`, `"Afternoon"`, or `"Evening"`)  
- Determines proper clothing and shoes based on a predefined table  
- Prints:
  - `"It's {temperature} degrees, get your {clothing} and {shoes}."`
 
| **Temperature**        | **Morning**                  | **Afternoon**                 | **Evening**                   |
|------------------------|------------------------------|-------------------------------|-------------------------------|
| **10 ≤ t ≤ 18**        | Sweatshirt & Sneakers        | Shirt & Moccasins             | Shirt & Moccasins             |
| **18 < t ≤ 24**        | Shirt & Moccasins            | T-Shirt & Sandals             | Shirt & Moccasins             |
| **t ≥ 25**             | T-Shirt & Sandals            | Swim Suit & Barefoot          | Shirt & Moccasins             |

---
