# Objects and Classes - Exercise – Programming Advanced for QA 🧑💻

This folder contains tasks from the **Objects and Classes - Exercise** section of the _Programming Advanced for QA_ course at SoftUni. Below are the tasks with brief descriptions.

---

## 🔧 Tasks Overview:

### 📝 Task 1: Students  
**Problem Statement:**  
Create a program that sorts students by their grade in descending order.

Each student should have:
- First name (string)
- Last name (string)
- Grade (floating-point number)

**Input:**
- First line: number `n` – the number of students.
- Next `n` lines: student data in the format:  
{firstName} {lastName} {grade}

**Output:**
- Print the students in the following format:  
{firstName} {lastName}: {grade}

---

### 📝 Task 2: Articles  
**Problem Statement:**  
Create a class `Article` with the following properties:
- `Title` (string)
- `Content` (string)
- `Author` (string)

**Methods:**
- `Edit(newContent)` – change the content
- `ChangeAuthor(newAuthor)` – change the author
- `Rename(newTitle)` – change the title
- Override `ToString()` to return:  
{title} - {content}: {author}

**Input:**
- First line: initial article in the format:  
{title}, {content}, {author}
- Next line: integer `n` – number of commands.
- Next `n` lines: commands in one of the following formats:
- `Edit: {new content}`
- `ChangeAuthor: {new author}`
- `Rename: {new title}`

**Output:**
- Print the final state of the article.

---

### 📝 Task 3: Teamwork Projects  
**Problem Statement:**  
Manage the registration and assignment of users to teams.

**Input:**
- First line: number of teams to register
- Next lines: team creation in the format:  
{creator}-{teamName}
On creation:
Team {teamName} has been created by {creator}!

- After that, assignment of members in the format:  
{user}-> {teamName}
- Ends with: `"end of assignment"`

**Rules:**
- If a team with the same name exists:  
Team {teamName} was already created!
- If a creator tries to create another team:  
{user} cannot create another team!
- If user tries to join non-existent team:  
Team {teamName} does not exist!
- If a user is already part of a team:  
Member {user} cannot join team {teamName}!

**Output:**
- Print valid teams ordered by:
- Member count (descending)
- Then by team name (ascending)

For each team:
{teamName}

{creator} -- {member1} -- {member2} ...

- Print disbanded teams with no members (only a creator), sorted by name:
Teams to disband: {teamName1} {teamName2} ...

---

### 📝 Task 4: Pokemon Trainer  
**Problem Statement:**  
Simulate a Pokémon tournament using classes `Trainer` and `Pokemon`.

**Class `Trainer`:**
- `Name`
- `NumberOfBadges`
- `List<Pokemon>`

**Class `Pokemon`:**
- `Name`
- `Element`
- `Health`

**Input Phase 1:**
- Read lines in the format:  
{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}
- Until: `"Tournament"`

**Input Phase 2:**
- Read commands: `"Fire"`, `"Water"`, `"Electricity"`
- Until: `"End"`

**Rules:**
- If a trainer has a Pokémon with the required element → gets 1 badge.
- Else → all their Pokémon lose 10 health.
- Remove Pokémon with `Health <= 0`.

**Output:**
- Print all trainers ordered by badges (descending), format:
{trainerName} {badges} {numberOfPokemon}

---
