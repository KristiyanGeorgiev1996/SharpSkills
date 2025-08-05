# Exception Handling – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Exception Handling** section of the _Programming Advanced for QA_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview:

### Task 1: Square Root Calculation

**Description:**  
Create a program that reads an integer from input and attempts to compute its square root.

**Behavior:**
- If the input number is negative, output:  
  `Invalid number.`  
- Regardless of the input, always print:  
  `Goodbye.`

**Implementation Tip:**  
Use a `try-catch-finally` block to handle exceptions and ensure `Goodbye.` is printed.

---

### Task 2: Number Input with Range Validation

**Description:**  
Implement a method named `ReadNumber(int start, int end)` that reads an integer within the exclusive range `(start, end)`.

**Details:**
- If the input is not a valid integer or outside the allowed range, the method should throw an exception.
- Your main program should collect 10 valid integers `a1, a2, ..., a10` satisfying:  
  `1 < a1 < a2 < ... < a10 < 100`
- If an invalid value is entered, prompt the user again until all 10 valid numbers are read.

**Error Messages:**
- For non-integer input:  
  `Invalid Number!`
- For integers outside the range:  
  `Your number is not in range {start} - 100!`

**Output:**  
After successfully reading all numbers, print them separated by commas and spaces, like:  
`a1, a2, ..., a10`

---

### Task 3: Summation of Integers from Mixed Input

**Description:**  
You will be given a sequence of elements separated by spaces, which can be of different data types. Your goal is to calculate the sum of all valid integers among these elements.

**Processing Rules:**
- For each element:
  - If it cannot be parsed as an integer (invalid format), print:  
    `The element '{element}' is in wrong format!`
  - If the element is outside the valid integer range, print:  
    `The element '{element}' is out of range!`
- After processing each element (whether added or skipped), print:  
  `Element '{element}' processed - current sum: {sum}`

**Final Output:**  
After all elements have been processed, print:  
`The total sum of all integers is: {sum}`
