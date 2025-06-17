using System;

public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int explosionStrength = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '>')
            {
                Console.Write('>'); // Print '>'
                explosionStrength += text[i + 1] - '0'; // Add the strength of the explosion
            }
            else if (explosionStrength > 0)
            {
                explosionStrength--; // Skip this character
            }
            else
            {
                Console.Write(text[i]); // Print the character
            }
        }
    }
}
