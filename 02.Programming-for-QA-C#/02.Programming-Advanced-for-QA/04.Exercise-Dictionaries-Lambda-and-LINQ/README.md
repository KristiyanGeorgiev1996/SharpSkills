# Dictionaries, Lambda and LINQ - Exercise – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Dictionaries, Lambda and LINQ - Exercise** section of the _Programming Advanced for QA_ course at SoftUni. Each task is described briefly below.

---

## 🔧 Tasks Overview

### 📝 Task 1: Count Chars in a String

**Problem Statement:**  
Create a program that:
- Counts all characters in a string, **excluding spaces**.
- Prints the results in the following format:
{char} -> {occurrences}

---

### 📝 Task 2: A Miner Task

**Problem Statement:**  
Create a program that:
- Reads strings line by line: every **odd line** is a resource name, and every **even line** is a quantity.
- Collects and stores the total quantity for each resource.
- Prints each resource and its total quantity in the format:
{resource} -> {quantity}

**Notes:**
- The quantity is in the range [1…2,000,000,000].

---

### 📝 Task 3: Orders

**Problem Statement:**  
Create a program that:
- Keeps track of products, each with a name, price, and quantity.
- If a product already exists:
- Update the quantity (add the new quantity).
- Update the price if it has changed.
- Continues receiving products until the command `"buy"` is given.

**Input Format:**
{name} {price} {quantity}

**Output Format:**
{productName} -> {totalPrice}

- The `totalPrice` is the product of the **latest price** and the **total quantity**.
- Format prices to **2 decimal places**.

---

### 📝 Task 4: SoftUni Parking

**Problem Statement:**  
Create a program that simulates an online parking validation system. It supports two commands:

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

**Problem Statement:**  
Create a program that:
- Reads `n` pairs of inputs: student name and their grade.
- Tracks all grades for each student.
- Keeps only students with an **average grade >= 4.50**.
- Prints results in the format:
{name} -> {averageGrade}
- Format the average grade to **2 decimal places**.

---

### 📝 Task 6: Company Users

**Problem Statement:**  
Create a program that:
- Keeps track of companies and their employees.
- Input format:
{companyName} -> {employeeId}
- The input ends with `"End"`.
- A company **cannot have duplicate employee IDs**.

**Output Format:**
{companyName} -- {id1} -- {id2} -- {idN}

---

