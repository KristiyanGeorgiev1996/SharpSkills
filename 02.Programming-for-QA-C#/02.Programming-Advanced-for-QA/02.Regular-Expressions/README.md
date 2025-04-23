# Regular Expressions – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Regular Expressions** section of the _Programming Advanced for QA_ course at SoftUni. Each task is described briefly below.

---

## 🔧 Tasks Overview

### 📝 Task 1: Match Full Name

**Problem Statement:**  
Write a program that:
- Reads a text from the console.
- Matches full names from the given text.

**A valid full name must:**
- Consist of **two words**.
- Each word must start with a **capital letter**, followed by **lowercase letters only**.
- Each word must be **at least two letters long**.
- The two words must be separated by a **single space**.

**Output:**  
Print all valid full names, separated by a single space.

---

### 📝 Task 2: Match Phone Number

**Problem Statement:**  
Write a program that:
- Reads a text from the console.
- Uses a regular expression to match valid phone numbers from Sofia.

**A valid phone number must:**
- Start with `+359`.
- Be followed by the area code `2`.
- Then, a 7-digit number divided into groups of 3 and 4 digits.
- Use either a **space** or a **hyphen (`-`)** as a separator between the groups.
- The separator must be **consistent** within a number.

**Example valid formats:**
+359 2 222 2222 +359-2-222-2222

**Output:**  
Print all matched numbers, separated by a comma and a space: `", "`.

---

### 📝 Task 3: Match Dates

**Problem Statement:**  
Write a program that:
- Reads a text from the console.
- Uses a regular expression to match **valid dates**.

**A valid date must:**
- Follow the format: `dd{separator}MMM{separator}yyyy`
  - `dd`: Two digits for the day.
  - `MMM`: A three-letter month abbreviation (e.g., Jan, Mar), with the first letter uppercase and the rest lowercase.
  - `yyyy`: A four-digit year.
- Use one of the following separators: `.`, `-`, or `/`.
- The same separator must be used throughout the date (use a group backreference).
- Use **named capturing groups** in the regex.

**Output:**  
Print each valid date on a **new line**.

---
