# Software Development Concepts – Part 1

## 🧠 Overview

This document summarizes key concepts from the lecture **"Software Development Concepts - Part 1"** in the _Programming with C#_ course at **SoftUni**. It introduces foundational ideas in software engineering, essential for every aspiring developer.

This overview is suitable for:
- Personal documentation
- GitHub portfolios
- Demonstrating foundational knowledge for junior development roles

---

## 🔑 1. The 4 Core Skills of a Software Engineer

| Skill                   | Description                                                                                     | Weight |
|------------------------|-------------------------------------------------------------------------------------------------|--------|
| **Coding**             | Writing code, working with IDEs, variables, loops, functions, and data structures.              | 20%    |
| **Algorithmic Thinking**| Solving problems, breaking them into steps, improving through solving 1000+ tasks.              | 30%    |
| **Development Fundamentals** | OOP, FP, async, DBs, web tech (HTTP, JS, AJAX), source control, Agile.                   | 25%    |
| **Languages & Technologies**| Programming languages and tools (e.g., C#, .NET, SQL, Git, HTML/CSS/JS).                 | 25%    |

---

## 🧱 2. Fundamental Software Engineering Concepts

### 📐 Mathematical Foundations
- Coordinate systems (SVG, graphics)
- Vectors & matrices (games, machine learning)
- Finite State Machines (FSM)
- Statistics (used in ML)
- Algorithm complexity (Big O notation)

### 🧊 Object-Oriented Programming (OOP)
- Real-world modeling with classes and objects  
- **Key Principles**:  
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
 - Pure functions with no side effects
 - Stateless, declarative approach
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

## 🧩 4. Component-Based & Event-Driven Programming

### 🧱 Component-Based Development
- Applications are built from reusable, modular components  
- **Examples**:  
  - UI elements (Date Picker)  
  - Email Sender  
  - PDF Generator

### ⚡ Event-Driven Programming
- Program flow is determined by user or system events  
- Common in UI development and games  
- **Uses**:  
  - Event emitters  
  - Event handlers

---

## 🏗️ 5. Software Architecture Concepts

### 🧱 Monolithic Applications
- All-in-one app containing UI, logic, and storage  
- **Example**: Simple mobile games, Notepad

### 🌐 Client-Server Model
- **Server**: Business logic, databases, APIs  
- **Client**: UI and interaction layer (e.g., web browser)

### 🔄 Front-End vs. Back-End
- **Front-End**: HTML, CSS, JavaScript, React, Vue  
- **Back-End**: C# (.NET), Node.js, Flask, Spring, etc.  
- Connected via HTTP APIs (REST, JSON)

### 🧭 Architectural Patterns
- **3-Tier / Multi-Tier**: UI → Business Logic → Storage  
- **Microservices / SOA**: Decoupled, independent services communicating over APIs

---

## 🌐 6. Full-Stack Development

Full-stack developers are responsible for both front-end and back-end development.

### ✅ Skills Required:
- Building UIs (Web/Mobile)
- Writing APIs and implementing business logic
- Working with databases (SQL/NoSQL)
- Integrating front-end with back-end systems

---

## ✅ Summary

✔️ **4 Key Skills**:
- Coding  
- Problem Solving  
- Development Fundamentals  
- Technology Stack  

✔️ **Core Concepts**:
- OOP  
- Functional Programming (FP)  
- Event Handling  
- Software Architectures  

✔️ **Practical Examples**:
- Tree Traversal Algorithms (DFS/BFS)  
- Functional Code Patterns  
- Event-Driven UI Interactions  

✔️ **Technologies Mentioned**:
- HTML, CSS, JS, React  
- C#, .NET, SQL, Git  

👨‍💻 **Ideal For**:  
Junior Developers preparing for full-stack or backend roles

🎓 _Part of the Programming with C# Track at SoftUni_
