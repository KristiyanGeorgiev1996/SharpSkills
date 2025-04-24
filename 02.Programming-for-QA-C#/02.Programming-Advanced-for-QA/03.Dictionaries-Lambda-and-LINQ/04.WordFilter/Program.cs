string[] words = Console.ReadLine()
                       .Split(" ")
                       .Where(w => w.Length % 2 == 0)
                       .ToArray();

foreach (var word in words)
{
    Console.WriteLine(word);
}


// цялото решение на един ред,

//Console.ReadLine()
//.split(" ")
//.where(w => w.length % 2 == 0)
//.tolist()
//.foreach (console.writeline) ;