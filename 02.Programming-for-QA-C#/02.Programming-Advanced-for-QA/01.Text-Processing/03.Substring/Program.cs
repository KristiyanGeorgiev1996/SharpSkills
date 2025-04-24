
string textToRemove = Console.ReadLine();
string text = Console.ReadLine();

// проверяваме дали текста съдържа текста за премахване
while (text.Contains(textToRemove))
{
    // вземаме стартовия индекса на текста за премахване
    int startIndex = text.IndexOf(textToRemove);

    // премахваме от този индекс, 
    // толкова елементи след него, колкото е дължината
    text = text.Remove(startIndex, textToRemove.Length);
}

Console.WriteLine(text);