using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> wordArray = Console.ReadLine().Split(" ").ToList();

        Dictionary<char, int> chars = new();

        for (int i = 0; i < wordArray.Count; i++)
        {
            for (int j = 0; j < wordArray[i].Length; j++)
            {
                char letter = wordArray[i][j];
                if (!chars.ContainsKey(letter))
                {
                    chars.Add(letter, 1);
                }
                else
                {
                    chars[letter]++;
                }
            }
        }

        foreach (var letter in chars)
        {
            Console.WriteLine($"{letter.Key} -> {letter.Value}");
        }
    }
}
