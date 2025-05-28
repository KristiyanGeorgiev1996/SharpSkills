# Regular Expressions – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Regular Expressions** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

---

### 📝 Task 1: Match Full Name  
**Problem Statement:**  
Write a C# Program to match full names from a list of names and print them on the console.

**Writing the Regular Expression**  
Create a regex to match a valid full name, according to these conditions:

- A valid full name consists of **two words**.
- Each word starts with a **capital letter**.
- After the first letter, it only contains **lowercase letters**.
- Each word should be at least **two letters long**.
- The two words are separated by a **single space**.

**Steps to create the RegEx:**

1. Use an online regex tester like [regex101.com](https://regex101.com/).
2. Use character sets denoted with square brackets `[]`.
3. Specify that you want **two words with a space between them** (the space character `' '` only).
4. Each word begins with an uppercase letter `[A-Z]`.
5. Followed by one or more lowercase letters `[a-z]+`.
6. Use `\b` at the start and end to mark word boundaries.

**Test the RegEx** with the following values:

| Match ALL of these          | Match NONE of these                                  |
|----------------------------|-----------------------------------------------------|
| Bethany Taylor             | John Smith Bethany Taylor, Oliver miller,           |
| John Smith                 | sophia Johnson, SARah Wilson, John Smith, Sam Smith|

---

### 📝 Task 2: Match Phone Number  
**Problem Statement:**  
Create a regular expression to match valid phone numbers from Sofia. After finding all valid phones, print them separated by `", "`.

**Valid number characteristics:**

- Starts with `"+359"`.
- Followed by the area code, which is always `2`.
- Followed by the number itself: 7 digits divided into two groups: 3 and 4 digits.
- Parts separated by either a space or a hyphen (`-`).
- Use a **capturing group** to ensure the delimiter is consistent (space or hyphen).
- Add a **word boundary** at the end.
- Ensure before the '+' there is either a space or the beginning of the string.

**Test the RegEx** with:

| Match ALL of these       | Match NONE of these                                       |
|-------------------------|----------------------------------------------------------|
| +359 2 222 2222         | 359-2-222-2222, +359/2/222/2222, +359-2 222 2222         |
| +359-2-222-2222         | +359 2-222-2222, +359-2-222-222, +359-2-222-22222         |

---

### 📝 Task 3: Match Dates  
**Problem Statement:**  
Write a program to match dates in the format `dd{separator}MMM{separator}yyyy` using **named capturing groups**.

**Date characteristics:**

- Starts with **two digits** (`dd`), followed by a separator.
- Then one uppercase and two lowercase letters (`MMM`), e.g. `Jan`, `Mar`.
- Then the **same separator**.
- Followed by exactly **4 digits** (`yyyy`).
- Separator can be `.`, `-`, or `/`.
- The separator must be consistent across the date (use **group backreference**).

**Test the RegEx** with:

| Match ALL of these             | Match NONE of these                |
|-------------------------------|----------------------------------|
| 13/Jul/1928                   | 01/Jan-1951                     |
| 10-Nov-1934                   | 23/sept/1973                    |
| 25.Dec.1937                  | 1/Feb/2016                     |

---

**Use named capturing groups for:**

- `day`
- `month`
- `year`

---

