using System;

class Program
{
    // Константи за ходовете
    const string ROCK = "rock";
    const string PAPER = "paper";
    const string SCISSORS = "scissors";

    // Резултати
    static int playerScore = 0;
    static int computerScore = 0;
    static int draws = 0;

    static void Main()
    {
        Console.Title = "Rock - Paper - Scissors Game";

        while (true)
        {
            Console.Clear();
            PrintScore();

            string playerMove = GetPlayerMove();
            if (playerMove == null) continue;

            string computerMove = GetComputerMove();
            Console.WriteLine($"Computer chose: {computerMove}");

            string result = DetermineWinner(playerMove, computerMove);
            DisplayResult(result);

            Console.Write("\nDo you want to play again? (y/n): ");
            string answer = Console.ReadLine().ToLower();
            if (answer != "y" && answer != "yes")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }

    static string GetPlayerMove()
    {
        Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
        string input = Console.ReadLine().ToLower();

        switch (input)
        {
            case "r":
            case "rock": return ROCK;
            case "p":
            case "paper": return PAPER;
            case "s":
            case "scissors": return SCISSORS;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please try again...");
                Console.ResetColor();
                return null;
        }
    }

    static string GetComputerMove()
    {
        Random random = new Random();
        int choice = random.Next(1, 4); // 1, 2, or 3
        return choice switch
        {
            1 => ROCK,
            2 => PAPER,
            3 => SCISSORS,
            _ => ROCK
        };
    }

    static string DetermineWinner(string player, string computer)
    {
        if (player == computer)
        {
            draws++;
            return "draw";
        }

        if ((player == ROCK && computer == SCISSORS) ||
            (player == PAPER && computer == ROCK) ||
            (player == SCISSORS && computer == PAPER))
        {
            playerScore++;
            return "win";
        }

        computerScore++;
        return "lose";
    }

    static void DisplayResult(string result)
    {
        switch (result)
        {
            case "win":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                break;
            case "lose":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!");
                break;
            case "draw":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("It's a draw!");
                break;
        }
        Console.ResetColor();
    }

    static void PrintScore()
    {
        Console.WriteLine("==== Score ====");
        Console.WriteLine($"Player:   {playerScore}");
        Console.WriteLine($"Computer: {computerScore}");
        Console.WriteLine($"Draws:    {draws}");
        Console.WriteLine("==============\n");
    }
}
