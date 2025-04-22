# More Complex Statements - Exercise – Programming Basics with C# 🧑‍💻

This folder contains tasks from the **More Complex Statements - Exercise** section of the _Programming Basics with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Cinema]  
**Problem Statement:**  
In a cinema hall, the seats are arranged in a rectangular form with r rows and c columns. There are three types of screenings with tickets at different prices:

- Premiere – a premiere screening, priced at 12.00 leva.
- Normal – a standard screening, priced at 7.50 leva.
- Discount – a screening for children, students, and students at a discounted price of 5.00 leva.

Write a program that reads the type of screening (string), the number of rows and columns in the hall (integers) entered by the user, and calculates the total revenue from tickets when the hall is full. The result should be printed in the format of the examples below, with two decimal places.

---

### 📝 Task 2: [Summer Clothing]  
**Problem Statement:**  
It's summer with very changeable weather, and Viktor needs your help. Write a program that, based on the time of day and the temperature, recommends what clothes Viktor should wear. Your friend has different plans for each part of the day, which require different outfits. You can see them in the table.

Two inputs are read from the console:

- Temperature - an integer in the range [10…42]
- Time of day - a text, which can be: "Morning", "Afternoon", "Evening"

| Time of Day     | Temperature 10-18  | Temperature 18-24  | Temperature 25+ |
| --------------- | ------------------ | ------------------ | --------------- |
| Morning         | Outfit = Sweatshirt, Shoes = Sneakers | Outfit = Shirt, Shoes = Moccasins | Outfit = Shirt, Shoes = Moccasins |
| Afternoon       | Outfit = Shirt, Shoes = Moccasins | Outfit = T-Shirt, Shoes = Sandals | Outfit = Shirt, Shoes = Moccasins |
| Evening         | Outfit = Shirt, Shoes = Moccasins | Outfit = Shirt, Shoes = Moccasins | Outfit = Shirt, Shoes = Moccasins |

Print:  
"It's {temperature} degrees, get your {outfit} and {shoes}."

---

### 📝 Task 3: [New House]  
**Problem Statement:**  
Marin and Neli are buying a house near Sofia. Neli loves flowers so much that she convinces you to write a program that calculates how much it will cost to plant a certain number of flowers and whether the available budget will be enough. Different flowers have different prices.

| Flower         | Price per unit in leva |
| -------------- | ---------------------- |
| Rose           | 5                      |
| Dahlia         | 3.80                   |
| Tulip          | 2.80                   |
| Narcissus      | 3                      |
| Gladiolus      | 2.50                   |

There are the following discounts:

- If Neli buys more than 80 Roses – a 10% discount on the total price.
- If Neli buys more than 90 Dahlias – a 15% discount on the total price.
- If Neli buys more than 80 Tulips – a 15% discount on the total price.
- If Neli buys less than 120 Narcissus – the price increases by 15%.
- If Neli buys less than 80 Gladioluses – the price increases by 20%.

The program should print:

- "Hey, you have a great garden with {number of flowers} {flower type} and {remaining budget} leva left."
- "Not enough money, you need {required amount} leva more."

---

### 📝 Task 4: [Fishing Boat]  
**Problem Statement:**  
Toni and his friends are very passionate about fishing, so they decide to rent a boat. The cost of renting the boat depends on the season and the number of fishermen.

The rental price depends on the season:

- Spring – 3000 leva
- Summer and Autumn – 4200 leva
- Winter – 2600 leva

There are discounts based on the number of people in the group:

- If the group has up to 6 people, they get a 10% discount.
- If the group has between 7 and 11 people, they get a 15% discount.
- If the group has 12 or more people, they get a 25% discount.

An additional 5% discount is given if the group is even-numbered, except in autumn, when no additional discount is applied.

The program should print:

- "Yes! You have {remaining money} leva left."
- "Not enough money! You need {amount needed} leva."

---

### 📝 Task 5: [Trip]  
**Problem Statement:**  
A young programmer has a specific budget and free time during a given season. Write a program that accepts the budget and season as inputs and calculates where the programmer will vacation and how much they will spend.

