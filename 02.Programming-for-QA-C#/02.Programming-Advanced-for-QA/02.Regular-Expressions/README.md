# Regular Expressions – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Regular Expressions** section of the _Programming Advanced for QA_ course at SoftUni. Each task is described briefly below.

---

## 🔧 Tasks Overview

### 📝 Task 1: Match Full Name

**Description:**  
Create a program that scans a given text and extracts valid full names based on specific formatting rules.

**A valid full name must:**
- Consist of exactly **two words**.
- Each word must start with a **capital letter** followed by only **lowercase letters**.
- Each word must be at least **two characters long**.
- The two words must be separated by **a single space**.

**Example Input:**  
`"John Smith, mary Jane, Peter Johnson"`

**Expected Output:**  
`John Smith Peter Johnson`

---

### 📝 Task 2: Match Phone Number

**Description:**  
Write a program that uses regular expressions to identify valid Bulgarian phone numbers (specifically from Sofia) from a block of text.

**A valid phone number must:**
- Begin with `+359`.
- Follow with the area code `2`.
- Include a 7-digit subscriber number, divided into two groups: **3 digits and 4 digits**.
- Allow separators: **a space or a hyphen** (`-`) between the groups.
- Use the **same separator throughout** each number.

**Valid Formats:**  
- `+359 2 222 2222`  
- `+359-2-222-2222`

**Output:**  
Display all matching phone numbers, separated by a comma and a space.

---

### 📝 Task 3: Match Dates

**Description:**  
Develop a program that reads text and extracts dates formatted in a specific pattern using regular expressions with named groups.

**A valid date must:**
- Use the format: `dd{separator}MMM{separator}yyyy`
  - `dd`: Two-digit day
  - `MMM`: Three-letter month abbreviation (e.g., Jan, Feb), where the first letter is uppercase
  - `yyyy`: Four-digit year
- Use consistent separators: either `.`, `-`, or `/`
- The same separator must be used throughout the date (enforced via backreference)

**Requirements:**
- Utilize **named capturing groups** in your regex for day, month, and year.

**Output:**  
Print each matched date on a separate line.

---

**Note:** The tasks are adapted from the SoftUni course and have been reformulated to present clearer and more illustrative descriptions of each exercise.
