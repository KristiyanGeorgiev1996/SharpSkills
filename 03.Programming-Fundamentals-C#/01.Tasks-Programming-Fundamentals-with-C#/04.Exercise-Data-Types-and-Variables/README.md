# Data Types and Variables - Exercise – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Data Types and Variables - Exercise** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview:

---

### 📝 Task 1: Integer Operations

**Problem Statement:**  
Create a program that receives four integer numbers.

You should perform the following operations:

- Add first to the second.
- Divide (integer) the result of the first operation by the third number.
- Multiply the result of the second operation by the fourth number.

Print the result after the last operation.

**Constraints**

- First number will be in the range [-2,147,483,648…2,147,483,647].
- Second number will be in the range [-2,147,483,648…2,147,483,647].
- Third number will be in the range [-2,147,483,648…2,147,483,647].
- Fourth number will be in the range [-2,147,483,648…2,147,483,647].

---

### 📝 Task 2: Sum Digits

**Problem Statement:**  
Create a program that receives a single integer. Your task is to find the sum of its digits.

For example:  
`12345 → 1 + 2 + 3 + 4 + 5 = 15`

---

### 📝 Task 3: Elevator

**Problem Statement:**  
Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p persons. The input holds two lines: the number of people n and the capacity p of the elevator.

**Hints**

- You should divide n by p. This gives you the number of full courses (e.g. 17 / 3 = 5).
- If n does not divide p without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).
- Another approach is to round up n / p to the nearest integer (ceiling), e.g. 17 / 3 = 5.67 → rounds up to 6.
- Sample code for the round-up calculation:

---

### 📝 Task 4: Sum of Chars

**Problem Statement:**  
Create a program, which sums the ASCII codes of n characters and prints the sum on the console.

**Input**

- On the first line, you will receive n – the number of lines, which will follow.
- On the next n lines – you will receive letters from the Latin alphabet.

**Output**

Print the total sum in the following format:  
`"The sum equals: {totalSum}"`

**Constraints**

- n will be in the interval [0…20].
- The characters will always be either upper or lower-case letters from the English alphabet.
- You will always receive one letter per line.

---

### 📝 Task 5: Print Part of the ASCII Table

**Problem Statement:**  
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints part of the ASCII table of characters at the console. On the first line of input, you will receive the char index you should start with, and on the second line - the index of the last character you should print.

---

### 📝 Task 6: Triples of Latin Letters

**Problem Statement:**  
Create a program that receives an integer n and print all triples of the first n small Latin letters, ordered alphabetically:

**Hints**

Perform 3 nested loops from 0 to n-1.

---

### 📝 Task 7: Water Overflow

**Problem Statement:**  
You have a water tank with a capacity of 255 liters. On the next n lines, you will receive liters of water, which you have to pour into your tank. If the capacity is not enough, print `"Insufficient capacity!"` and continue reading the next line. On the last line, print the liters in the tank.

**Input**

- The input will be on two lines:
  - On the first line, you will receive n – the number of lines, which will follow.
  - On the next n lines, you will receive quantities of water, which you have to pour into the tank.

**Output**

Every time you do not have enough capacity in the tank to pour the given liters, print:  
`Insufficient capacity!`

On the last line, print only the liters in the tank.

**Constraints**

- n will be in the interval [1…20]
- liters will be in the interval [1…1000]

---

### 📝 Task 8: Beer Kegs

**Problem Statement:**  
Create a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines. Every three lines will hold information for a single keg. First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.

Calculate the volume using the following formula:  
`π * r² * h`.

In the end, print the model of the biggest keg.

**Input**

You will receive 3 * n lines. Each group of lines will be on a new line:

- First – model – string
- Second – radius – floating-point number
- Third – height – integer number

**Output**

Print the model of the biggest keg.

**Constraints**

- n will be in the interval [1…10].
- The radius will be a floating-point number in the interval [1…3.402823E+38].
- The height will be an integer in the interval [1…2147483647].

---

### 📝 Task 9: Spice Must Flow

**Problem Statement:**  
Spice is Love, Spice is Life. And most importantly, Spice must flow. It must be extracted from the scorching sands of Arrakis, under the constant threat of giant sandworms. To make the work as efficient as possible, the Duke has tasked you with the creation of management software.

Create a program that calculates the total amount of spice that can be extracted from a source. The source has a starting yield, which indicates how much spice can be mined on the first day. After it has been mined for a day, the yield drops by 10, meaning on the second day it'll produce 10 less spice than on the first, on the third day 10 less than on the second, and so on (see examples). A source is considered profitable only while its yield is at least 100 – when less than 100 spices are expected in a day, abandon the source.

The mining crew consumes 26 spices every day at the end of their shift and an additional 26 after the mine has been exhausted. Note that the workers cannot consume more spice than there is in storage.

When the operation is complete, print on the console, on two separate lines, how many days the mine has operated and the total amount of spice extracted.

**Input**

You will receive a number, representing the starting yield of the source.

**Output**

Print on the console, on two separate lines, how many days the mine has operated and the total amount of spice extracted.

**Constraints**

- The starting yield will be a positive integer within the range [0…2147483647].

---

### 📝 Task 10: Pokemon

**Problem Statement:**  
A Pokemon is a special type of pokemon which likes to Poke others. But at the end of the day, the Pokemon wants to keep statistics, about how many pokes it has managed to make.

