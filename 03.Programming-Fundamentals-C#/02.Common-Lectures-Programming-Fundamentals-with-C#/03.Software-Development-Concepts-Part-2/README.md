# Software Development Concepts – Part 2

## 🧠 Overview

Here’s a friendly guide to the second part of **Software Development Concepts** from SoftUni’s _Programming with C#_. We’ll explore web interfaces, server logic, connected devices, and core software engineering practices—all in a nutshell.

---

## 🌐 1. Front-End World

### 🖥️ Essentials
- Build web pages with HTML, style with CSS, add interaction with JavaScript  
- Popular JS frameworks: React, Angular, Vue  
- **DOM:** the page’s structure you can manipulate dynamically using JS

### 🔄 Talking to Servers
- Use AJAX for fetching and sending data without reloading pages  
- RESTful APIs: follow HTTP methods (GET, POST, PUT, DELETE) to handle data

### 📝 Dynamic Pages & Navigation
- **Templates:** create HTML that adapts to data  
- **Routing:** move between views or pages through URLs

### 📚 Libraries vs Frameworks
- **Libraries:** tools you call when needed  
- **Frameworks:** provide a scaffold; your code fits inside their flow

### 📱 Interface Tools
- Desktop/Mobile: WPF, Windows Forms, Qt, UIKit, Android UI, Flutter  
- Web: Angular, React, Vue, Meteor

---

## ⚙️ 2. Back-End World

### 🖥️ Server-Side Essentials
- Handle logic, databases, APIs, microservices, cloud deployments

### 💾 Data Storage
- Relational: MySQL, PostgreSQL  
- Non-relational: MongoDB, IndexedDB

### 🔄 ORMs
- Map objects in code to database tables (Entity Framework, Hibernate)

### 🏛️ MVC
- **Model:** the data  
- **View:** what users see  
- **Controller:** the logic connecting the two

### ☁️ Cloud & Virtualization
- Virtual machines, cloud platforms (IaaS, PaaS)

### 🐳 Containers
- Package apps and dependencies for easy deployment  
- Example:
  `bash`
  `docker run -d -p 8080:80 dockersamples/static-site`
  `docker ps`

---

## 📡 3. Embedded Systems and IoT

### 🛠️ Small but Mighty
- Devices with limited hardware doing specific tasks
- Examples: smart lights, thermostats, sensors

### 🌐 Internet of Things (IoT)
- Devices connected to the internet  
- **Microcontrollers:** Arduino, ESP8266, ESP32  
- **Components:** controller, sensors/actuators, network (WiFi, Bluetooth, LoRa), backend

### 💻 Programming Languages
- C, C++, JavaScript, Python, C#

---

## 🛠️ 4. Software Engineering Basics

### 🔄 Development Life Cycle
- Phases: understand requirements → design → build → test 
- Models: Waterfall, Scrum, Kanban

### ✅ Ensuring Quality
- Manual & automated testing, peer reviews, QA processes

### 🧪 Unit Testing
- Check small pieces of code for correctness
- Example in JavaScript:
```js
function sum(arr) {
  let total = 0;
  for (let item of arr) total += item;
  return total;
}
```
### 🧰 Test Frameworks
- Run and report tests automatically, e.g., Mocha for JS

### 🔧 Version Control
- Track changes with Git, SVN, TFS
- Platforms: GitHub (issues, Kanban boards, CI/CD pipelines)

### 📋 Task Management
- Organize projects and progress 
- Tools: Trello, GitHub Projects 
- Columns: Backlog → In Progress → Done

---

## ✅ Key Takeaways

✔️ Front-End: dynamic pages, server communication, frameworks
✔️ Back-End: APIs, databases, MVC, cloud, containerization  
✔️ Embedded & IoT: small controllers, sensors, connectivity
✔️ Software Engineering: development lifecycle, QA, testing, versioning, task tracking
