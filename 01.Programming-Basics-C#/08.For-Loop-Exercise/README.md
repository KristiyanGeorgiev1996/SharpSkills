# For Loop - Exercise – Programming Basics with C# 🧑‍💻

This folder contains tasks from the **For Loop - Exercise** section of the _Programming Basics with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: [Numbers up to 1000 Ending in 7]  
**Problem Statement:**  
Write a program that prints all numbers in the range from 1 to 1000 that end in 7.

---

### 📝 Task 2: [Element Equal to the Sum of the Others]  
**Problem Statement:**  
Write a program that reads `n` integers entered by the user and checks if there exists an element among them that is equal to the sum of the others.

- If such an element exists, print "Yes" and on the next line "Sum = [its value]".
- If there is no such element, print "No" and on the next line "Diff = [the absolute difference between the largest element and the sum of the others]".

---

### 📝 Task 3: [Histogram]  
**Problem Statement:**  
You are given `n` integers in the range [1…1000]. Some percentage `p1` are below 200, another percentage `p2` are between 200 and 399, another percentage `p3` are between 400 and 599, another `p4` are between 600 and 799, and the remaining `p5` are above 800. Write a program that calculates and prints the percentages `p1`, `p2`, `p3`, `p4`, and `p5`.

Example: We have `n = 20` numbers: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. We get the following distribution and visualization:

| Range | Numbers in Range            | Count | Percentage |
|-------|-----------------------------|-------|------------|
| <200  | 53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65 | 12    | p1 = 60.00% |
| 200-399 | 250, 200                     | 2     | p2 = 10.00% |
| 400-599 | 450                         | 1     | p3 = 5.00%  |
| 600-799 | 680, 600, 799                | 3     | p4 = 15.00% |
| ≥800   | 920, 800                     | 2     | p5 = 10.00% |

Input:
- The first line contains the number `n` (1 ≤ n ≤ 1000) – the number of integers.
- The next `n` lines contain one integer each.

Output:
Print the histogram – 5 lines, each containing a percentage between 0% and 100%, with two decimal places, e.g., 25.00%, 66.67%, 57.14%.

---

### 📝 Task 4: [Lily's Savings]  
**Problem Statement:**  
Lily is now `N` years old. She receives a gift for each birthday.

- For odd birthdays (1, 3, 5, ...), she gets toys.
- For even birthdays (2, 4, 6, ...), she gets money.

For the second birthday, she receives 10.00 lv, and the amount increases by 10.00 lv for each subsequent even birthday (2 → 10, 4 → 20, 6 → 30, etc.). Over the years, Lily has secretly saved the money. Lily's brother takes 1.00 lv from her savings each time she gets money. Lily sold the toys she received over the years, each for `P` lv, and added the money to her savings. She wanted to buy a washing machine costing `X` lv. Write a program that calculates how much money Lily has saved and whether it is enough to buy the washing machine.

Input:
- The program reads 3 numbers entered by the user on separate lines:
  - Lily's age (an integer in the range [1…77]).
  - The price of the washing machine (a real number in the range [1.00…10,000.00]).
  - The price of one toy (an integer in the range [0…40]).

Output:
Print a single line:
- If Lily has enough money, print:
  - "Yes! {N}", where N is the remaining money after the purchase.
- If Lily does not have enough money, print:
  - "No! {M}", where M is the amount she is short.

Numbers N and M should be formatted to two decimal places.

---

### 📝 Task 5: [Salary]  
**Problem Statement:**  
A company boss notices that more and more employees are spending time on distracting websites.

To prevent this, he introduces random checks on the websites open in their browsers.

The following fines apply depending on the open website:

- "Facebook" → 150 lv.
- "Instagram" → 100 lv.
- "Reddit" → 50 lv.

Input:
- The first line contains the number `n` (1 ≤ n ≤ 10) – the number of open tabs.
- The second line contains the salary (an integer in the range [500…1500]).

Then, for `n` times, a website name is read from the input.

Output:
- If during the check the salary becomes less than or equal to 0, print "You have lost your salary."
- Otherwise, print the remaining salary as an integer.

---

### 📝 Task 6: [Oscars]  
**Problem Statement:**  
You are invited by the academy to write software that calculates points for an actor/actress. The academy will give you initial points for the actor. Then, each reviewer will give their score. The actor's total points are calculated by multiplying the length of the reviewer's name by the score they give, divided by two.

If at any point the total points exceed 1250.5, the program should terminate and print that the actor has received a nomination.

Input:
- Actor's name (text).
- Initial points from the academy (a real number in the range [2.0…450.5]).
- The number of reviewers `n` (an integer in the range [1…20]).

For each reviewer:
- Reviewer's name (text).
- Reviewer’s score (a real number in the range [1.0…50.0]).

Output:
- If the points exceed 1250.5, print:
  - "Congratulations, {actor name} got a nominee for leading role with {points}!"
- If the points are not enough, print:
  - "Sorry, {actor name} you need {points needed} more!"

The result should be formatted to the first decimal place.

---

### 📝 Task 7: [Tracking Mania]  
**Problem Statement:**  
Climbers from all over Bulgaria gather in groups to plan their next summits. Depending on the size of the group, the climbers will tackle different peaks.

- A group of up to 5 people will climb Musala.
- A group of 6 to 12 people will climb Mont Blanc.
- A group of 13 to 25 people will climb Kilimanjaro.
- A group of 26 to 40 people will climb K2.
- A group of 41 or more people will climb Everest.

Write a program that calculates the percentage of climbers climbing each peak.

Input:
- The first line contains the number of climbing groups (an integer in the range [1…1000]).
- For each group, the number of people in the group (an integer in the range [1…1000]).

Output:
Print 5 lines on the console, each containing a percentage between 0.00% and 100.00% with two decimal places:
- The percentage of climbers climbing Musala.
- The percentage of climbers climbing Mont Blanc.
- The percentage of climbers climbing Kilimanjaro.
- The percentage of climbers climbing K2.
- The percentage of climbers climbing Everest.

---

### 📝 Task 8: [Tennis World Ranking]  
**Problem Statement:**  
Grigor Dimitrov is a tennis player whose next goal is to rise in the men's tennis world rankings.

During the year, Grigor participates in a certain number of tournaments, earning points based on the position he finishes in each tournament. There are three possible results:

- W → Winner → 2000 points.
- F → Finalist → 1200 points.
- SF → Semi-finalist → 720 points.

Write a program that calculates how many points Grigor will have after playing all tournaments, knowing his initial points. Also, calculate how many points he wins on average per tournament and what percentage of tournaments he has won.

Input:
- The number of tournaments (an integer in the range [1…20]).
- The starting points in the rankings (an integer in the range [1…4000]).

For each tournament, the stage reached ("W", "F", or "SF") is provided.

Output:
Print three lines:
- "Final points: {final points after all tournaments}".
- "Average points: {average points earned per tournament}".
- "{percentage of tournaments won}%".

The average points should be rounded down to the nearest integer, and the percentage should be formatted to two decimal places.