The Pokemon pokes his target and then proceeds to poke another target. The distance between its targets reduces his poke power.

You will be given the poke power the Pokemon has, N – an integer.

Then you will be given the distance between the poke targets, M – an integer.

Then you will be given the exhaustionFactor Y – an integer. Your task is to start subtracting M from N until N becomes less than M, i.e. the Pokemon does not have enough power to reach the next target. Every time you subtract M from N that means you've reached a target and poked it successfully. COUNT how many targets you've poked – you'll need that count.

The PokeMon becomes gradually more exhausted. IF N becomes equal to EXACTLY 50 % of its original value, you must divide N by Y, if it is POSSIBLE. This DIVISION is between integers.

If a division is not possible, you should NOT do it. Instead, you should continue subtracting.

After dividing, you should continue subtracting from N, until it becomes less than M.

When N becomes less than M, you must take what has remained of N and the count of targets you've poked, and print them as output.

**NOTE:** When you are calculating percentages, you should be PRECISE at maximum.

Example: 505 is NOT EXACTLY 50 % from 1000, its 50.5 %.

**Input**

- The input consists of 3 lines.
- On the first line, you will receive N – an integer.
- On the second line, you will receive M – an integer.
- On the third line, you will receive Y – an integer.

**Output**

- The output consists of 2 lines.
- On the first line, print what has remained of N, after subtracting from it.
- On the second line, print the count of targets, you've managed to poke.

**Constraints**

- The integer N will be in the range [1…2000000000].
- The integer M will be in the range [1…1000000].
- The integer Y will be in the range [0…9].
- Allowed time / memory: 16 MB / 100ms.

---

### 📝 Task 11: Snowballs

**Problem Statement:**  
Tony and Andi love playing in the snow and having snowball fights, but they always argue about which makes the best snowballs. They have decided to involve you in their fray by making you write a program, which calculates snowball data and outputs the best snowball value.

You will receive N – an integer, the number of snowballs being made by Tony and Andi. For each snowball you will receive 3 input lines:

- On the first line, you will get the snowballSnow – an integer.
- On the second line you will get the snowballTime – an integer.
- On the third line, you will get the snowballQuality – an integer.

For each snowball you must calculate its snowballValue by the following formula:

`(snowballSnow / snowballTime) ^ snowballQuality`

In the end, you must print the highest calculated snowballValue.

**Input**

- On the first input line, you will receive N – the number of snowballs.
- On the next N * 3 input lines, you will be receiving data about snowballs.

**Output**

As output, you must print the highest calculated snowballValue, by the formula, specified above.

The output format is:  
`{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})`

**Constraints**

- The number of snowballs (N) will be an integer in the range [0…100].
- The snowballSnow is an integer in the range [0…1000].
- The snowballTime is an integer in the range [1…500].
- The snowballQuality is an integer in the range [0…100].

---

### 📝 Task 12: Data Type Finder

**Problem Statement:**  
You will receive input until you receive `"END"`. Find what data type is the input. Possible data types are:

- Integer
- Floating point
- Characters
- Boolean
- Strings

Print the result in the following format:  
`"{input} is {data type} type"`.

---

### 📝 Task 13: From Left to the Right

**Problem Statement:**  
You will receive a number that represents how many lines we will get as input. On the next N lines, you will receive a string with 2 numbers, separated by a single space. You need to compare them. If the left number is greater than the right number, you need to print the sum of all digits in the left number, otherwise, print the sum of all digits in the right number.

---

### 📝 Task 14: Floating Equality

**Problem Statement:**  
Write a program that safely compares floating-point numbers (double) with precision `eps = 0.000001`. Note that we cannot directly compare two floating-point numbers a and b by `a == b`, because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more close to each other than some fixed constant eps.

You will receive two lines, each containing a floating-point number. Your task is to compare the values of the two numbers.

---

### 📝 Task 15: Refactoring: Prime Checker

**Problem Statement:**  
You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed `"{number} -> {true or false}"`. The code, however, is not very well written. Your job is to modify it in a way that is easy to read and understand.

---

### 📝 Task 16: Decrypting Messages

**Problem Statement:**  
You will receive a key (integer) and n characters afterward. Add the key to each of the characters and append them to a message. At the end print the message, which you decrypted.

**Input**

- On the first line, you will receive the key.
- On the second line, you will receive n – the number of lines, which will follow.
- On the next n lines, you will receive lower and uppercase characters from the Latin alphabet.

**Output**

Print the decrypted message.

**Constraints**

- The key will be in the interval [0…20].
- n will be in the interval [1…20].
- The characters will always be upper or lower-case letters from the English alphabet.
- You will receive one letter per line.

---

### 📝 Task 17: Balanced Brackets

**Problem Statement:**  
You will receive n lines. On those lines, you will receive one of the following:

- Opening bracket – `'('`,
- Closing bracket – `')'` or
- Random string

Your task is to find out if the brackets are balanced. That means after every closing bracket should follow an opening one. Nested parentheses are not valid and if two consecutive opening brackets exist, the expression should be marked as unbalanced.

**Input**

- On the first line, you will receive n – the number of lines, which will follow.
- On the next n lines, you will receive `'('`, `')'` or another string.

**Output**

You have to print `"BALANCED"`, if the parentheses are balanced and `"UNBALANCED"` otherwise.

**Constraints**

- n will be in the interval [1…20].
- The length of the strings will be between [1…100] characters.

---
