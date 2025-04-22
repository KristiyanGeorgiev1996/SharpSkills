# First steps in coding - Exercise – Programming Basics with C# 🧑‍💻

This folder contains tasks from the **First steps in coding - Exercise** section of the _Programming Basics with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Console Converter: USD to BGN]  
**Problem Statement:**  
Write a program that converts US dollars (USD) to Bulgarian lev (BGN). Use a fixed exchange rate: 1 USD = 1.79549 BGN.

---

### 📝 Task 2: [Console Converter: Radians to Degrees]  
**Problem Statement:**  
Write a program that reads an angle in radians (a floating-point number) and converts it to degrees.  
Use the formula: degrees = radians * 180 / π.  
The number π in C# is available via `Math.PI`.

---

### 📝 Task 3: [Deposit Calculator]  
**Problem Statement:**  
Write a program that calculates the amount of money you will have at the end of a deposit period with a given interest rate.  
Use the formula:  
amount = deposited amount + deposit term * ((deposited amount * annual interest rate) / 12)

**Input:**
The console receives 3 lines:
1. Deposited amount – real number [100.00 … 10000.00]  
2. Deposit term (months) – integer [1…12]  
3. Annual interest rate – real number [0.00 … 100.00]

**Output:**
Print the final amount after the term.

---

### 📝 Task 4: [Required Reading]  
**Problem Statement:**  
During summer vacation, George has a set number of pages to read as required reading. Since he prefers to play with his friends, help him calculate how many hours per day he needs to dedicate to reading.

**Input:**
The console receives 3 lines:
1. Number of pages in the book – integer [1…1000]  
2. Pages read per hour – integer [1…1000]  
3. Number of days to finish the book – integer [1…1000]

**Output:**
Print the number of hours George needs to read each day.

---

### 📝 Task 5: [Supplies for School]  
**Problem Statement:**  
The school year has begun, and class monitor Annie needs to buy supplies: pens, markers, and board cleaner. She gets a discount, which is a percentage of the total cost.  
Calculate how much money Annie needs to collect.

**Prices:**
- Pack of pens – 5.80 BGN  
- Pack of markers – 7.20 BGN  
- Board cleaner (per liter) – 1.20 BGN

**Input:**
The console receives 4 numbers:
- Number of pen packs – integer [0...100]  
- Number of marker packs – integer [0...100]  
- Liters of cleaner – integer [0…50]  
- Discount percentage – integer [0...100]

**Output:**
Print the final cost after applying the discount.

---

### 📝 Task 6: [Repainting]  
**Problem Statement:**  
Rumen wants to repaint his living room and hires workers. Write a program to calculate the total cost of materials and labor.

**Prices:**
- Nylon – 1.50 BGN per sq.m.  
- Paint – 14.50 BGN per liter  
- Paint thinner – 5.00 BGN per liter

**Additional Requirements:**
- Add 10% more paint  
- Add 2 extra sq.m. of nylon  
- Add 0.40 BGN for bags  
- Labor cost per hour is 30% of the total material cost

**Input:**
The console receives 4 lines:
1. Needed nylon (sq.m.) – integer [1...100]  
2. Needed paint (liters) – integer [1…100]  
3. Paint thinner (liters) – integer [1…30]  
4. Hours needed – integer [1…9]

**Output:**
Print one line:  
- "{total cost}"

---

### 📝 Task 7: [Food Delivery]  
**Problem Statement:**  
A restaurant has opened and offers meal deals at fixed prices:

- Chicken menu – 10.35 BGN  
- Fish menu – 12.40 BGN  
- Vegetarian menu – 8.15 BGN

The group will also order dessert, which costs 20% of the total meal price (excluding delivery).  
Delivery costs 2.50 BGN and is added at the end.

**Input:**
The console receives 3 lines:
- Number of chicken menus – integer [0…99]  
- Number of fish menus – integer [0…99]  
- Number of vegetarian menus – integer [0…99]

**Output:**
Print one line:  
- "{total order price}"

---

### 📝 Task 8: [Basketball Equipment]  
**Problem Statement:**  
Jessie wants to start playing basketball and needs equipment.  
Write a program to calculate her expenses based on the annual training fee.

**Prices (relative to the training fee):**
- Shoes – 40% less than the training fee  
- Kit – 20% less than the shoes  
- Ball – 25% of the kit price  
- Accessories – 20% of the ball price

**Input:**
The console receives one line:
- Annual training fee – integer [0…9999]

**Output:**
Print one line:  
- Total cost for Jessie to start playing basketball

---

### 📝 Task 9: [Aquarium]  
**Problem Statement:**  
For his birthday, Lyubomir received a rectangular aquarium.  
Write a program to calculate how many liters of water it holds, considering a certain percentage of the volume is taken by decorations.

1 liter = 1 dm³.

**Input:**
The console receives 4 lines:
1. Length (cm) – integer [10 … 500]  
2. Width (cm) – integer [10 … 300]  
3. Height (cm) – integer [10 … 200]  
4. Percentage taken up by decorations – real number [0.000 … 100.000]

**Output:**
Print one number – the liters of water the aquarium can hold.
