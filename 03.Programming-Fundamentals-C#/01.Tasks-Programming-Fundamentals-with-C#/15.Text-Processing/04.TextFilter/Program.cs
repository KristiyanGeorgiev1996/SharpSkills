string[] bannedStrings = Console.ReadLine().Split(", ");
string text = Console.ReadLine();
////string stars = new string('*', 3);

for (int i = 0; i < bannedStrings.Length; i++)
{
    text = text.Replace(bannedStrings[i], new string('*', bannedStrings[i].Length));
}

Console.WriteLine(text);