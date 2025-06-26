# Software Development Concepts – Part 2

## 🧠 Overview

This document summarizes key concepts from the lecture **"Software Development Concepts - Part 2"** in the _Programming with C#_ course at **SoftUni**. It covers important topics in front-end, back-end, embedded systems, and software engineering.

---

## 🌐 1. Front-End Development Concepts

### 🖥️ Basics
- HTML, CSS, JavaScript, DOM, AJAX  
- JS Frameworks: React, Angular, Vue  
- **DOM**: Document Object Model, a tree structure representing the web page, manipulated via JavaScript

### 🔄 AJAX & RESTful APIs
- Asynchronous communication with the back-end  
- REST uses HTTP methods to manage data (GET, POST, PUT, DELETE)

### 📝 Templating and Routing
- Templating: dynamic HTML generation  
- Routing: navigation between views via URLs

### 📚 Libraries vs. Frameworks
- Libraries: integrate and are called by your code  
- Frameworks: control the flow, your code fits into them

### 📱 UI Frameworks
- Desktop/Mobile: Windows Forms, WPF, Qt, UIKit, Android UI, Flutter  
- Web: Angular, React, Vue, Meteor

---

## ⚙️ 2. Back-End Development Concepts

### 🖥️ Technologies
- Server-side logic, databases, ORM, APIs, microservices, cloud services

### 💾 Databases
- Relational (MySQL, PostgreSQL)  
- NoSQL (MongoDB, IndexedDB)

### 🔄 ORM
- Object-Relational Mapping (e.g., Entity Framework, Hibernate)

### 🏛️ MVC Architecture
- Model (data), View (UI), Controller (logic)

### ☁️ Virtualization and Cloud
- Virtual machines and cloud platforms (IaaS, PaaS)

### 🐳 Containers and Docker
- Packaging apps and dependencies  
- Example commands:
  ```bash
  docker run -d -p 8080:80 dockersamples/static-site
  docker ps

---


## 📡 3. Embedded Systems and IoT

### 🛠️ Embedded Systems
- Specialized hardware + software with limited resources  
- Examples: controlling lights, heating systems

### 🌐 Internet of Things (IoT)
- Internet-connected embedded devices  
- **Microcontrollers:** Arduino, ESP8266, ESP32  
- **Components:** microcontroller, peripherals (LEDs, sensors), connectivity (WiFi, Bluetooth, LoRa), back-end (cloud or local)

### 💻 Programming Languages
- C, C++, JavaScript, Python, C#

---

## 🛠️ 4. Software Engineering

### 🔄 Software Development Lifecycle (SDLC)
- Phases: requirements analysis, design, construction, testing  
- Development Models: Waterfall, Scrum, Kanban

### ✅ Quality Assurance (QA)
- Ensures software quality  
- Includes manual and automated testing, code reviews

### 🧪 Unit Testing
- Testing small parts (units) of code  
- Example in JavaScript:
```js
function sum(arr) {
  let total = 0;
  for (let item of arr) total += item;
  return total;
}
```
### 🧰 Unit Testing Frameworks
- Automate tests and reporting  
- Example: Mocha (JavaScript)

### 🔧 Source Control Systems
- Manage code versions using Git, SVN, TFS  
- Platforms: GitHub (with issue tracking, Kanban boards, CI/CD)

### 📋 Project Trackers and Kanban Boards
- Organize and track project tasks  
- Examples: Trello, GitHub Projects  
- Typical workflow columns: Backlog, In Progress, Done

---

## ✅ Summary

✔️ Front-End: DOM, AJAX, routing, UI frameworks  
✔️ Back-End: REST APIs, databases, ORM, MVC, cloud, Docker  
✔️ Embedded & IoT: microcontrollers, peripherals, connectivity  
✔️ Software Engineering: SDLC, QA, unit testing, source control, Kanban
