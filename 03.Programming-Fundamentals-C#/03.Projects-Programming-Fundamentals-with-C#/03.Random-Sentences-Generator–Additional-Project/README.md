# 🎲 Random Sentence Generator (C#)

## 📋 Description
This is a fun console application that generates random sentences using predefined lists of names, places, verbs, nouns, adverbs, and details. Each generated sentence is unique and can be shared to surprise friends or create humorous content on social media.

The sentences follow a simple model:

- **Who from where**: [Name + from + Place] (e.g., "David from Sofia")
- **Action**: [Adverb + Verb + Noun] (e.g., "slowly eats cake")
- **Detail**: Additional context like "near the river", "at home", or "in the park"

## ✅ Requirements
The project includes the following features:

- Predefined arrays with words for sentence building: names, places, verbs, nouns, adverbs, details.
- A method to randomly select a word from each array.
- Sentence generation by combining randomly selected words according to the model.
- Running in a loop that generates a new sentence each time the user presses Enter.
- Handling input for pausing and continuous generation.
- Console output with clearly displayed generated sentences.

## ⚙️ Implementation Details
Main parts of the solution:

- **Sentence model:** Combines different categories of words into meaningful sentences.
- **Random word selection:** Uses the `Random` class to pick a random word.
- **Random word method:** Reusable method that takes an array and returns a random word.
- **Main loop:** Continuously generates sentences until the user stops.
- **User interaction:** Prompts the user to generate a new sentence by pressing Enter.

## ▶️ How to Run
1. Clone or download the project source code.
2. Open it in Visual Studio or another compatible C# environment.
3. Build and run the project.
4. Follow the on-screen instructions to generate new sentences.

## 📚 Code Overview
Key methods:

- `GetRandomWord(string[] words)` — Returns a random word from the given array.
- Main program loop — Calls `GetRandomWord()` for each category and builds the sentence.
- Console output — Displays the generated sentence and instructions for next action.

## 🖥 Sample Output
 - David from Sofia slowly eats cake near the river.
 - Press [Enter] to generate a new sentence...


## 💡 Extension Ideas
- Add more words and categories for richer sentences.
- Create more complex sentences or questions.
- Implement a graphical user interface.
- Save generated sentences to a file.
- Add a timer or limit on the number of sentences generated per session.

## 📄 License
This project is open source and licensed under the MIT License.
