namespace P02_HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            // 1. Read Input
            int n = int.Parse(Console.ReadLine());

            // 2. Process Logic
            for (int i = 0; i < n; i++)
            {
                string[] currentCmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // Defensive Programming Rule: Check if the array is not null and check if there are any elements inside (Length > 0)
                string name = currentCmd[0];

                if (currentCmd.Length == 3)
                {
                    // "{name} is going" command
                    if (guestList.Contains(name))
                    {
                        // We will enter here only if guestList contains name inside
                        Console.WriteLine($"{name} is already in the list!");
                        continue; // Go directly to the next command after error
                    }

                    guestList.Add(name);
                }
                else if (currentCmd.Length == 4)
                {
                    // "{name} is not going" command
                    if (!guestList.Contains(name))
                    {
                        // We will enter here only if guestList does not contain name inside
                        Console.WriteLine($"{name} is not in the list!");
                        continue; // Go directly to the next command after error
                    }

                    guestList.Remove(name);
                }
            }

            // 3. Print Output
            foreach (string name in guestList)
            {
                Console.WriteLine(name);
            }
        }
    }
}