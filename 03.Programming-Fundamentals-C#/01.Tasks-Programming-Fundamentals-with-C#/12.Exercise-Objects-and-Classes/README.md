# Objects and Classes - Exercise – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Objects and Classes - Exercise** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

---

### 📝 Task 1: Advertisement Message  
**Problem Statement:**  
Create a program that generates random fake advertisement messages to advertise a product. The messages must consist of 4 parts: phrase + event + author + city. Use the following predefined parts:

· Phrases – {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."}  
· Events – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}  
· Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}  
· Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}

The format of the output message is:  
`"{phrase} {event} {author} – {city}."`

You will receive the number of messages to be generated. Print each random message on a separate line.

---

### 📝 Task 2: Articles  
**Problem Statement:**  
Create a class `Article` with the following properties:

· Title – a string  
· Content – a string  
· Author – a string

The class should have a constructor and the following methods:

· `Edit(new content)` – change the old content with the new one  
· `ChangeAuthor(new author)` – change the author  
· `Rename(new title)` – change the title of the article  
· Override the `ToString()` method – print the article in the format:  
`"{title} - {content}: {author}"`

You will receive:  
- A single article in the format: `"{title}, {content}, {author}"`  
- A number `n`, followed by `n` commands:  
  - `Edit: {new content}`  
  - `ChangeAuthor: {new author}`  
  - `Rename: {new title}`

At the end, print the final state of the article.

---

### 📝 Task 3: Articles 2.0  
**Problem Statement:**  
Adapt the previous task to support a list of articles.  
- First line: number of articles  
- Next `n` lines: articles in format `"{title}, {content}, {author}"`

Print all articles using their `ToString()` method.

---

### 📝 Task 4: Students  
**Problem Statement:**  
Create a program that sorts students by their grade in descending order. Each student has:

· First name (string)  
· Last name (string)  
· Grade (floating-point number)

**Input:**  
- First line: number of students  
- Next `n` lines: `"{first name} {last name} {grade}"`

**Output:**  
`"{first name} {last name}: {grade}"` – sorted by grade descending.

---

### 📝 Task 5: Teamwork Projects  
**Problem Statement:**  
Create teams and assign members based on commands.  
- Input begins with number of teams to register  
- Then, lines with creator-team format: `"{user}-{team}"`  
- Then, lines with member-team format: `"{user}-> {team}"`

**Rules:**  
- Teams must be unique  
- One creator per user  
- Users can join only one team  
- Teams with no members are disbanded  

**Output:**  
- Valid teams sorted by member count descending, then name ascending  
- Disbanded teams listed alphabetically  
- Format:  
Team {teamName} has been created by {creator}!
{teamName}

{creator}
-- {member1}
-- {member2}

---

### 📝 Task 6: Vehicle Catalogue  
**Problem Statement:**  
Until the "End" command, read vehicle entries:  
`"{type} {model} {color} {horsepower}"`

Then read model names to print vehicle details.

After "Close the Catalogue", print average horsepower for Cars and Trucks:  
`"{type}s have average horsepower of: {averageHorsepower}."`

Format numbers to 2 decimal points.

---

### 📝 Task 7: Order by Age  
**Problem Statement:**  
Read lines in format:  
`"{name} {ID} {age}"`

If a person with the same ID exists, update their data.

On "End", print all people ordered by age:
`"{name} with ID: {ID} is {age} years old."`

---

### 📝 Task 8: Company Roster  
**Problem Statement:**  
Define a class `Employee` with:  
- Name, Salary, Department

Read N employees and find the department with highest average salary.

Print employees in that department sorted by salary descending:  
`"{Name} {Salary}"` – format salary to 2 decimals.

---

### 📝 Task 9: Oldest Family Member  
**Problem Statement:**  
Create classes `Person` (Name, Age) and `Family`.

The `Family` class should:  
- Store a list of `Person` objects  
- Have method `AddMember(Person member)`  
- Have method `GetOldestMember()`  

Read N people, print oldest person's name and age.

---

### 📝 Task 10: Speed Racing  
**Problem Statement:**  
Track multiple cars. Each `Car` has:  
- Model (unique), FuelAmount, FuelConsumptionPerKm, TraveledDistance (initially 0)

**Input:**  
- First N lines: `"{Model} {FuelAmount} {FuelConsumption}"`  
- Then until "End": `Drive {Model} {Distance}`

If the car has enough fuel, update its stats. Otherwise, print:  
`"Insufficient fuel for the drive"`

At the end, print all cars:  
`"{Model} {FuelAmount} {TraveledDistance}"` – format fuel to 2 decimals.

---

### 📝 Task 11: Raw Data  
**Problem Statement:**  
Create a `Car` class with nested `Engine` and `Cargo` classes.

Each car has:  
`"{Model} {EngineSpeed} {EnginePower} {CargoWeight} {CargoType}"`

After all cars are added, read a command:

- "fragile": print cars with fragile cargo and weight < 1000  
- "flamable": print cars with flamable cargo and engine power > 250

Output cars in original order.

---

### 📝 Task 12: Shopping Spree  
**Problem Statement:**  
Create two classes: `Person` and `Product`.

- A `Person` has: name, money, list of products  
- A `Product` has: name and cost

**Input:**  
- First line: people (e.g. "John=50;Peter=100")  
- Second line: products (e.g. "Bread=10;Milk=5")  
- Then commands: `"{person} buys {product}"`

If person can't afford it, print:  
`"{Person} can't afford {Product}"`

**Output:**  
For each person, print what they bought, or:  
`"{Name} – Nothing bought"`
