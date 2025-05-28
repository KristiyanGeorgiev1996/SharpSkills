# Associative Arrays - Exercise – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Associative Arrays - Exercise** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

---

### 📝 Task 1: Count Chars in a String  
**Problem Statement:**  
Create a program that counts all characters in a string, except for space (' ').

**Output Format:**  
`"{char} -> {occurrences}"`

---

### 📝 Task 2: A Miner Task  
**Problem Statement:**  
Collect resources from input where every odd line is a resource and every even line is a quantity.

**Output Format:**  
`"{resource} -> {quantity}"`

---

### 📝 Task 3: Orders  
**Problem Statement:**  
Track products with prices and quantities. If a product already exists, update its quantity and price.

**Input Format:**  
`"{productName} {price} {quantity}"` until `"buy"`

**Output Format:**  
`"{productName} -> {totalPrice}"`  
*Price should be formatted to the 2nd decimal place.*

---

### 📝 Task 4: SoftUni Parking  
**Problem Statement:**  
Manage parking registration through register/unregister commands.

**Commands:**
- `"register {username} {licensePlateNumber}"`
- `"unregister {username}"`

**Final Output:**  
`"{username} => {licensePlateNumber}"`

---

### 📝 Task 5: Courses  
**Problem Statement:**  
Store course names and their students until `"end"`.

**Input Format:**  
`"{courseName} : {studentName}"`

**Output Format:**
- `"{courseName}: {registeredStudents}"`
- `"-- {studentName}"`

---

### 📝 Task 6: Student Academy  
**Problem Statement:**  
Track students and their grades. Show those with average grade ≥ 4.50.

**Output Format:**  
`"{name} -> {averageGrade}"`  
*Grade formatted to 2 decimal places.*

---

### 📝 Task 7: Company Users  
**Problem Statement:**  
Store company names and employee IDs (no duplicates).

**Input Format:**  
`"{companyName} -> {employeeId}"` until `"End"`

**Output Format:**
- `"{companyName}"`
- `"-- {employeeId}"`

---

### 📝 Task 8: Ranking  
**Problem Statement:**  
Manage contests, passwords, and participant scores. Print best candidate and all rankings.

**Input:**
- `"{contest}:{password}"` until `"end of contests"`
- `"{contest}=>{password}=>{username}=>{points}"` until `"end of submissions"`

**Output Format:**
- `"Best candidate is {username} with total {totalPoints} points."`
- User stats:
{username}

{contest1} -> {points}
{contest2} -> {points}

---

### 📝 Task 9: Judge  
**Problem Statement:**  
Track contest standings and user points. Summarize per contest and individual standings.

**Input Format:**  
`"{username} -> {contest} -> {points}"` until `"no more time"`

**Output Format:**
- `"{contest}: {participantCount} participants"`
- `"{position}. {username} <::> {points}"`
- `Individual standings:`
- `"{position}. {username} -> {totalPoints}"`

---

### 📝 Task 10: MOBA Challenger  
**Problem Statement:**  
Track MOBA player positions and skills. Simulate duels and update rankings.

**Input Format:**
- `"{player} -> {position} -> {skill}"`
- `"{player} vs {player}"`
- End with `"Season end"`

**Output Format:**
- `"{player}: {totalSkill} skill"`
- `"- {position} <::> {skill}"`

---

### 📝 Task 11: Snowwhite  
**Problem Statement:**  
Store dwarfs by name and hat color. If duplicate, keep highest physics.

**Input Format:**  
`"{dwarfName} <:> {hatColor} <:> {dwarfPhysics}"` until `"Once upon a time"`

**Output Format:**  
`"({hatColor}) {dwarfName} <-> {physics}"`

---

### 📝 Task 12: Dragon Army  
**Problem Statement:**  
Track dragons by type, name, and stats. Replace stats if duplicate.

**Input Format:**  
`"{type} {name} {damage} {health} {armor}"` – use defaults if "null"  
*Defaults: damage = 45, health = 250, armor = 10*

**Output Format:**
- `"{Type}::({avgDamage}/{avgHealth}/{avgArmor})"`
- `"-{Name} -> damage: {damage}, health: {health}, armor: {armor}"`

---
