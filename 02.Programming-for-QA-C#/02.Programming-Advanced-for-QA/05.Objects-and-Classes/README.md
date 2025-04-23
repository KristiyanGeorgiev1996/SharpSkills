# Object and Classes – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Object and Classes** section of the _Programming Advanced for QA_ course at SoftUni. Each task is described briefly below.

---

## 🔧 Tasks Overview

### 📝 Task 1: Songs

**Problem Statement:**  
Define a class `Song` that holds the following information:
- `TypeList` (string)
- `Name` (string)
- `Time` (string)

**Input:**
- First line: an integer `N` – the number of songs.
- Next `N` lines: song data in the format:  
{typeList}{name}{time}
- Last line: a `TypeList` or `"all"`.

**Output:**
- If a specific `TypeList` is given, print only the names of the songs that match.
- If `"all"` is received, print the names of **all** songs.

---

### 📝 Task 2: Students

**Problem Statement:**  
Define a class `Student` with the following fields:
- `firstName` (string)
- `lastName` (string)
- `age` (int)
- `homeTown` (string)

**Input:**
- Read student data until the `"end"` command.
- Then read a city name.

**Output:**
- Print students from the given city in the format:
{firstName} {lastName} is {age} years old.

---

### 📝 Task 3: Store Boxes

**Problem Statement:**  
Define two classes:
- `Item` with properties: `Name` (string), `Price` (decimal)
- `Box` with properties:  
- `SerialNumber` (string)  
- `Item` (object of class Item)  
- `ItemQuantity` (int)  
- `PriceForABox` (decimal, calculated as `ItemQuantity * Item.Price`)

**Input:**
- Read lines in the format:  
{SerialNumber} {ItemName} {ItemQuantity} {ItemPrice}
- Stop reading when `"end"` is received.

**Output:**
- Print all boxes **ordered by total box price descending**, in the format:
{SerialNumber} -- {ItemName} – ${ItemPrice}: {ItemQuantity} -- ${TotalPrice}

- Prices should be formatted to **2 decimal places**.

---

### 📝 Task 4: Vehicle Catalogue

**Problem Statement:**  
Create a vehicle catalogue that stores only **Cars** and **Trucks**.

**Classes to define:**
- `Truck`: Brand, Model, Weight
- `Car`: Brand, Model, Horse Power
- `Catalog`: Lists of Cars and Trucks

**Input:**
- Read lines in the format:  
{type}/{brand}/{model}/{horsePower or weight}
- Stop reading when `"end"` is received.

**Output:**
- Print the vehicles ordered **alphabetically by brand** in the format:
Cars: {Brand}: {Model} - {Horse Power}hp

Trucks: {Brand}: {Model} - {Weight}kg

---

