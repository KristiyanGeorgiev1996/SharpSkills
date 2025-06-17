List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

// Game logic
while (firstHand.Count > 0 && secondHand.Count > 0)
{
    int firstCard = firstHand[0];
    int secondCard = secondHand[0];

    // Remove the top cards from both hands
    firstHand.RemoveAt(0);
    secondHand.RemoveAt(0);

    if (firstCard > secondCard)
    {
        // First player wins this round
        firstHand.Add(firstCard);
        firstHand.Add(secondCard);
    }
    else if (secondCard > firstCard)
    {
        // Second player wins this round
        secondHand.Add(secondCard);
        secondHand.Add(firstCard);
    }
    // If the cards are equal, both are discarded, so nothing needs to be added back
}

// Determine the winner and calculate the sum of remaining cards
if (firstHand.Count > 0)
{
    Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
}
else
{
    Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
}