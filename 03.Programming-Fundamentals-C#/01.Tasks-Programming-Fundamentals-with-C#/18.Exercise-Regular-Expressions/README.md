# Regular Expressions - Exercise – Programming Fundamentals with C# 🧑💻

This folder contains tasks from the **Regular Expressions - Exercise** section of the _Programming Fundamentals with C#_ course at SoftUni. Below are the tasks with brief descriptions.

## 🔧 Tasks Overview:

---

### 📝 Task 1: Furniture
**Problem Statement:**  
Create a program to calculate the total cost of different types of furniture.  
You will be given some lines of input, until you receive the line `"Purchase"`.

For the line to be valid it should be in the following format:  
`">>{furniture name}<<{price}!{quantity}"`

- The price can be a floating-point number or a whole number.
- Store the names of the furniture and the total price.

At the end, print each bought furniture on a separate line in the format:

Bought furniture:
{1st name}
{2nd name}
...
Total money spend: {spend money}

*(formatted to the second decimal point)*

---

### 📝 Task 2: Race
**Problem Statement:**  
Write a program that processes information about a race.

- First line: list of participants separated by `", "`.
- Next lines: alphanumeric info (e.g., `"G!32e%o7r#32g$235@!2e"`).
- Extract letters as name and sum digits as distance.
- Add distance only if name is in the participant list.

At the end, print:

1st place: {first racer}
2nd place: {second racer}
3rd place: {third racer}

---

### 📝 Task 3: SoftUni Bar Income
**Problem Statement:**  
You receive input lines representing orders until `"end of shift"`.

A valid order contains:

- Customer: `%Name%` (capital letter followed by lowercase)
- Product: `<product>`
- Quantity: `|count|`
- Price: `price$` (real number)

Only process valid orders.

**Print:**
- `{customerName}: {product} - {totalPrice}`

**At end:**
- `Total income: {income}` (rounded to 2 decimals)

---

### 📝 Task 4: Star Enigma
**Problem Statement:**  
Decrypt messages encrypted with a STAR count shift:

- Count all letters: `s, t, a, r` (case-insensitive)
- Subtract that count from each character in the message

Valid decrypted message contains:

- `@planet`
- `:population`
- `!attackType!` → `"A"` or `"D"`
- `->soldierCount`

**Input:**
- First line: number of messages
- Next `n` lines: encrypted messages

**Output:**

Attacked planets: {count}
-> {planetName}
Destroyed planets: {count}
-> {planetName}

(Alphabetical order)

---

### 📝 Task 5: Nether Realms
**Problem Statement:**  
Extract health and damage for each demon from a comma-separated list.

- **Health**: sum of all characters' ASCII values (excluding digits, '+', '-', '*', '/', '.')
- **Damage**:
  - Sum all numbers (support + and -)
  - Apply `*` and `/` in order as they appear

**Output:**

{demon name} - {health} health, {damage} damage

(sorted alphabetically)

---

### 📝 Task 6: Extract Emails
**Problem Statement:**  
Extract valid email addresses from a given line of text.

Valid format: `<user>@<host>`

- **User**: letters/digits with optional `.`, `-`, `_` between
- **Host**: two or more words with letters and optional `-`, separated by dots

**Examples of valid emails:**

- info@softuni-bulgaria.org
- kiki@hotmail.co.uk
- no-reply@github.com

---

### 📝 Task 7: Winning Ticket
**Problem Statement:**  
Check tickets for winning combinations of:

`@`, `#`, `$`, `^` — repeated at least **6** times in **both halves** of a 20-char ticket.

**Output per ticket:**

- Invalid: `"invalid ticket"`
- No match: `"ticket "{ticket}" - no match"`
- Partial match: `"ticket "{ticket}" - {length}{symbol}"`
- Jackpot (10 symbols): `"ticket "{ticket}" - {length}{symbol} Jackpot!"`

---

### 📝 Task 8: Rage Quit
**Problem Statement:**  
Transform strings into rage messages:

- Input: alternating sequences like `"a3"` → output `"AAA"`
- All letters become **uppercase**
- Count unique symbols (case-insensitive)

**Output:**

Unique symbols used: {count}
{RAGE MESSAGE}

---

### 📝 Task 9: Post Office
**Problem Statement:**  
Extract valid words from a formatted message in 3 parts, separated by `"|"`.

- **First part**: capital letters wrapped in same symbol, e.g. `$AOTP$`
- **Second part**: ASCII code and length, e.g. `67:05`
- **Third part**: words separated by space

**Goal:** Match words with correct capital letter and length.

**Output:** matched words, each on a new line.

---

### 📝 Task 10: Santa's Secret Helper
**Problem Statement:**  
Decrypt messages using a numeric key.

**Decryption:**
- Subtract key from each character’s ASCII value

**Valid decrypted message contains:**

- `@name` — letters only
- `!G!` or `!N!` — behavior

**Output:**  
List names of all children with behavior `"G"`.

**Input:**

- First line: integer key
- Next lines: encrypted messages (until `"end"`)

---
