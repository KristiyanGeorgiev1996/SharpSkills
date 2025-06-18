# 🎯 Guess the Number Game (C#)

## 📝 Description

"Guess the Number" is a console-based game where the computer selects a random number within a defined range (e.g. 1 to 100), and the player's goal is to guess that number. After each guess, the computer provides a hint whether the number is higher or lower than the entered value. The game continues until the player correctly guesses the number.

---

## ✅ Requirements

The game must meet the following criteria:

- The computer selects a random number between 1 and 100 (or other, based on level).
- The player enters a number and receives hints to guess higher or lower.
- Input validation is implemented – invalid inputs display a proper message.
- The game continues until the number is guessed.
- After guessing correctly, the player can choose to play again.
- With each new level, the guessing range can increase.
- The number of attempts per round is tracked.
- Code is clean, structured, and separated into methods.

---

## ⚙️ Technologies

- Language: C#
- Development Environment: Visual Studio / Visual Studio Code
- .NET Framework / .NET Core
- Console Application

---

## ▶️ How to Run

1. Clone the repository or download the source code.
2. Open the project in Visual Studio or Visual Studio Code.
3. Build and run the project.
4. Follow the instructions in the console to play.

---

## 📂 Code Overview

The main game logic is cleanly structured and organized:

- `GenerateRandomNumber(int min, int max)`  
  → Generates a random number between given bounds.

- `ReadUserGuess()`  
  → Reads and validates user input as an integer.

- `PrintHint(int guess, int secretNumber)`  
  → Gives a hint whether the secret number is higher or lower.

- `PlayGame(int level, int min, int max)`  
  → Main game loop. Handles input, logic checks, and attempt counting.

- `AskToPlayAgain()`  
  → Asks the player if they want to continue. If yes, proceeds to next level.

- `Main()`  
  → Entry point of the program. Initializes and launches the game.

---

## 💻 Sample Output

```text
Level: 1 (1 - 100)
Guess the number: 50
Your guess is higher than the secret number.

Guess the number: 25
Your guess is lower than the secret number.

Guess the number: 37
Congratulations! You guessed the number in 3 attempts.

Do you want to play again? (y/n): n
Thanks for playing!

## 💡 Extension Ideas

- ⏱️ Add a timer and time limit per round.  
- 📊 Show visual progress indicators.  
- 💾 Save best scores to a text file.  
- 🎮 Add multiple difficulty modes.  
- 🔧 Allow the user to choose their own custom range.  

---

## 📄 License

This project is open-source and licensed under the **MIT License**.
