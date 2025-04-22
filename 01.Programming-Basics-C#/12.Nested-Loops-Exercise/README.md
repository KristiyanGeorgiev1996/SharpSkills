# Nested Loops - Exercise – Programming Basics with C# 🧑‍💻

This folder contains tasks from the **Nested Loops - Exercise** section of the _Programming Basics with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Number Pyramid]  
**Problem Statement:**  
Write a program that reads an integer n, entered by the user, and prints a pyramid of numbers as shown in the examples:

**Input / Output examples:**

- Input: 7  
  Output:  
  1  
  1 2  
  1 2 3  
  1 2 3 4  
  1 2 3 4 5  
  1 2 3 4 5 6  
  1 2 3 4 5 6 7

- Input: 10  
  Output:  
  1  
  1 2  
  1 2 3  
  1 2 3 4  
  1 2 3 4 5  
  1 2 3 4 5 6  
  1 2 3 4 5 6 7  
  1 2 3 4 5 6 7 8  
  1 2 3 4 5 6 7 8 9  
  1 2 3 4 5 6 7 8 9 10

- Input: 12  
  Output:  
  1  
  1 2  
  1 2 3  
  1 2 3 4  
  1 2 3 4 5  
  1 2 3 4 5 6  
  1 2 3 4 5 6 7  
  1 2 3 4 5 6 7 8  
  1 2 3 4 5 6 7 8 9  
  1 2 3 4 5 6 7 8 9 10  
  1 2 3 4 5 6 7 8 9 10 11  
  1 2 3 4 5 6 7 8 9 10 11 12

---

### 📝 Task 2: [Equal Sums of Even and Odd Positions]  
**Problem Statement:**  
Write a program that reads two six-digit integers in the range from 100000 to 300000 from the console. The first number will always be smaller than the second number. Print on the console, in one line separated by spaces, all numbers between the two numbers that satisfy the following condition:

- The sum of the digits at even and odd positions must be equal. If no numbers satisfy the condition, print nothing.

---

### 📝 Task 3: [Sum of Prime and Non-Prime Numbers]  
**Problem Statement:**  
Write a program that reads integers from the console until the command "stop" is entered. The program should find the sum of all prime numbers and the sum of all non-prime numbers. Since negative numbers cannot be prime, if a negative number is entered, the program should print "Number is negative." and ignore that number (it should not be added to either sum). The program should then continue waiting for the next number.

On the output, print the two sums in the following format:

- "Sum of all prime numbers is: {prime numbers sum}"
- "Sum of all non prime numbers is: {nonprime numbers sum}"

---

### 📝 Task 4: [Train the Trainers]  
**Problem Statement:**  
The "Train the Trainers" course is nearing its end, and the final assessments are approaching. Your task is to help the jury evaluate the presentations by writing a program that calculates the average grade for each presentation from a given student, and finally, the average grade for all of them.

The first input line will be the number of people in the jury, n – an integer in the range [1…20].

Then, on a new line, the name of the presentation will be read.

For each presentation, n grades will be entered on new lines – real numbers in the range [2.00…6.00].

After calculating the average grade for a presentation, print the following on the console:

- "{presentation name} - {average grade}."

When the command "Finish" is received, the program will print:  
- "Student's final assessment is {average grade for all presentations}."  
And the program will end.

All grades must be formatted to two decimal places.

---

### 📝 Task 5: [Special Numbers]  
**Problem Statement:**  
Write a program that reads an integer N entered by the user, and generates all possible "special" numbers from 1111 to 9999. A number is considered "special" if it satisfies the following condition:

- N must be divisible by each of its digits without remainder.

Example: for N = 16, 2418 is a special number:

- 16 / 2 = 8 with no remainder
- 16 / 4 = 4 with no remainder
- 16 / 1 = 16 with no remainder
- 16 / 8 = 2 with no remainder

**Input:**  
The input consists of one integer in the range [1…600000].

**Output:**  
Print all "special" numbers separated by a space on the console.

---

### 📝 Task 6: [Cinema Tickets]  
**Problem Statement:**  
Your task is to write a program that calculates the percentage of tickets sold for each type of ticket: student, standard, and kid, for all movie screenings. You also need to calculate the percentage of the cinema hall that is filled for each screening.

**Input:**  
The input consists of integers and text:

- The first line contains the movie name – text.
- The second line contains the number of free seats in the cinema hall for each screening – an integer [1…100].
- For each movie, a line is read for each ticket sold until the hall is full or the command "End" is entered:
  - The type of ticket purchased – text ("student", "standard", "kid").

**Output:**  
After each movie, print the following:

- "{movie name} - {percentage of cinema hall filled}% full."

When the command "Finish" is received, print four lines:

- "Total tickets: {total number of tickets sold for all movies}"
- "{percentage of student tickets}% student tickets."
- "{percentage of standard tickets}% standard tickets."
- "{percentage of kids tickets}% kids tickets."
