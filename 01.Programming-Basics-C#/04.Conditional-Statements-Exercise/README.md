# Conditional Statements - Exercise – Programming Basics with C# 🧑‍💻

This folder contains tasks from the **Conditional Statements - Exercise** section of the _Programming Basics with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Sum Seconds]  
**Problem Statement:**  
Three athletes finish a race in a certain number of seconds (between 1 and 50). Write a program that reads the times of the athletes and calculates their total time in the format "minutes:seconds". Seconds should always be displayed with a leading zero (e.g. 2 → "02", 7 → "07", 35 → "35").

---

### 📝 Task 2: [Bonus Score]  
**Problem Statement:**  
You are given an integer – the starting number of points. Bonus points are added based on the rules below. Write a program that calculates the bonus points and the total score (initial score + bonus).

- If the number is up to 100 (inclusive), the bonus is 5.
- If the number is more than 100 and less than or equal to 1000, the bonus is 20% of the number.
- If the number is more than 1000, the bonus is 10% of the number.

Additional bonus points (applied separately from the above):

- If the number is even → +1 point.
- If the number ends with 5 → +2 points.

---

### 📝 Task 3: [Time + 15 Minutes]  
**Problem Statement:**  
Write a program that reads the current hour and minutes in a 24-hour format and calculates the time after 15 minutes. The output should be in the format "hour:minutes". Hours are from 0 to 23, and minutes are from 0 to 59. Minutes must always be printed with two digits (with leading zero if needed).

---

### 📝 Task 4: [Toy Shop]  
**Problem Statement:**  
Petya owns a toy shop. She receives a large order and wants to use the profit to go on a vacation.

Toy prices:

- Puzzle – 2.60 lv.
- Talking doll – 3.00 lv.
- Teddy bear – 4.10 lv.
- Minion – 8.20 lv.
- Truck – 2.00 lv.

If 50 or more toys are ordered, there is a 25% discount on the total price. From the earned money, Petya must pay 10% for shop rent. Calculate whether the money is enough for the vacation.

**Input:**

1. Price of the vacation – real number [1.00 … 10000.00]  
2. Number of puzzles – integer [0…1000]  
3. Number of talking dolls – integer [0…1000]  
4. Number of teddy bears – integer [0…1000]  
5. Number of minions – integer [0…1000]  
6. Number of trucks – integer [0…1000]  

**Output:**

- If the money is enough:  
  `Yes! {money left} lv left.`
- If not enough:  
  `Not enough money! {money needed} lv needed.`

Result must be formatted to 2 decimal places.

---

### 📝 Task 5: [Godzilla vs. Kong]  
**Problem Statement:**  
Filming for the much-anticipated "Godzilla vs. Kong" movie is starting. The director asks you to write a program to calculate whether the allocated budget is sufficient.

Details:

- Set decoration costs 10% of the budget.
- If there are more than 150 extras, their costume cost gets a 10% discount.

**Input:**

1. Budget – real number [1.00 … 1000000.00]  
2. Number of extras – integer [1 … 500]  
3. Costume price per extra – real number [1.00 … 1000.00]  

**Output:**

- If cost exceeds the budget:

Result must be formatted to 2 decimal places.

---

### 📝 Task 6: [World Swimming Record]  
**Problem Statement:**  
Ivan wants to break the world record in long-distance swimming. You are given the current record (in seconds), the distance (in meters), and time to swim 1 meter (in seconds). Every 15 meters, water resistance slows him down by 12.5 seconds. The number of slowdowns should be rounded **down**.

**Input:**

1. Record time – real number [0.00 … 100000.00]  
2. Distance – real number [0.00 … 100000.00]  
3. Time per meter – real number [0.00 … 1000.00]  

**Output:**

- If Ivan breaks the record:  
`Yes, he succeeded! The new world record is {Ivan's time} seconds.`
- If not:  
`No, he failed! He was {time difference} seconds slower.`

Result must be formatted to 2 decimal places.

---

### 📝 Task 7: [Shopping]  
**Problem Statement:**  
Peter wants to buy N video cards, M processors, and P RAM sticks. If the number of video cards is more than the processors, a 15% discount applies to the total sum.

Prices:

- Video card – 250 lv. each  
- Processor – 35% of the total video cards price (per unit)  
- RAM – 10% of the total video cards price (per unit)  

**Input:**

1. Peter’s budget – real number [0.0 … 100000.0]  
2. Number of video cards – integer [0 … 100]  
3. Number of processors – integer [0 … 100]  
4. Number of RAM sticks – integer [0 … 100]  

**Output:**

- If the budget is sufficient:  
`You have {money left} leva left!`
- If not:  
`Not enough money! You need {money needed} leva more!`

Result must be formatted to 2 decimal places.

---

### 📝 Task 8: [Lunch Break]  
**Problem Statement:**  
During lunch break, you want to watch an episode of your favorite series. Your task is to check if you have enough time. You spend 1/8 of the break eating, and 1/4 resting.

**Input:**

1. Series name – text  
2. Episode duration – integer [10 … 90]  
3. Break duration – integer [10 … 120]  

**Output:**

- If there's enough time:  
`You have enough time to watch {series name} and left with {time left} minutes free time.`
- If not enough time:  
`You don't have enough time to watch {series name}, you need {time needed} more minutes.`

The time in both messages should be **rounded up** to the nearest whole number.

