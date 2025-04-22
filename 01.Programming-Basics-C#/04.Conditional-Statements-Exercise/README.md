
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
