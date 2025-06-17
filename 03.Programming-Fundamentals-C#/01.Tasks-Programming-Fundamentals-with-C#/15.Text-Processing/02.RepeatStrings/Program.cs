string[] words = Console.ReadLine().Split(" ");

for (int i = 0; i < words.Length; i++)
{
    for (int k = 0; k < words[i].Length; k++)
    {
        Console.Write(words[i]);
    }
}