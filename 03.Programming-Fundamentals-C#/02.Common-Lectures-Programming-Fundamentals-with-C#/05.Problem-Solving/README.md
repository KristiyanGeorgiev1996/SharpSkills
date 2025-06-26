# Problem Solving: Designing Algorithms and Approaching Exam Problems 🧩

**Course:** Programming Fundamentals with C#

---

## Table of Contents 📚

1. Fundamental Skills of Software Engineers  
2. Definition of Problems and Problem Solving Methodology  
3. Effective Strategies for Solving Exam Problems  
4. Illustrative Sample Exam Problems  

---

## 1. Fundamental Skills of Software Engineers 🛠️

Software engineering demands a diverse set of technical competencies that can be broadly categorized into four key areas:  

- **Coding skills** – approximately 20%  
- **Algorithmic thinking and problem solving** – approximately 30%  
- **Fundamental software development concepts** – approximately 25%  
- **Programming languages and software technologies** – approximately 25%  

### Algorithmic Thinking  
Algorithmic thinking is the cornerstone of problem solving in software development. It involves:  

- Analyzing complex problems and decomposing them into clear, manageable steps (algorithms).  
- Cultivating this skill requires consistent practice, ideally by solving over a thousand programming problems over six to twelve months.  
- Courses such as *Programming Basics*, *Fundamentals*, and *Advanced Modules* at SoftUni provide a structured path for this development.  
- Notably, the choice of programming language is secondary to mastering algorithmic principles.

---

## 2. Defining Problems and Problem Solving Approach 🎯

### What Constitutes a Technical Problem?  
A technical problem typically involves designing and implementing a software solution that meets specified input, output, and behavioral requirements under certain constraints and limitations.  

Key characteristics include:  

- Input and output data and their states.  
- Desired functionality and behavior.  
- Technical barriers that require domain knowledge and problem-solving skills to overcome.

### Structured Problem-Solving Process  
Effective problem solving involves the following stages:  

1. **Problem definition:** Clarify the software requirements.  
2. **Problem analysis:** Thoroughly understand the problem context.  
3. **Solution ideation:** Generate potential approaches.  
4. **Solution evaluation:** Test and select the most viable option.  
5. **Algorithm design:** Formulate a step-by-step plan.  
6. **Implementation:** Translate the algorithm into code.  
7. **Review and testing:** Validate the solution against requirements and edge cases.

---

## 3. Best Practices for Tackling Exam Problems ✅

### Problem Analysis and Prioritization  
- Carefully read all problems before starting.  
- Assess their relative difficulty and allocate time accordingly.  
- Prioritize solving the easiest problems first to secure partial points early.  

### Utilizing Paper and Pen for Visualization 📝  
- Sketching ideas on paper enhances comprehension and problem structuring.  
- Squared paper is especially useful for algorithmic tasks, such as drawing tables or coordinate systems.  
- Visual aids accelerate cognitive processing better than screen-based brainstorming alone.

### Time Management ⏰  
- Begin with the quickest solvable problems.  
- Move on after achieving satisfactory partial results (80–90%).  
- Avoid excessive time investment on the final test cases; it’s more effective to maximize overall score across all problems.  

### Common Pitfalls to Avoid ❌  
- Starting to code without fully understanding the problem.  
- Neglecting to plan on paper.  
- Debugging solely by code inspection rather than using debugging tools.  
- Overcommitting time to a single problem or bug.  
- Failing to take short breaks to maintain mental clarity.  
- Coming to exams unprepared or attempting to cheat.  
- Working without a mouse or inefficient input methods.  
- Manually retyping test inputs instead of copying and pasting.

---

## 4. Sample Exam Problem: Longest Palindrome Sub-List 🎓

### Problem Description  
Given a list of letters, identify the longest contiguous sub-list that forms a palindrome (reads identically forwards and backwards).

### Problem Analysis  
Palindromes can be:  
- **Odd-length:** Centered on a single letter.  
- **Even-length:** Centered on two equal consecutive letters.

### Proposed Solutions  
1. Check all possible start and end positions for palindromes.  
2. Expand around all possible single and double centers to find palindromes.  
3. Check all sub-lists from longest to shortest for palindrome property.  

**Solution #2** is the most efficient approach.

### Algorithm Outline (Solution #2)  
- For each letter, consider it as the center and expand outwards while letters match.  
- For each pair of equal consecutive letters, expand similarly.  
- Track and return the longest palindrome found.

### Validation and Edge Cases  
Test against various inputs such as:  
- Single-letter strings (`a`, `abc`)  
- Repeated letters (`aa`, `aaa`)  
- Palindromes of varying lengths (`abba`, `aaaa`)  

### Summary of Problem-Solving Workflow  
- Define → Analyze → Ideate → Evaluate → Design → Implement → Review

---

This material forms an essential part of mastering problem-solving skills fundamental to success in software engineering and programming exams.  
Made with dedication for aspiring developers who seek to deepen their understanding and sharpen their skills. ❤️
