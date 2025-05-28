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
The format of the output message is the following: "{phrase} {event} {author} – {city}."  
You will receive the number of messages to be generated. Print each random message at a separate line.

---

### 📝 Task 2: Articles  
**Problem Statement:**  
Create a class Article with the following properties:  
· Title – a string  
· Content – a string  
· Author – a string  

The class should have a constructor and the following methods:  
· Edit (new content) – change the old content with the new one  
· ChangeAuthor (new author) – change the author  
· Rename (new title) – change the title of the article  
· Override the ToString method – print the article in the following format:  
"{title} - {content}: {author}"  

Create a program that reads an article in the following format "{title}, {content}, {author}". On the next line, you will receive a number n, representing the number of commands, which will follow after it. On the next n lines, you will be receiving the following commands:  
· "Edit: {new content}"  
· "ChangeAuthor: {new author}"  
· "Rename: {new title}"  
In the end, print the final state of the article.

---

### 📝 Task 3: Articles 2.0  
**Problem Statement:**  
Change the program from the previous problem in such a way, that you will be able to store a list of articles. You will not need to use the previous methods anymore (except the "ToString()"). On the first line, you will receive the number of articles. On the next lines, you will receive the articles in the same format as in the previous problem: "{title}, {content}, {author}". Print the articles.

---

### 📝 Task 4: Students  
**Problem Statement:**  
Create a program that sorts some students by their grade in descending order. Each student should have:  
· First name (string)  
· Last name (string)  
· Grade (a floating-point number)  

**Input:**  
· On the first line, you will receive a number n - the count of all students.  
· On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}".  

**Output:**  
· Print out the information about each student in the following format: "{first name} {second name}: {grade}".

---

### 📝 Task 5: Teamwork Projects  
**Problem Statement:**  
It's time for the teamwork projects and you are responsible for gathering the teams. First, you will receive an integer – the count of the teams you will have to register. You will be given a user and a team, separated with "-". The user is the creator of the team. For every newly created team you should print a message:  
"Team {teamName} has been created by {user}!".  

Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team. Upon receiving the command: "end of assignment", you should print every team, ordered by the count of its members (descending) and then by name (ascending). For each team, you have to print its members sorted by name (ascending). However, there are several rules:  
· If а user tries to create a team more than once, a message should be displayed:  
  "Team {teamName} was already created!"  
· A creator of a team cannot create another team – the following message should be thrown:  
  "{user} cannot create another team!"  
· If а user tries to join a non-existent team, a message should be displayed:  
  "Team {teamName} does not exist!"  
· A member of a team cannot join another team – the following message should be thrown:  
  "Member {user} cannot join team {team Name}!"  

In the end, teams with zero members (with only a creator) should disband and you have to print them ordered by name in ascending order.  
Every valid team should be printed ordered by name (ascending) in the following format:  
"{teamName} - {creator} -- {member}…"

---

### 📝 Task 6: Vehicle Catalogue  
**Problem Statement:**  
Until you receive the "End" command, you will be receiving lines of input in the following format:  
"{typeOfVehicle} {model} {color} {horsepower}"  

When you receive the "End" command, you will start receiving information about some vehicles.  
For every vehicle, print out the information about it in the following format:  
"Type: {typeOfVehicle} Model: {modelOfVehicle} Color: {colorOfVehicle} Horsepower: {horsepowerOfVehicle}"  

When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the average horsepower of the trucks in the format:  
"{typeOfVehicles} have average horsepower of: {averageHorsepower}."  

The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by the total count of all vehicles from that type. Format the answer to the second digit after the decimal point.

---

### 📝 Task 7: Order by Age  
**Problem Statement:**  
You will receive an unknown number of lines. On each line you will receive an array with 3 elements:  
· The first element is a string - the name of the person  
· The second element a string - the ID of the person  
· The third element is an integer - the age of the person  

If you get a person whose ID you have already received before, update the name and age for that ID with that of the new person. When you receive the command "End", print all of the people, ordered by age.

---

### 📝 Task 8: Company Roster  
**Problem Statement:**  
Define a class Employee that holds the following information: a name, a salary and a department.  
Your task is to write a program, which takes N lines of employees from the console, calculates the department with the highest average salary, and prints for each employee in that department their name and salary – sorted by salary in descending order. The salary should be rounded to two digits after the decimal separator.

---

### 📝 Task 9: Oldest Family Member  
**Problem Statement:**  
Create two classes – Family and Person. The Person class should have Name and Age properties. The Family class should have a list of people, a method for adding members (`void AddMember(Person member)`), and a method, which returns the oldest family member (`Person GetOldestMember()`).  

Write a program that reads the names and ages of N people and adds them to the family. Then print the name and age of the oldest member.

---

### 📝 Task 10: Speed Racing  
**Problem Statement:**  
Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class `Car` that keeps a track of a car's model, fuel amount, fuel consumption per kilometer and traveled distance. A car's model is unique – there will never be 2 cars with the same model.  

On the first line of the input, you will receive a number N – the number of cars you need to track. On each of the next N lines, you will receive information about cars in the following format:  
"<Model> <FuelAmount> <FuelConsumptionFor1km>"  

All cars start at 0 kilometers traveled.  

After the N lines, until the command "End" is received, you will receive commands in the following format:  
"Drive <CarModel> <amountOfKm>"  

Implement a method in the Car class to calculate whether or not a car can move that distance. If it can, the car's fuel amount should be reduced by the amount of used fuel and its traveled distance should be increased. Otherwise, the car should not move and you should print on the console:  
"Insufficient fuel for the drive"  

After the "End" command is received, print each car, its current fuel amount and the traveled distance in the format:  
"<Model> <fuelAmount> <distanceTraveled>"  
Print the fuel amount rounded to two digits after the decimal separator.

---

### 📝 Task 11: Raw Data  
**Problem Statement:**  
You are the owner of a courier company and you want to make a system for tracking your cars and their cargo. Define a class `Car` that holds a piece of information about the model, engine and cargo. The `Engine` and `Cargo` should be separate classes.  

Create a constructor that receives all of the information about the Car and initializes its inner components (engine and cargo).  

On the first line of input, you will receive a number N – the number of cars you have. On each of the next N lines, you will receive the following information about a car:  
"<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>"  

After the N lines, you will receive a single line with one of two commands: "fragile" or "flamable".  
If the command is "fragile", print all cars whose Cargo Type is "fragile" with cargo weight < 1000.  
If the command is "flamable", print all cars whose Cargo Type is "flamable" and have Engine Power > 250.  
The cars should be printed in the order of appearance in the input.

---

### 📝 Task 12: Shopping Spree  
**Problem Statement:**  
Create two classes: `Person` and `Product`. Each person should have a name, money and a bag of products. Each product should have a name and a cost.  

Create a program, in which each command corresponds to a person buying a product. If the person can afford a product, add it to their bag. If a person doesn't have enough money, print the message:  
"{Person} can't afford {Product}"  

On the first two lines, you are given all people and all products. After all purchases, print every person in the order of appearance and all products that they have bought. If nothing was bought, print the name of the person followed by "Nothing bought".

---
