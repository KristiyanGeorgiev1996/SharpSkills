using System;

class Program
{
    static void Main()
    {
        Console.Title = "Guess the Number Game";
        bool playAgain = true;
        int level = 1;
        int min = 1;
        int max = 100;

        while (playAgain)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Welcome to Guess the Number - Level {level} ({min} - {max})");
            Console.ResetColor();

            Random random = new Random();
            int secretNumber = random.Next(min, max + 1);
            int attempts = 0;

            while (true)
            {
                Console.Write($"Enter your guess ({min} - {max}): ");
                string input = Console.ReadLine();

                bool isValid = int.TryParse(input, out int guess);

                if (!isValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ResetColor();
                    continue;
                }

                attempts++;

                if (guess < min || guess > max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Number out of range.");
                    Console.ResetColor();
                    continue;
                }

                if (guess == secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    Console.ResetColor();
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Try a higher number.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Try a lower number.");
                    Console.ResetColor();
                }
            }

            Console.Write("Do you want to play again? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "y" && answer != "yes")
            {
                Console.WriteLine("Thanks for playing!");
                playAgain = false;
            }
            else
            {
                // Увеличаваме нивото и диапазона
                level++;
                max += 100;
            }
        }
    }
}
