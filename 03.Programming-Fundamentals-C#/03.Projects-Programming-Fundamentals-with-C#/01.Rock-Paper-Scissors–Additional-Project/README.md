# 🎮 Rock - Paper - Scissors Game (C#)

## 📋 Description

This is a console implementation of the classic **Rock - Paper - Scissors** game, written in C#. The game allows the user to play against the computer by choosing one of three options: rock 🪨, paper 📄, or scissors ✂️.

### Rock - Paper - Scissors Game
![Rock Paper Scissors](../Images/0_3oJdSb7B26rt3xjJ.png)

The rules are simple:

- 🪨 Rock beats scissors (rock breaks scissors)
- ✂️ Scissors beats paper (scissors cut paper)
- 📄 Paper beats rock (paper covers rock)

If both players choose the same option, the result is a draw.

---

## ✅ Requirements

The game should meet the following criteria:

- The player can enter their choice by typing a single letter (`r`, `p`, or `s`) or the full word (`rock`, `paper`, `scissors`).
- The computer randomly selects its move.
- The program compares the player's and computer's moves and determines the winner.
- The program keeps track of the score: wins, losses, and draws.
- The game loops, allowing the player to play multiple rounds.
- After each round, the player can choose to play again or exit.
- Input validation – if the input is invalid, the player is prompted to try again.
- Console output uses clear color indicators for win (🟢 green), loss (🔴 red), and draw (🟡 yellow).

---

## ⚙️ Implementation Details

The solution includes the following main components:

- **Input Handling:** Reading and validating the player’s choice.
- **Random Move Generation:** Computer selects a random move.
- **Game Logic:** Determining the winner based on the rules.
- **Score Tracking:** Keeping a tally of wins, losses, and draws.
- **User Interface:** Console messages with colors and clear instructions.
- **Looping:** Main loop continues until the player chooses to stop.

---

## ▶️ How to Run

1. Clone the repository or download the source code.
2. Open the project in Visual Studio or another compatible C# environment.
3. Build and run the project.
4. Follow the on-screen instructions to play.

---

## 📚 Code Overview

Briefly about the main methods:

- `GetPlayerMove()` — Prompts the user for a choice and validates it.
- `GetComputerMove()` — Generates the computer’s random move.
- `DetermineWinner(player, computer)` — Returns the outcome (`win`, `lose`, or `draw`).
- `DisplayResult(result)` — Prints the result message with appropriate color.
- `PrintScore()` — Displays the current score.

---

## 🖥 Sample Output
==== Score ====
 - Player: 3  
 - Computer: 2  
 - Draws: 1  

Choose [r]ock, [p]aper or [s]cissors: r  
Computer chose: paper  
**You lose!**

Do you want to play again? (y/n): n  
Thanks for playing!



---

## 📄 License

This project is open source and licensed under the **MIT License**.
