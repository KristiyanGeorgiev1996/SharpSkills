using System;
using System.Linq;

namespace P09.KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int lengthOfDNA = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int maxCountOfOnes = 0;
            int[] bestDNA = new int[lengthOfDNA];
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            int currentDNAs = 0;
            int bestDNARow = 0;

            while (command != "Clone them!")
            {
                int[] currentArr = command
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int countOfOnes = 0;
                int currentMaxCountOfOnes = 0;
                int index = 0;
                int currentBestIndex = -1;

                for (int currentIndex = 0; currentIndex < currentArr.Length; currentIndex++)
                {
                    if (currentArr[currentIndex] == 1)
                    {
                        countOfOnes++;

                        if (countOfOnes == 1)
                        {
                            index = currentIndex;
                        }
                    }
                    else
                    {
                        if (countOfOnes > currentMaxCountOfOnes)
                        {
                            currentMaxCountOfOnes = countOfOnes;
                            currentBestIndex = index;
                        }

                        countOfOnes = 0;
                    }
                }

                currentDNAs++;

                if (currentDNAs == 1 || currentMaxCountOfOnes > maxCountOfOnes || currentBestIndex < bestSequenceIndex || currentArr.Sum() > bestSequenceSum)
                {
                    maxCountOfOnes = currentMaxCountOfOnes;
                    bestSequenceIndex = currentBestIndex;
                    bestSequenceSum = currentArr.Sum();
                    bestDNARow = currentDNAs;
                    bestDNA = currentArr;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDNARow} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestDNA));
        }
    }
}