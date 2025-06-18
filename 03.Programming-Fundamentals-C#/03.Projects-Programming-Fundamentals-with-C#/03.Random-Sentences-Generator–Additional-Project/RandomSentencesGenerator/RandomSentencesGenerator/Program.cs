using System;

class RandomSentenceGenerator
{
    // Масиви с думи за съставяне на изречения
    static string[] names = { "Peter", "Michell", "Jane", "Steve" };
    static string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
    static string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
    static string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
    static string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
    static string[] details = { "near the river", "at home", "in the park" };

    // Създаваме един обект Random, който ще използваме във всички извиквания
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Welcome to the Random Sentence Generator!");
        Console.WriteLine("Press [Enter] to generate a new sentence or type 'exit' to quit.\n");

        while (true)
        {
            string randomName = GetRandomWord(names);
            string randomPlace = GetRandomWord(places);
            string randomAdverb = GetRandomWord(adverbs);
            string randomVerb = GetRandomWord(verbs);
            string randomNoun = GetRandomWord(nouns);
            string randomDetail = GetRandomWord(details);

            // Конструиране на изречението по модела: [Who from where] [Action] [Detail]
            string sentence = $"{randomName} from {randomPlace} {randomAdverb} {randomVerb} {randomNoun} {randomDetail}.";

            Console.WriteLine(sentence);

            Console.Write("\nPress [Enter] to generate another sentence or type 'exit' to quit: ");
            string userInput = Console.ReadLine();

            if (userInput.Trim().ToLower() == "exit")
            {
                Console.WriteLine("Thanks for using the Random Sentence Generator. Goodbye!");
                break;
            }
            Console.WriteLine();
        }
    }

    // Метод, който връща произволна дума от подаден масив
    static string GetRandomWord(string[] words)
    {
        int index = random.Next(words.Length);
        return words[index];
    }
}
