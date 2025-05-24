# 🧑‍💻 Data Types and Variables – Programming Fundamentals with C#

This repository contains tasks from the **Data Types and Variables** section of the _Programming Fundamentals with C#_ course at SoftUni.

## 🔧 Tasks Overview

### 📝 Task 1: Convert Meters to Kilometers  
**Description:**  
Given an integer representing a distance in meters, create a program that converts meters to kilometers, formatted to the second decimal point.

---

### 📝 Task 2: Pounds to Dollars  
**Description:**  
Create a program that converts British Pounds to US Dollars, formatted to the third decimal point.  
> 💱 1 British Pound = 1.31 US Dollars

---

### 📝 Task 3: Exact Sum of Real Numbers  
**Description:**  
Create a program to enter `n` numbers and calculate their exact sum (without rounding).

---

### 📝 Task 4: Centuries to Minutes  
**Description:**  
Create a program that converts an integer number of centuries into years, days, hours, and minutes.  
> 🔍 Use appropriate data types and assume a year has 365.2422 days on average (Tropical year).

---

### 📝 Task 5: Special Numbers  
**Description:**  
A number is special if the sum of its digits is 5, 7, or 11.  
Write a program to read an integer `n` and print whether each number in the range 1…n is special (`True/False`).  
> 💡 Hint: Use modulus and division to sum digits.

---

### 📝 Task 6: Reversed Chars  
**Description:**  
Read three characters from input and print them in reversed order, separated by spaces.

---

### 📝 Task 7: Concat Names  
**Description:**  
Read two names and a delimiter, then print the names joined by the delimiter.

---

### 📝 Task 8: Town Info  
**Description:**  
Given three lines of input — town name, population, and area — output the information in the format:  
Town {town name} has population of {population} and area {area} square km.

---

### 📝 Task 9: Chars to String  
**Description:**  
Read three characters (one per line), combine them into a single string, and print it.

---

### 📝 Task 10: Lower or Upper  
**Description:**  
Create a program that determines if a given character is upper-case or lower-case.

---

### 📝 Task 11: Refactor Volume of Pyramid  
**Description:**  
Refactor the given code to improve variable names and reduce variable lifespan. Avoid using the same variable for multiple purposes.

**Sample Code (Before Refactor):**
```csharp
double dul, sh, V = 0;

Console.WriteLine("Length: ");
dul = double.Parse(Console.ReadLine());

Console.WriteLine("Width: ");
sh = double.Parse(Console.ReadLine());

Console.WriteLine("Heigth: ");
V = double.Parse(Console.ReadLine());

V = (dul + sh + V) / 3;

Console.WriteLine($"Pyramid Volume: {V:f2}");
💡 Suggestions:

Use meaningful variable names (e.g., length, width, height)

Declare variables at the point of initialization

Avoid multipurpose variables

---

### 📝 Task 12: Refactor Special Numbers
Description:
Refactor the code solving Task 5 to improve readability, naming, and logic structure.

Sample Code (Before Refactor):
int kolkko = int.Parse(Console.ReadLine());
int obshto = 0;
int takova = 0;
bool toe = false;

for (int ch = 1; ch <= kolkko; ch++)
{
    takova = ch;
    while (ch > 0)
    {
        obshto += ch % 10;
        ch = ch / 10;
    }
    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
    Console.WriteLine("{0} -> {1}", takova, toe);
    obshto = 0;
    ch = takova;
}
💡 Suggestions:

Rename variables (toe → isSpecialNum, etc.)

Eliminate reuse of variables for different purposes

Improve clarity and maintainability 
