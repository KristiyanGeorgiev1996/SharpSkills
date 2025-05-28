# Objects and Classes – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Objects and Classes** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

---

### 📝 Task 1: Randomize Words  
**Problem Statement:**  
You will be given a string that will contain words separated by a single space. Randomize their order and print each word on a new line.  

**Hints:**  
- Split the input string by space and create an array of words.  
- Create a random number generator – an object `rnd` of type `Random`.  
- In a `for` loop exchange each word at positions `0, 1, ..., words.Length - 1` with a word at a random position.  
- To generate a random number in range use `rnd.Next(minValue, maxValue)`.  
  > Note: `minValue` is inclusive, `maxValue` is exclusive.  
- Print each word in the array on a new line.

---

### 📝 Task 2: Big Factorial  
**Problem Statement:**  
You will receive a number `N` in the range `[0…1000]`. Calculate the factorial of `N` and print out the result.

---

### 📝 Task 3: Songs  
**Problem Statement:**  
Define a class called `Song` that will hold the following information about some songs:  
- Type List  
- Name  
- Time  

**Input / Constraints:**  
- On the first line, you will receive the number of songs - `N`.  
- On the next `N` lines, you will be receiving data in the following format:  
{typeList}{name}{time}
- On the last line, you will receive either a specific `Type List` or the keyword `"all"`.  

**Output:**  
- If a `Type List` is given, print only the names of the songs from that list.  
- If the `"all"` command is received, print out the names of all the songs.

---

### 📝 Task 4: Students  
**Problem Statement:**  
Define a class called `Student`, which will hold the following information about some students:  
- First Name  
- Last Name  
- Age  
- Home Town  

**Input / Constraints:**  
- Read information about some students until you receive the `"end"` command.  
- After that, you will receive a city name.  

**Output:**  
- Print the students who are from the given city in the following format:  
{firstName} {lastName} is {age} years old.

---

### 📝 Task 5: Students 2.0  
**Problem Statement:**  
Use the class from the previous problem.  
If you receive a student who already exists (first name and last name are unique), overwrite their information.

---

### 📝 Task 6: Store Boxes  
**Problem Statement:**  
Define a class `Item` with the following properties:  
- Name  
- Price  

Define a class `Box` with the following properties:  
- Serial Number  
- Item  
- Item Quantity  
- Price for a Box  

**Input:**  
- Until you receive `"end"`, you will be receiving data in the following format:  
{Serial Number} {Item Name} {Item Quantity} {itemPrice}

**Calculation:**  
- Price of a box = `itemQuantity * itemPrice`

**Output:**  
- Print all boxes ordered descending by price for a box in the following format:  
{boxSerialNumber}
-- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}
-- ${boxPrice}
  - The price should be formatted to 2 digits after the decimal separator.

---

### 📝 Task 7: Vehicle Catalogue  
**Problem Statement:**  
Your task is to create a Vehicle catalog that contains only Trucks and Cars.

**Classes:**  
- `Truck` with properties: Brand, Model, Weight  
- `Car` with properties: Brand, Model, Horse Power  
- `Catalog` with properties: Collections of Trucks and Cars  

**Input:**  
- Read input until you receive the `"end"` command.  
- Input format:  
{type}/{brand}/{model}/{horse power / weight}

**Output:**  
- Print all vehicles ordered alphabetically by brand in the following format:  
Cars:
{Brand}: {Model} - {Horse Power}hp

Trucks:
{Brand}: {Model} - {Weight}kg

---
