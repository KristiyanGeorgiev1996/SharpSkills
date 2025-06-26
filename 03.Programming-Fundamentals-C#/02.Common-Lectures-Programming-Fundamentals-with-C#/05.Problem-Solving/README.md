# Problem Solving: How to Design Algorithms and Solve Exam Problems? 🧩

## Part of the course: Programming Fundamentals with C#

---

## Table of Contents 📚

1. Fundamental Skills of Software Engineers  
2. Problems: Definition and Problem Solving  
3. Tips and Best Practices for Solving Exam Problems  
4. Sample Exam Problems  

---

## 1. Fundamental Skills of Software Engineers 🛠️

### Software Engineers’ Skills  
- Four main groups of technical skills:  
  - Coding skills – 20%  
  - Algorithmic thinking and problem solving – 30%  
  - Fundamental software development concepts – 25%  
  - Programming languages and software technologies – 25%

### Algorithmic Thinking 🧠  
- Algorithmic (engineering, mathematical) thinking means:  
  - Analyzing problems and finding solutions  
  - Breaking the problem down into steps (algorithm)  
- How to develop algorithmic thinking?  
  - Solve 1000+ programming problems  
  - It takes 6 to 12 months of daily practice  
  - Courses at SoftUni: Programming Basics, Fundamentals, and Advanced  
- The programming language does not matter!

---

## 2. Problems: Definition and Problem Solving 🎯

### What is a Technical Problem?  
- An assignment to design and implement a program, app, or software system  
- Input data + state, output data + state, behavior  
- Goals: desired functionality  
- Technical difficulties: barriers and limitations  
- Requires knowledge, skills, and experience

### Solving a Problem  
- Requires logical (algorithmic) thinking  
- Steps:  
  1. Define the problem (requirements)  
  2. Analyze and understand it  
  3. Identify possible solutions  
  4. Evaluate and choose the best solution  
  5. Plan actions (algorithm design)  
  6. Implement the algorithm (coding)  
  7. Test and review results

### Technical Problem-Solving Skills  
- Software developers have strong problem-solving skills  
- Logical thinking and problem analysis  
- Ability to design and implement algorithms  
- Programming is impossible without problem solving!  
- Similar skills are developed in school solving math and physics problems

---

## 3. Tips and Best Practices for Solving Exam Problems ✅

### Read and Analyze the Problems Carefully  
- You have 3 problems to solve in 4 hours  
- Estimate the difficulty of each from your perspective  
- Read the requirements, do not invent them!  
- Start with the easiest and fastest problem  
- Leave the hardest problem for last  
- Move to the next problem only after thoroughly testing the previous one

### Use Paper and Pen 📝  
- Never start coding without paper and pen  
- Visualize your ideas  
- Paper helps your brain think faster and clearer  
- Squared paper is especially useful for algorithmic problems

### Manage Your Time ⏰  
- Start with the quickest problem  
- Repeat for the next quickest  
- After reaching 80-90%, move on  
- Don’t spend hours chasing the last 10% of test cases  
- Scoring 80-90% on all 3 problems is better than 100% on just 1

### Typical Exam Mistakes ❌  
- Starting coding immediately without reading the problems  
- Trying to solve problems mentally without notes  
- Debugging by just reading code instead of using a debugger  
- Spending all time on the first problem  
- Spending hours fixing minor bugs  
- Not taking breaks when stuck  
- Coming unprepared or trying to cheat  
- Working without a mouse  
- Manually typing input instead of copy-pasting

---

## 4. Sample Exam Problems 🎓

### Technical Problem: Longest Palindrome Sub-List  
- Input: list of letters  
- Goal: find the longest sub-list which is a palindrome (reads the same forwards and backwards)

### Analysis  
- Two types of palindromes:  
  - Odd length (single letter center)  
  - Even length (two equal consecutive letters as center)

### Solutions  
1. Check all start and end positions for palindrome  
2. Check all single and double center points for palindrome expansion  
3. Check all sub-lists by decreasing length from n to 1  
- The most efficient is solution #2

### Algorithm (Solution #2)  
- For each letter as center, expand outwards to find palindrome  
- For each pair of equal consecutive letters as center, expand similarly  
- Choose the longest palindrome found

### Review and Testing  
- Test edge cases such as: `abc`, `aa`, `aaa`, `abba`, etc.  
- Consider if improvements are possible

### Summary of Problem-Solving Stages  
- Define the problem  
- Analyze deeply  
- Identify potential solutions  
- Evaluate and pick the best solution  
- Design the algorithm  
- Implement and review results

---