The destination is determined by the budget, and the season determines how much of the budget will be spent. If it’s summer, they will camp, and if it’s winter, they will stay in a hotel. If the destination is Europe, regardless of the season, the vacation will be in a hotel.

Here are the destination rules based on the budget:

- Up to 100 leva – in Bulgaria
    - Summer – 30% of the budget
    - Winter – 70% of the budget
- Up to 1000 leva – in the Balkans
    - Summer – 40% of the budget
    - Winter – 80% of the budget
- More than 1000 leva – in Europe
    - Regardless of season – 90% of the budget

The program should print:

- "Somewhere in {destination}"
- "{Vacation type} - {Spent amount}"

---

### 📝 Task 6: [Operations between Numbers]  
**Problem Statement:**  
Write a program that reads two integers (N1 and N2) and an operator, and performs the specified mathematical operation with them. The possible operations are: Addition (+), Subtraction (-), Multiplication (*), Division (/), and Modulus (%). When adding, subtracting, or multiplying, print the result and whether it is even or odd. For division, print the result. For modulus, print the remainder. Be aware that division by zero should print a special message.

The program should print:

- For division: "{N1} / {N2} = {result}" (formatted to two decimal places)
- For modulus: "{N1} % {N2} = {remainder}"
- If dividing by zero: "Cannot divide {N1} by zero"

---

### 📝 Task 7: [Hotel Room]  
**Problem Statement:**  
A hotel offers two types of rooms: a studio and an apartment. Write a program that calculates the total price for the entire stay for a studio and apartment. The prices depend on the month of the stay:

| Month         | Studio Price | Apartment Price |
| ------------- | ------------ | --------------- |
| May, October  | 50 leva      | 65 leva          |
| June, September | 75.20 leva  | 68.70 leva       |
| July, August  | 76 leva      | 77 leva          |

Discounts are available:

- Studio:
  - More than 7 nights in May/October: 5% off
  - More than 14 nights in May/October: 30% off
  - More than 14 nights in June/September: 20% off
- Apartment:
  - More than 14 nights in any month: 10% off

The program should print:

- "Apartment: {total cost for the entire stay} leva."
- "Studio: {total cost for the entire stay} leva."

---

### 📝 Task 8: [On Time for the Exam]  
**Problem Statement:**  
A student needs to attend an exam at a specific time (e.g., 9:30 AM). They arrive at the exam hall at a certain time (e.g., 9:40 AM). The student is considered on time if they arrive at the exam time or up to 30 minutes before. If they arrive more than 30 minutes early, they are early. If they arrive after the exam time, they are late.

The program should print:

- "Late" if the student arrives after the exam time.
- "On time" if the student arrives on time or up to 30 minutes early.
- "Early" if the student arrives more than 30 minutes early.

If the student arrives at least one minute after the exam time, print:

- "{minutes} minutes after the start"
- If the delay is 1 hour or more: "{hours}:{minutes} hours after the start"

---

### 📝 Task 9: [Ski Vacation]  
**Problem Statement:**  
Atanas decides to spend his vacation in Bansko and go skiing. Before he leaves, he needs to book a hotel and calculate the cost of his stay. The following types of rooms are available, with the corresponding prices per night:

- "room for one person" – 18.00 leva
- "apartment" – 25.00 leva
- "president apartment" – 35.00 leva

Depending on the number of days (e.g., 11 days = 10 nights) and the type of room, there are discounts:

| Room Type            | Less than 10 days | 10-15 days | More than 15 days |
| -------------------- | ----------------- | ---------- | ----------------- |
| room for one person  | No discount       | No discount| No discount       |
| apartment            | 30% off           | 35% off    | 50% off           |
| president apartment  | 10% off           | 15% off    | 20% off           |

After the stay, Atanas will evaluate the hotel. If his evaluation is positive, an additional 25% is added to the discounted price. If negative, 10% is subtracted.

The program should print:

- The total cost for the stay, formatted to two decimal places.

