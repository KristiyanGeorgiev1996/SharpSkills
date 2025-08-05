# Exercise - Lists – Programming Fundamentals and Unit Testing 🧑💻

This folder contains tasks from the **Exercise - Lists** section of the _Programming Fundamentals and Unit Testing_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

---

### Task 1: Change List  
Write a program that:

- Reads a list of integers from the console.
- Continuously reads commands until the `"end"` command is received.
- Supports the following commands:
  - `"Delete {element}"` – removes all occurrences of the given element from the list.
  - `"Insert {element} {position}"` – inserts the element at the specified position in the list.
- After the `"end"` command, prints the final state of the list, with elements separated by a single space.

---

### Task 2: House Party  
Write a program that:

- Reads an integer `n`, representing the number of commands.
- Reads `n` commands, each in one of the following formats:
  - `"{name} is going!"` – adds the person to the guest list if not already present; otherwise prints: `"{name} is already in the list!"`
  - `"{name} is not going!"` – removes the person from the guest list if present; otherwise prints: `"{name} is not in the list!"`
- After processing all commands, prints all guests currently on the list, each on a new line.

---

### Task 3: List Operations  
Write a program that:

- Reads a list of integers from the console.
- Continues reading commands until the `"End"` command is received.
- Supports the following commands:
  - `"Add {number}"` – appends the number to the end of the list.
  - `"Insert {number} {index}"` – inserts the number at the specified index.
  - `"Remove {index}"` – removes the element at the specified index.
  - `"Shift left {count}"` – shifts the list to the left `count` times; each shift moves the first element to the end.
  - `"Shift right {count}"` – shifts the list to the right `count` times; each shift moves the last element to the front.
- Prints `"Invalid index"` if an index provided is out of bounds.

---

### Task 4: List Manipulation Basics  
Write a program that:

- Reads a list of integers from the console.
- Continuously reads commands until the `"end"` command is received.
- Supports the following commands:
  - `"Add {number}"` – adds the number at the end of the list.
  - `"Remove {number}"` – removes the first occurrence of the number from the list.
  - `"RemoveAt {index}"` – removes the element at the given index.
  - `"Insert {number} {index}"` – inserts the number at the specified index.
- All given indices will be valid.

---

### Task 5: Bomb Numbers  
Write a program that:

- Reads a sequence of integers from the console.
- Reads a special bomb number and its power (both integers).
- For every occurrence of the bomb number, removes it and its neighbors according to the power value.
- Detonations are performed from left to right, and all detonated numbers are removed.
- Prints the sum of the remaining elements after all detonations.

---

**Note:** The tasks are adapted from the SoftUni course and have been reformulated to present clearer and more illustrative descriptions of each exercise.
