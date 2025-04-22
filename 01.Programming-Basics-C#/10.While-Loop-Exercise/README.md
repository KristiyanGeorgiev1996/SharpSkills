# While Loop - Exercise – Programming Basics with C# 🧑‍💻

This folder contains tasks from the **While Loop - Exercise** section of the _Programming Basics with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [The Old Library]  
**Problem Statement:**  
Ani goes back to her hometown after a long period abroad. Upon returning home, she sees her grandmother's old library and remembers her favorite book. Help Ani by writing a program in which she enters the book she is looking for (string). The program should keep reading the names of books one by one until Ani either finds her favorite book or checks all the books in the library. The program ends when it receives the command "No More Books."

- If the book is not found, print the following on two lines:
  - "The book you search is not here!"
  - "You checked {number} books."
- If the book is found, print:
  - "You checked {number} books and found it."

---

### 📝 Task 2: [Exam Preparation]  
**Problem Statement:**  
Write a program where Marin solves exam tasks until he gets the "Enough" message from his lecturer. After each solved task, he receives a grade. The program should end either upon receiving the "Enough" command or if Marin receives the specified number of failing grades. A failing grade is any grade less than or equal to 4.

**Input:**
- The first line contains the number of failing grades (an integer in the range [1…5]).
- Then, multiple lines follow with:
  - Task name (string)
  - Grade (integer in the range [2…6])

**Output:**
- If Marin receives the "Enough" command, print on 3 lines:
  - "Average score: {average score}"
  - "Number of problems: {total number of tasks}"
  - "Last problem: {name of the last task}"
- If Marin gets the specified number of failing grades, print:
  - "You need a break, {number of failing grades} poor grades."

The average score should be formatted to two decimal places.

---

### 📝 Task 3: [Holiday Savings]  
**Problem Statement:**  
Jesse wants to save money for a holiday and asks for your help to determine if she'll manage to gather the needed amount. She saves or spends part of her money every day. If she tries to spend more than her available money, she will spend all she has left, leaving 0 money.

**Input:**
- The first line contains the amount of money needed for the holiday (a real number in the range [1.00...25000.00]).
- The second line contains the available money (a real number in the range [0.00...25000.00]).
- Then, multiple lines follow with:
  - Action type (string with values "spend" or "save")
  - The amount spent or saved (a real number in the range [0.01…25000.00])

**Output:**
- If Jesse spends for 5 consecutive days, print:
  - "You can't save the money."
  - "{total number of days}"
- If Jesse manages to save the required amount for the holiday, print:
  - "You saved the money for {total number of days} days."

---

### 📝 Task 4: [Steps Goal]  
**Problem Statement:**  
Gabi wants to start living a healthy lifestyle and has set a goal to walk 10,000 steps every day. However, some days she’s very tired from work and might want to go home before reaching her goal. Write a program that reads the number of steps Gabi walks each time she leaves during the day, and when she reaches her goal, print "Goal reached! Good job!" along with how many extra steps she walked.

If she wants to go home early, she will enter the command "Going home" and input the steps walked while returning home. Afterward, if she hasn't reached her goal, print:
  - "{remaining steps} more steps to reach goal."

---

### 📝 Task 5: [Coins]  
**Problem Statement:**  
Vending machine manufacturers wanted to make sure their machines return the smallest possible number of coins as change. Write a program that takes an amount of money (change) and calculates how many coins it can be given back with the fewest possible coins.

---

### 📝 Task 6: [Cake]  
**Problem Statement:**  
You are invited to a 30th birthday party where the birthday person is serving a huge cake. However, the birthday person doesn’t know how many pieces of cake the guests can take. Your task is to write a program that calculates how many pieces the guests have taken before the cake runs out. You will receive the cake's dimensions (width and length) as integers in the range [1...1000]. Then, on each line, you will receive the number of pieces guests take until the command "STOP" is given or the cake runs out.

**Output:**
- If you reach the command "STOP" and there are still cake pieces left, print:
  - "{number of pieces} pieces are left."
- If the cake runs out, print:
  - "No more cake left! You need {number of pieces missing} pieces more."

---

### 📝 Task 7: [Moving]  
**Problem Statement:**  
On his 18th birthday, Jose decided to move out and live in an apartment. He packed his things in boxes and found a suitable apartment. He starts moving his things in parts since he can't carry everything at once. There's limited space in his new apartment, and he needs to make sure it’s enough for all his things.

Write a program that calculates the remaining space in Jose’s apartment after he moves in all his things.

**Input:**
- The first three lines contain the dimensions of the free space in the apartment: width, length, and height (all integers in the range [1…1000]).
- Then, subsequent lines contain the number of boxes moved in (integer in the range [1…10000]) until the command "Done" is entered.

**Output:**
- If you reach the "Done" command and there is still free space, print:
  - "{number of free cubic meters} Cubic meters left."
- If the free space runs out before the "Done" command, print:
  - "No more free space! You need {missing cubic meters} Cubic meters more."
