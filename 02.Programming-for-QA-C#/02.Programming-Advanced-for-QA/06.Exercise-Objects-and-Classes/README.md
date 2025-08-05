# Objects and Classes - Exercise – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Objects and Classes - Exercise** section of the _Programming Advanced for QA_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview:

### 📝 Task 1: Student Sorting

**Description:**  
Write a program that orders students based on their grades from highest to lowest.

Each student should have these attributes:  
- First name (string)  
- Last name (string)  
- Grade (floating-point number)  

**Input:**  
- The first line contains an integer `n` representing the number of students.  
- The following `n` lines each contain student information in the format:  
  `{firstName} {lastName} {grade}`  

**Output:**  
- Print each student in descending order by grade, following the format:  
  `{firstName} {lastName}: {grade}`

---

### 📝 Task 2: Article Management

**Description:**  
Implement a class called `Article` with the properties:  
- `Title` (string)  
- `Content` (string)  
- `Author` (string)  

Include the following methods:  
- `Edit(newContent)` – updates the article content  
- `ChangeAuthor(newAuthor)` – modifies the author name  
- `Rename(newTitle)` – updates the title  
- Override the `ToString()` method to return:  
  `{title} - {content}: {author}`  

**Input:**  
- The first input line contains the initial article info in the format:  
  `{title}, {content}, {author}`  
- Next, read an integer `n` for the number of commands to follow.  
- The next `n` lines are commands in one of these formats:  
  - `Edit: {new content}`  
  - `ChangeAuthor: {new author}`  
  - `Rename: {new title}`  

**Output:**  
- Display the article’s final state after all commands have been applied.

---

### 📝 Task 3: Teamwork Projects Management

**Description:**  
Create a system to register teams and assign users to them.

**Input:**  
- First, read the number of teams to create.  
- For each team, input the creation line in the format:  
  `{creator}-{teamName}`  
  Upon successful creation, print:  
  `Team {teamName} has been created by {creator}!`  

- Then read member assignments in the format:  
  `{user}-> {teamName}`  
- Stop reading when you receive `"end of assignment"`.

**Constraints & Validation:**  
- If the team name is already taken, print:  
  `Team {teamName} was already created!`  
- If a creator attempts to create more than one team, print:  
  `{user} cannot create another team!`  
- If a user tries to join a non-existent team, print:  
  `Team {teamName} does not exist!`  
- If a user is already in any team, print:  
  `Member {user} cannot join team {teamName}!`  

**Output:**  
- Print teams with members sorted by member count (descending), then by team name (ascending).  
- For each team print:  
  `{teamName}`  
  `{creator} -- {member1} -- {member2} ...`  

- Finally, print teams without members (only creator) sorted alphabetically:  
  `Teams to disband: {teamName1} {teamName2} ...`

---

### 📝 Task 4: Pokémon Trainer Simulation

**Description:**  
Model a Pokémon tournament using `Trainer` and `Pokemon` classes.

**Class `Trainer`:**  
- `Name` (string)  
- `NumberOfBadges` (int)  
- `Pokemons` (list of `Pokemon` objects)  

**Class `Pokemon`:**  
- `Name` (string)  
- `Element` (string)  
- `Health` (int)  

**Input Phase 1:**  
- Read lines until `"Tournament"` in the format:  
  `{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}`  

**Input Phase 2:**  
- After that, read commands until `"End"`:  
  Possible commands: `"Fire"`, `"Water"`, `"Electricity"`

**Rules:**  
- If a trainer has at least one Pokémon with the specified element, increase their badges by 1.  
- Otherwise, reduce health of all their Pokémon by 10.  
- Remove Pokémon with health less or equal to 0.

**Output:**  
- Print all trainers ordered by number of badges (descending), in the format:  
  `{trainerName} {NumberOfBadges} {countOfPokemons}`

---

**Note:** The tasks are adapted from the SoftUni course and have been reformulated to present clearer and more illustrative descriptions of each exercise.
