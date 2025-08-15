# Software Development Concepts – Part 1

## 🧠 Overview

This document summarizes key concepts from the lecture **"Software Development Concepts - Part 1"** in the _Programming with C#_ course at **SoftUni**. It introduces foundational ideas in software engineering, essential for every aspiring developer.

This overview is suitable for:
- Personal documentation
- GitHub portfolios
- Demonstrating foundational knowledge for junior development roles

---

## 🔑 1. Four Essential Skill Areas for a Developer

| Skill Area               | Description                                                                                              | Weight |
|--------------------------|----------------------------------------------------------------------------------------------------------|--------|
| **Programming Skills**   | Writing code, working with IDEs, using variables, loops, functions, and data structures effectively.     | 20%    |
| **Problem-Solving**      | Applying algorithmic thinking, breaking complex problems into smaller tasks, and practicing extensively. | 30%    |
| **Development Basics**   | Core concepts such as OOP, functional programming, async processing, databases, HTTP/web basics, version control, Agile. | 25% |
| **Tech Stack Knowledge** | Understanding programming languages, frameworks, and tools (C#, .NET, SQL, Git, HTML/CSS/JavaScript).    | 25%    |

---

## 🧱 2. Key Concepts in Software Engineering

### 📐 Math & Logical Foundations
- Coordinate systems (used in graphics, SVG)
- Vectors and matrices (important for games, simulations, ML)
- Finite State Machines (FSM) for process modeling
- Basic statistics for analysis and machine learning
- Algorithm complexity and Big O notation for performance assessment

### 🧊 Object-Oriented Programming (OOP)
- Models software using **classes** and **objects** to represent real-world concepts
- **Core principles**:
  - Encapsulation
  - Inheritance
  - Abstraction
  - Polymorphism
- **Example:**
```csharp
class Rectangle {
    int width, height;
    int CalcArea() => width * height;
}
```
### ⚙️ Functional Programming (FP)
 - Focuses on pure, stateless functions without side effects
 - Often uses a declarative coding style
Console.WriteLine(Console.ReadLine().Split(" ").Select(int.Parse).Max());
Lambda & Higher-Order Functions:
Func<int, int> twice = x => 2 * x;
var result = twice(5); // 10

---

## 🧮 3. Data Structures and Algorithms
### 🔢 Core Data Types
 - Arrays, Lists, Stacks, Queues

### 🌳 Trees (e.g., File Systems)
C:\
 └── Users
     ├── Maria
     └── George
## 📌 Tree Traversal Algorithms

- **DFS** (Depth-First Search)  
- **BFS** (Breadth-First Search)

---

## 🧩 4. Modular & Event-Driven Development

### 🧱 Component-Based Development
- Applications built from independent, reusable modules
- **Examples**:  
  - Date picker control
  - Email sender component
  - PDF generator service

### ⚡ Event-Driven Programming
- The application reacts to events such as user input or system signals 
- Widely used in GUIs, games, and interactive systems
- **Key parts**:  
  - Event emitters
  - Event handlers

---

## 🏗️ 5. Software Architecture Patterns

### 🧱 Monolithic Applications
- A single unit containing UI, logic, and data storage 
- **Example**: simple desktop applications or small games

### 🌐 Client-Server Model
- **Server**: Processes data, contains business logic, serves APIs
- **Client**: User interface (e.g., browser, mobile app) that sends requests to the server

### 🔄 Front-End vs. Back-End
- **Front-End**: Technologies like HTML, CSS, JavaScript, React, Vue
- **Back-End**: Platforms such as C#/.NET, Node.js, Flask, Spring
- Communicate via HTTP APIs (often REST with JSON)

### 🧭 Architectural Patterns
- **3-Tier / Multi-Tier**: UI → Logic Layer → Data Layer  
- **Microservices / SOA**: Independent services connected through APIs

---

## 🌐 6. Full-Stack Development

Full-stack developers work on both the front-end and back-end of applications.

### ✅ Skills Required:
- Building user interfaces for web or mobile
- Implementing business logic and APIs
- Managing SQL/NoSQL databases
- Connecting and integrating all application layers

---

## ✅ Summary

- A well-rounded developer needs skills in coding, problem-solving, foundational concepts, and tech stack proficiency
- OOP and FP are essential programming paradigms
- Understanding core data structures and algorithms (DFS/BFS) is fundamental
- Component-based and event-driven approaches enable scalable, interactive systems
- Knowing different architecture patterns helps design better applications

🎓 _Part of the Programming with C# Track at SoftUni_
