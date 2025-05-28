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

### 📝 Task 9: Extract Person Information  
**Problem Statement:**  
Extract a person's name and age from a sentence.

**Input Example:**  
`Hello my name is @Peter| and I am #20* years old.`  
**Output:**  
`Peter is 20 years old.`

---

### 📝 Task 10: ASCII Sumator  
**Problem Statement:**  
- Read two characters and a text string.
- Find all characters between the given two (by ASCII value).
- Print the **sum** of their ASCII values found in the text.

---

### 📝 Task 11: Treasure Finder  
**Problem Statement:**  
- Use a sequence of numbers (key) to **decrypt** each line.
- Decrypt by subtracting the key values from the characters in the message (loop the key).
- Extract treasure type between `&` and coordinates between `< >`.

**Output Format:**  
`Found {type} at {coordinates}`

---

### 📝 Task 12: Morse Code Translator  
**Problem Statement:**  
Translate **Morse code** to **uppercase English letters**.  
- Words are separated by `' | '`.  
- Letters by a single space `' '`.  

**Example Input:**  
`.--. .-. --- --. .-. .- -- -- .. -. --. | .. ... | ..-. ..- -.`  
**Output:**  
`PROGRAMMING IS FUN`

---

### 📝 Task 13: HTML  
**Problem Statement:**  
Input:
1. A **title**  
2. An **article**  
3. Multiple **comments** (until `"end of comments"`)

**Output Format (in HTML):**  
```html
<h1>{title}</h1>
<article>{content}</article>
<div>{comment1}</div>
<div>{comment2}</div>
...
