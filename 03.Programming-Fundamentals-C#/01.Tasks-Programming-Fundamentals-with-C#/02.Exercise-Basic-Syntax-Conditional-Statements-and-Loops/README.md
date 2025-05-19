# Basic Syntax, Conditional Statements and Loops - Exercise – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Basic Syntax, Conditional Statements and Loops - Exercise** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview:

### 📝 Task 1: Ages  
**Problem Statement:**  
Write a program that determines if a person is baby, child, teenager, adult or elder based on the given age. The boundaries are:

· 0-2 – baby  
· 3-13 – child  
· 14-19 – teenager  
· 20-65 – adult  
· >= 66 – elder  

All the values are inclusive.

---

### 📝 Task 2: Division  
**Problem Statement:**  
You will be given an integer. Write a program which checks if the given integer is divisible by 2, 3, 6, 7, or 10 without a remainder. You should always take the biggest division:

· If the number is divisible by 2, 3, and 6, print the division by 6 only.  
· If a number is divisible by 2 and 10, print the division by 10.

If the number is not divisible by any of the given numbers, print "Not divisible".  
Otherwise, print "The number is divisible by {number}".

---

### 📝 Task 3: Vacation  
**Problem Statement:**  
You will receive three lines from the console:

· A count of people going on vacation  
· Type of the group (Students, Business or Regular)  
· Day of the week (Friday, Saturday, or Sunday)

Prices per person:

| Type     | Friday | Saturday | Sunday |
|----------|--------|----------|--------|
| Students | 8.45   | 9.80     | 10.46  |
| Business | 10.90  | 15.60    | 16.00  |
| Regular  | 15.00  | 20.00    | 22.50  |

**Discounts:**

· Students: ≥30 people → 15% off  
· Business: ≥100 people → 10 people stay free  
· Regular: 10–20 people → 5% off  

**Output:**  
Print: `"Total price: {price}"`, formatted to 2 decimal places.

---

### 📝 Task 4: Print and Sum  
**Problem Statement:**  
You will receive two whole numbers from the console (start and end of a sequence).  

**Output:**  
- First line: all numbers from start to end inclusive  
- Second line: sum in format `"Sum: {sum}"`

---

### 📝 Task 5: Login  
**Problem Statement:**  
You will be given a username. The password is the reversed username.

· If incorrect password → print "Incorrect password. Try again."  
· If correct → print "User {username} logged in."  
· On the 4th failed attempt → print "User {username} blocked!"  

---

### 📝 Task 6: Strong Number  
**Problem Statement:**  
Write a program that checks if a number is strong.  
A number is strong if the sum of the factorials of its digits equals the number.

Example: 145 → 1! + 4! + 5! = 145 → "yes"  
Otherwise → "no"

---

### 📝 Task 7: Vending Machine  
**Problem Statement:**  
The program accumulates coins until "Start" is given.

**Valid coins:** 0.1, 0.2, 0.5, 1, 2  
Invalid → "Cannot accept {money}"

**Products (after "Start" command):**

· Nuts – 2.0  
· Water – 0.7  
· Crisps – 1.5  
· Soda – 0.8  
· Coke – 1.0  

If invalid product → "Invalid product"  
If enough money → "Purchased {product}"  
Else → "Sorry, not enough money"  

End with "Change: {money left}" (2 decimal points)

---

### 📝 Task 8: Triangle of Numbers  
**Problem Statement:**  
Write a program that receives a number `n` and prints a triangle from 1 to `n`.

**Constraints:**  
n ∈ [1...20]

---

### 📝 Task 9: Padawan Equipment  
**Problem Statement:**  
John is buying equipment for Jedi students.

**Each student needs:**
· Lightsaber  
· Robe  
· Belt

**Extra rules:**
· Buy 10% more lightsabers (rounded up)  
· Every 6th belt is free

**Input:**  
- Budget (0.00–1000.00)  
- Students (0–100)  
- Lightsaber price (0.00–100.00)  
- Robe price (0.00–100.00)  
- Belt price (0.00–100.00)

**Output:**  
- If enough: `"The money is enough - it would cost {cost}lv."`  
- Else: `"John will need {neededMoney}lv more."`  

All prices → 2 decimal places

---

### 📝 Task 10: Rage Expenses  
**Problem Statement:**  
Petar destroys gear after losing games:

· Every 2nd game – headset  
· Every 3rd game – mouse  
· Both headset & mouse → keyboard  
· Every 2nd keyboard → display  

**Input:**
· Lost games count (0–1000)  
· Prices for headset, mouse, keyboard, display (0.00–1000.00)

**Output:**  
`"Rage expenses: {expenses} lv."`

---

### 📝 Task 11: Orders  
**Problem Statement:**  
Calculate price for N coffee orders.

**Formula:**  
`(days * capsulesCount) * pricePerCapsule`

**Input:**
· N – order count  
Each order:  
- Price per capsule  
- Days  
- Capsules count  

**Output:**  
- Per order: `"The price for the coffee is: $price"`  
- Final line: `"Total: $totalPrice"`  

All prices → 2 decimal places

---

### 📝 Task 12: Sort Numbers  
**Problem Statement:**  
Receive 3 real numbers and print them in descending order (each on a new line).

---

### 📝 Task 13: English Name of the Last Digit  
**Problem Statement:**  
Write a method that returns the English word for the last digit of an integer.

---

### 📝 Task 14: Gaming Store  
**Problem Statement:**  
Simulate a game store purchase system.

**Valid games:**

| Game                        | Price  |
|----------------------------|--------|
| OutFall 4                  | 39.99  |
| CS: OG                     | 15.99  |
| Zplinter Zell              | 19.99  |
| Honored 2                  | 59.99  |
| RoverWatch                 | 29.99  |
| RoverWatch Origins Edition| 39.99  |

**Input:**
- Balance (0.00–5000.00)  
- Then game names until "Game Time"

**Rules:**
- If game not found → "Not Found"  
- If insufficient money → "Too Expensive"  
- If enough → "Bought {nameOfGame}"  
- If $0 left → "Out of money!"  
- On "Game Time" → show total spent and remaining balance

---

### 📝 Task 15: Reverse String  
**Problem Statement:**  
Write a program that reverses a string and prints it.

---

### 📝 Task 16: Messages  
**Problem Statement:**  
Simulate SMS typing based on this keypad:

1
2 abc
3 def
4 ghi
5 jkl
6 mno
7 pqrs
8 tuv
9 wxyz
0 (space)

Examples:  
- 2 → "a"  
- 22 → "b"  
- 222 → "c"

---
