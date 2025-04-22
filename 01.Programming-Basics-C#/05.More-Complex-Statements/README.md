# More Complex Statements – Programming Basics with C# 🧑‍💻

This folder contains tasks from the **More Complex Statements** section of the _Programming Basics with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Day of the Week]  
**Problem Statement:**  
Write a program that reads an integer from the user and prints the corresponding day of the week (in English) in the range [1...7]. If the number is not valid, print "Error".

---

### 📝 Task 2: [Working Day or Weekend]  
**Problem Statement:**  
Write a program that reads a day of the week (text in English) from the user. If it’s a working day, print "Working day". If it’s a weekend, print "Weekend". If the input is not a valid day, print "Error".

---

### 📝 Task 3: [Animal Type]  
**Problem Statement:**  
Write a program that prints the class of an animal based on its name, entered by the user.

- "dog" → "mammal"  
- "crocodile", "tortoise", "snake" → "reptile"  
- All others → "unknown"

---

### 📝 Task 4: [Personal Titles]  
**Problem Statement:**  
Write a console program that reads age (real number) and gender ('m' or 'f') entered by the user, and prints an appropriate title:

- "Mr." – male ('m') aged 16 or older  
- "Master" – male under 16  
- "Ms." – female ('f') aged 16 or older  
- "Miss" – female under 16

---

### 📝 Task 5: [Small Shop]  
**Problem Statement:**  
A businessman opens small shops in several cities and sells products at different prices:

| City   | coffee | water | beer | sweets | peanuts |
|--------|--------|-------|------|--------|---------|
| Sofia  | 0.50   | 0.80  | 1.20 | 1.45   | 1.60    |
| Plovdiv| 0.40   | 0.70  | 1.15 | 1.30   | 1.50    |
| Varna  | 0.45   | 0.70  | 1.10 | 1.35   | 1.55    |

Write a program that reads the product (string), the city (string), and the quantity (decimal number), and calculates and prints the total cost.

---

### 📝 Task 6: [Number in Range]  
**Problem Statement:**  
Write a program that checks if a given number (entered by the user) is in the range [-100, 100] and not equal to 0. If so, print "Yes", otherwise print "No".

---

### 📝 Task 7: [Working Hours]  
**Problem Statement:**  
Write a program that reads the hour of the day (integer) and a day of the week (text) from the user. It checks if the office is open. Working hours are from 10 to 18, Monday to Saturday (inclusive).

---

### 📝 Task 8: [Cinema Ticket]  
**Problem Statement:**  
Write a program that reads a day of the week (text) from the user and prints the ticket price for that day:

- Monday, Tuesday, Friday → 12  
- Wednesday, Thursday → 14  
- Saturday, Sunday → 16

---

### 📝 Task 9: [Fruit or Vegetable]  
**Problem Statement:**  
Write a program that reads the name of a product and checks if it's a fruit, vegetable, or unknown.

- Fruits: banana, apple, kiwi, cherry, lemon, grapes → "fruit"  
- Vegetables: tomato, cucumber, pepper, carrot → "vegetable"  
- Others → "unknown"

---

### 📝 Task 10: [Invalid Number]  
**Problem Statement:**  
A number is valid if it’s in the range [100…200] or if it is 0. Write a program that reads an integer and prints "invalid" if the number is not valid.

---

### 📝 Task 11: [Fruit Shop]  
**Problem Statement:**  
A fruit shop sells items at different prices depending on the day of the week.

**Weekday Prices:**

| Fruit     | Price |
|-----------|-------|
| banana    | 2.50  |
| apple     | 1.20  |
| orange    | 0.85  |
| grapefruit| 1.45  |
| kiwi      | 2.70  |
| pineapple | 5.50  |
| grapes    | 3.85  |

**Weekend Prices:**

| Fruit     | Price |
|-----------|-------|
| banana    | 2.70  |
| apple     | 1.25  |
| orange    | 0.90  |
| grapefruit| 1.60  |
| kiwi      | 3.00  |
| pineapple | 5.60  |
| grapes    | 4.20  |

Write a program that reads a fruit (banana / apple / orange / grapefruit / kiwi / pineapple / grapes), a day of the week (Monday / ... / Sunday), and a quantity (real number). Print the total price formatted to 2 decimal places. If the input is invalid, print "error".

---

### 📝 Task 12: [Trade Commissions]  
**Problem Statement:**  
A company offers the following sales commissions based on the city and the sales volume:

| City    | 0 ≤ s ≤ 500 | 500 < s ≤ 1,000 | 1,000 < s ≤ 10,000 | s > 10,000 |
|---------|-------------|-----------------|---------------------|------------|
| Sofia   | 5%          | 7%              | 8%                  | 12%        |
| Varna   | 4.5%        | 7.5%            | 10%                 | 13%        |
| Plovdiv | 5.5%        | 8%              | 12%                 | 14.5%      |

Write a console program that reads the city (string) and the sales volume (real number), calculates and prints the commission amount. Format the result to 2 decimal places. If the input is invalid (invalid city or negative sales), print "error".
