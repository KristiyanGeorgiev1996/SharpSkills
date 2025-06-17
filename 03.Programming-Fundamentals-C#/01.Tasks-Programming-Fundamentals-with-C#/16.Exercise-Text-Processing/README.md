# Text Processing - Exercise – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Text Processing - Exercise** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

---

### 📝 Task 1: Valid Usernames  
**Problem Statement:**  
Read a single line with usernames (separated by `", "`) and print all valid ones.

**A valid username:**  
- Has length between **3 and 16 characters**  
- Contains only **letters**, **numbers**, **hyphens** (`-`) and **underscores** (`_`)

---

### 📝 Task 2: Character Multiplier  
**Problem Statement:**  
Create a method that takes **two strings** and multiplies their character codes.

- Multiply `str1[i] * str2[i]`
- If one string is longer, add the remaining char codes directly to the result.

---

### 📝 Task 3: Extract File  
**Problem Statement:**  
Read a file path and extract the **file name** and **file extension**.

**Example:**  
Input: `C:\Internal\training-internal\Template.pptx`  
Output:  
File name: Template
File extension: pptx

---

### 📝 Task 4: Caesar Cipher  
**Problem Statement:**  
Encrypt a text by shifting each character **3 positions forward** in the ASCII table.

**Example:**  
`A` → `D`, `B` → `E`, etc.

---

### 📝 Task 5: Multiply Big Number  
**Problem Statement:**  
You are given:
- A **very big number** (up to 1050 digits)
- A **single-digit number** (0–9)

**Note:** Do **not** use `BigInteger`. Multiply them manually and print the result.

---

### 📝 Task 6: Replace Repeating Chars  
**Problem Statement:**  
Read a string and replace **any sequence of repeating characters** with a **single instance** of that character.

**Example:**  
Input: `aaaaabbbbbcdddeeeedssaa`  
Output: `abcdedsa`

---

### 📝 Task 7: String Explosion  
**Problem Statement:**  
In a string, explosions are triggered by `'>'` followed by a digit indicating the explosion strength.  
Remove characters accordingly. If another `'>'` appears during the explosion, increase the strength.

**Note:** The `'>'` remains, but digits used for strength should be removed.

---

### 📝 Task 8: Letters Change Numbers  
**Problem Statement:**  
You will be given strings like `"A12b"` or `"s17G"`. You must:

- Modify the number based on the surrounding letters.
- Sum all results.

**Rules:**  
- If the **first letter** is uppercase → divide by its alphabetical index.  
- If lowercase → multiply.  
- If the **last letter** is uppercase → subtract index.  
- If lowercase → add index.  

**Output:**  
Print total sum rounded to **2 decimal places**.

---
