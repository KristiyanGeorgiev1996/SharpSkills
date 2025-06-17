using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "End")
            {
                break;
            }

            string[] commandArray = command.Split();

            if (commandArray[0] == "Add")
            {
                int numberToAdd = int.Parse(commandArray[1]);
                numbers.Add(numberToAdd);
            }
            else if (commandArray[0] == "Insert")
            {
                int numberToInsert = int.Parse(commandArray[1]);
                int indexToInsert = int.Parse(commandArray[2]);
                if (indexToInsert >= numbers.Count || indexToInsert < 0)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    numbers.Insert(indexToInsert, numberToInsert);
                }
            }
            else if (commandArray[0] == "Remove")
            {
                int indexToRemove = int.Parse(commandArray[1]);
                if (indexToRemove >= numbers.Count || indexToRemove < 0)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    numbers.RemoveAt(indexToRemove);
                }
            }
            else if (commandArray[0] == "Shift" && commandArray[1] == "left")
            {
                int numberToShiftLeft = int.Parse(commandArray[2]);
                numberToShiftLeft = numberToShiftLeft % numbers.Count; // Оптимизация на броя на завъртанията
                for (int i = 0; i < numberToShiftLeft; i++)
                {
                    int n = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(n);
                }
            }
            else if (commandArray[0] == "Shift" && commandArray[1] == "right")
            {
                int numberToShiftRight = int.Parse(commandArray[2]);
                numberToShiftRight = numberToShiftRight % numbers.Count; // Оптимизация на броя на завъртанията
                for (int i = 0; i < numberToShiftRight; i++)
                {
                    int x = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(0, x);
                }
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
