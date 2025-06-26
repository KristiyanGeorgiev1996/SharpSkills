# ✅ Lecture: Introduction to Quality Assurance (QA)

📚 Part of the **Programming Fundamentals with C#** course at SoftUni  
🎓 **Topic**: Introduction to QA, test types, automation, tools, and CI/CD

---

## 🧪 What is Quality Assurance (QA)?

**Quality Assurance (QA)** is a set of processes and practices aimed at ensuring that a software product is high-quality and works as expected.  
🎯 The main goal is to detect and eliminate defects (bugs) before the product reaches the end user.

### 🔎 QA includes:

- 📋 Manual testing
- 🤖 Automated testing
- 🔁 Integration and continuous delivery (CI/CD pipeline)

---

## 👩‍💻 The Role of a QA Engineer

QA engineers are responsible for the overall quality of the product:

- ✍️ Plan and execute tests
- 🧪 Verify functionality, UX, and usability
- 📄 Create test plans, scenarios, and test cases
- 🐞 Report and track bugs using tracking tools
- 🔁 Perform regression testing after bug fixes
- 🔍 Review requirements, design, and even code
- ⚙️ Maintain and monitor CI/CD processes

---

## 🐛 Bugs, Defects & Tracking Systems

### ❗️ What is a Software Defect?

- 👤 Human errors lead to defects  
- 🧨 Defects lead to unexpected behavior (failures)

### 💸 The Cost of Bugs

> The earlier a defect is detected, the cheaper it is to fix.

➡️ That’s why we use practices like automated testing and CI/CD.

### 🗃 Bug / Issue Tracking Systems

QA engineers use tools like Jira, Trello, or Azure DevOps to:

- 📝 Report bugs
- ⚙️ Track status:  
  `New → Assigned → Fixed → Verified → Closed`
- 👨‍💻 Assign developers or teams
- 🗨 Collaborate via comments and discussions

#### 📌 Sample Tracker Information:

- Title and description with steps to reproduce
- Priority *(Low, Medium, High, Critical)*
- Status, assigned team, change history

---

## 🧪 Software Testing: Types and Levels

### ✅ Test Types

- 🔲 Functional vs. Non-functional
- ⚫️ Black-box (no code knowledge)
- ⚪️ White-box (internal logic-based)
- 🔁 Regression testing
- 🔄 Load, UX, and security testing

### 🧱 Levels of Testing

- 🧪 **Unit Tests** – Test small components (methods/classes) – written by developers
- 🔗 **Integration Tests** – Test interactions between components
- 🧷 **System / Acceptance Tests** – Test the entire system (often involve manual steps)

### 🔺 The Test Pyramid

- 🧪 Unit: fully automated  
- 🔗 Integration: automated  
- 🧷 System: partially automated  
- 👁 UI/UX: mostly manual

---

## 📝 Testing Process: From Plan to Report

### 🧭 Test Plan

- What will be tested?
- How will it be tested? *(strategy)*
- When will it be tested? *(schedule)*

### 📚 Test Scenarios & Cases

- **Scenario**: The user story being tested
- **Test Case**: Concrete steps + expected result

#### Example: User Registration

- ✅ Positive test: Successful registration
- ❌ Negative test: Empty field / invalid input

---

## 🤖 Automated Testing & Tools

### 🧰 Tools & Frameworks

- Unit: `JUnit`, `NUnit`, `Mocha`
- UI: `Selenium`, `Appium`
- Web API: `Postman`, `RestAssured`

### 👨‍💻 Automation QA Engineers

- Programming knowledge *(C#, JS, etc.)*
- Work with databases, APIs
- Tools: Git, Docker, Jenkins, CI/CD pipelines

### 🧪 Sample Unit Test

```js
function sum(arr) {
  return arr.reduce((a, b) => a + b, 0);
}

function testSum() {
  if (sum([1, 2]) !== 3) throw 'Fail';
  if (sum([]) !== 0) throw 'Fail';
}
```

---

## 🌐 Web Automation with Selenium

Selenium is used to automate **UI testing** by simulating user interactions in a browser.  
It allows testing of entire workflows and user interfaces in a real or headless browser environment.

### ✅ Selenium can:
- Simulate clicks, typing, and form submissions
- Validate UI elements and behaviors
- Perform cross-browser testing
- Integrate into automated pipelines

> 📌 Often used in **system-level tests** of web applications.

---

## 🔁 CI/CD: Continuous Integration & Delivery

### 🧱 SDLC – Software Development Life Cycle

1. Requirements Analysis  
2. Design  
3. Development  
4. Testing  
5. Maintenance

### 🔄 CI/CD Pipeline

#### CI (Continuous Integration):
- Frequent integration of code changes
- Automatic unit/integration testing after each commit

#### CD (Continuous Delivery):
- Automatic deployment to testing or production environments
- Enables faster, safer software releases

### 👨‍💻 QA Engineers contribute to:
- Setting up and maintaining CI/CD processes
- Monitoring KPIs and quality metrics
- Ensuring automated tests are triggered in pipelines

---

## 📌 Summary

✅ QA engineers **ensure software quality** at all stages  
🧪 They **plan and perform manual and automated tests**  
🐞 They **track and report bugs** effectively  
⚙️ They **collaborate with CI/CD systems, tools, and developers**  
💻 They are involved **throughout the entire development lifecycle**

🎓 This is the final lecture of **Programming Fundamentals with C#**  
It lays the foundation for a career as a **QA Engineer** or **Automation Tester** 🚀
