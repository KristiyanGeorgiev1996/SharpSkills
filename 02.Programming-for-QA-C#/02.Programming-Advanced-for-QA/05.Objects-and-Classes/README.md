# Object and Classes – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Object and Classes** section of the _Programming Advanced for QA_ course at SoftUni. Each task is described briefly below.

---

## 🔧 Tasks Overview

### 📝 Task 1: Songs Collection

**Description:**  
Create a class `Song` that holds the following properties:  
- `TypeList` (string)  
- `Name` (string)  
- `Time` (string)  

**Input:**  
- The first line contains an integer `N` – the number of songs.  
- The next `N` lines contain song details in the format:  
  `{TypeList}{Name}{Time}`  
- The last line contains either a specific `TypeList` or the word `"all"`.

**Output:**  
- If a specific `TypeList` is provided, print only the names of the songs matching that type.  
- If `"all"` is given, print the names of all songs.

---

### 📝 Task 2: Student Records

**Description:**  
Define a class `Student` with the following fields:  
- `firstName` (string)  
- `lastName` (string)  
- `age` (int)  
- `homeTown` (string)  

**Input:**  
- Read student information until the `"end"` command is received.  
- Then read the name of a city.

**Output:**  
- Print the details of the students from the specified city in the format:  
  `{firstName} {lastName} is {age} years old.`

---

### 📝 Task 3: Warehouse Boxes

**Description:**  
Create two classes:  
- `Item` with properties: `Name` (string), `Price` (decimal)  
- `Box` with properties:  
  - `SerialNumber` (string)  
  - `Item` (an instance of the `Item` class)  
  - `ItemQuantity` (int)  
  - `PriceForABox` (decimal), calculated as `ItemQuantity * Item.Price`

**Input:**  
- Read lines in the format:  
  `{SerialNumber} {ItemName} {ItemQuantity} {ItemPrice}`  
- Stop reading input when `"end"` is received.

**Output:**  
- Print all boxes ordered by their total price (`PriceForABox`) in descending order, in the format:  
  `{SerialNumber} -- {ItemName} – ${ItemPrice}: {ItemQuantity} -- ${PriceForABox}`  
- Prices should be formatted to 2 decimal places.

---

### 📝 Task 4: Vehicle Catalogue

**Description:**  
Build a vehicle catalogue that stores only Cars and Trucks.

**Classes:**  
- `Truck` with properties: Brand, Model, Weight  
- `Car` with properties: Brand, Model, Horse Power  
- `Catalog` containing lists of Cars and Trucks

**Input:**  
- Read input lines in the format:  
  `{type}/{brand}/{model}/{horsePower or weight}`  
- Stop reading when `"end"` is entered.

**Output:**  
- Print the vehicles ordered alphabetically by brand, in the format:  
  `Cars:`  
  `{Brand}: {Model} - {Horse Power}hp`  
  `Trucks:`  
  `{Brand}: {Model} - {Weight}kg`

---

**Note:** The tasks are adapted from the SoftUni course and have been reformulated to present clearer and more illustrative descriptions of each exercise.
