# Regular Expressions – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Regular Expressions** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

### 📝 Task 1: Match Full Name  
**Problem Statement:**  
Write a C# Program to match full names from a list of names and print them on the console.

Writing the Regular Expression

First, create a regular expression to match a valid full name, according to these conditions:

· A valid full name has the following characteristics:

o It consists of two words.

o Each word starts with a capital letter.

o After the first letter, it only contains lowercase letters afterward.

o Each of the two words should be at least two letters long.

o The two words are separated by a single space.

To help you out, we've outlined several steps: 1. Use an online regex tester like https://regex101.com/.

2. Check out how to use character sets (denoted with square brackets - "[]").

3. Specify that you want two words with a space between them (the space character ' ' and not any whitespace symbol).

4. For each word, specify that it should begin with an uppercase letter using a character set. The desired characters are in a range – from 'A' to 'Z'.

5. For each word, specify that what follows the first letter are only lowercase letters, one or more – use another character set and the correct quantifier.

6. To prevent capturing of letters across new lines, put "\b" at the beginning and the end of your regex. This will ensure that what precedes and what follows the match is a word boundary (like a new line).

To check your RegEx, use these values for reference (paste all of them in the Test String field):

Match ALL of these Match NONE of these

Bethany Taylor

John Smith Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam Smith


---

### 📝 Task 2: Match Phone Number
**Problem Statement:**  
Create a regular expression to match a valid phone number from Sofia. After you find all valid phones, print them on the console, separated by a comma and a space ", ".

Compose the Regular Expression

A valid number has the following characteristics:

· It starts with "+359"

· Then, it is followed by the area code (always 2)

· After that, it's followed by the number itself:

o The number consists of 7 digits (separated into two groups of 3 and 4 digits respectively).

· The different parts are separated by either a space or a hyphen ('-').

You can use the following RegEx properties to help with the matching:

· Use quantifiers to match a specific number of digits

· Use a capturing group to make sure the delimiter is only one of the allowed characters (space or hyphen) and not a combination of both (e.g. +359 2-111 111 has mixed delimiters, it is invalid). Use a group backreference to achieve this.

· Add a word boundary at the end of the match to avoid partial matches (the last example on the right-hand side).

· Ensure that before the '+' sign there is either a space or the beginning of the string.

You can use the following table of values to test your RegEx against:

Match ALL of these Match NONE of these

+359 2 222 2222

+359-2-222-2222 359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222

---

### 📝 Task 3: Match Dates
**Problem Statement:**  
Write a program, which matches a date in the format "dd{separator}MMM{separator}yyyy". Use named capturing groups in your regular expression.

Compose the Regular Expression

Every valid date has the following characteristics:

· Always starts with two digits, followed by a separator.

· After that, it has one uppercase and two lowercase letters (e.g. Jan, Mar).

· After that, it has a separator and exactly 4 digits (for the year).

· The separator could be either of three things: a period ('. '), a hyphen ('-') or a forward-slash ('/').

· The separator needs to be the same for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is NOT). Use a group backreference to check for this.

You can follow the table below to help with composing your RegEx:

Match ALL of these Match NONE of these

13/Jul/1928, 10-Nov-1934, 25.Dec.1937 01/Jan-1951, 23/sept/1973, 1/Feb/2016

Use named capturing groups for the day, month and year.
