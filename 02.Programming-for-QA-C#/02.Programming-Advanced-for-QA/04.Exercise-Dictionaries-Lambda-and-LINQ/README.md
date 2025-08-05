# Dictionaries, Lambda and LINQ - Exercise – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Dictionaries, Lambda and LINQ - Exercise** section of the _Programming Advanced for QA_ course at SoftUni. Each task is described briefly below.

---

## 🔧 Tasks Overview

### 📝 Task 1: Count Chars in a String

**Description:**  
Write a program that:
- Counts how many times each character appears in a given string.
- Ignores all whitespace characters.

**Output Format:**  
{char} -> {occurrences}

---

### 📝 Task 2: A Miner Task

**Description:**  
Create a program that reads alternating lines of input:
- Odd lines contain resource names.
- Even lines contain quantities (integers).

**Requirements:**
- Track the **total quantity** collected for each resource.
- Continue reading until the end of input.

**Output Format:**  
{resource} -> {quantity}

---

### 📝 Task 3: Orders

**Description:**  
Develop a program that keeps track of product prices and quantities.

**Input Format:**  
{name} {price} {quantity}

**Rules:**
- If a product is already present:
  - Update its **quantity** by adding the new quantity.
  - Update its **price** to the latest value.

- Input ends when the command `"buy"` is received.

**Output Format:**  
{product} -> {total_price}
Where `total_price = latest_price * total_quantity`, formatted to **2 decimal places**.

---

### 📝 Task 4: SoftUni Parking

**Problem Statement:**  
Simulate a parking registration system that processes a series of commands.

- `"register {username} {licensePlateNumber}"`:
  - If the user is already registered, print:
    ```
    ERROR: already registered with plate number {licensePlateNumber}
    ```
  - Otherwise, register the plate and print:
    ```
    {username} registered {licensePlateNumber} successfully
    ```

- `"unregister {username}"`:
  - If the user is not found, print:
    ```
    ERROR: user {username} not found
    ```
  - Otherwise, unregister and print:
    ```
    {username} unregistered successfully
    ```

**After all commands, print the registry:**
{username} => {licensePlateNumber}

**Input:**
- First line: number of commands `n`
- Next `n` lines: commands as described

---

### 📝 Task 5: Student Academy

**Description:**  
Create a program that:
- Reads `n` student records (name and grade pairs).
- Aggregates all grades per student.
- Keeps only students with an **average grade of 4.50 or higher**.

**Output Format:**  
{name} -> {averageGrade}
- Format the average grade to **2 decimal places**.

---

### 📝 Task 6: Company Users

**Problem Statement:**  
Build a system that tracks employee assignments by company.
- Input format:
{companyName} -> {employeeId}
- The input ends with `"End"`.
- A company **cannot have duplicate employee IDs**.

**Output Format:**
{companyName} -- {id1} -- {id2} -- {idN}

---

**Note:** The tasks are adapted from the SoftUni course and have been reformulated to present clearer and more illustrative descriptions of each exercise.
