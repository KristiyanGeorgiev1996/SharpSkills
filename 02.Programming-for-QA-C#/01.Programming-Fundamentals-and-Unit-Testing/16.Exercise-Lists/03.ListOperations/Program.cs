namespace P03_ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            // 2. Process Logic
            string currentCmd = Console.ReadLine();
            while (currentCmd != "End")
            {
                // Command is not "End" => Process this command
                string[] cmdArgs = currentCmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
                if (cmdType == "Add")
                {
                    // Perform Adding
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numberToAdd);
                }
                else if (cmdType == "Insert")
                {
                    // Perform Insertion
                    int numberToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    bool isSuccess = InsertNumber(numbers, numberToInsert, index);
                    if (!isSuccess)
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (cmdType == "Remove")
                {
                    // Perform Removal
                    int removeIndex = int.Parse(cmdArgs[1]);

                    bool isSuccess = RemoveNumber(numbers, removeIndex);
                    if (!isSuccess)
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (cmdType == "Shift")
                {
                    // Perform Shifting -> Left or Right
                    string shiftDirection = cmdArgs[1];
                    int shiftsCount = int.Parse(cmdArgs[2]);

                    ShiftNumbers(numbers, shiftDirection, shiftsCount);
                }

                // Take the next command and compare it to "End"
                currentCmd = Console.ReadLine();
            }

            // 3. Print Output
            Console.WriteLine(string.Join(' ', numbers));
        }

        // This can't be done simpler
        static void ShiftNumbers(List<int> numbers, string direction, int count)
        {
            // Shifting empty lists or list with one element will always return the same result
            if (numbers.Count > 1)
            {
                count = count % numbers.Count;

                for (int i = 0; i < count; i++)
                {
                    // Repeats shifting count times
                    if (direction == "left")
                    {
                        // Perform left shift => First becomes last
                        // 1. Take first element and store it
                        int firstElement = numbers[0];

                        // 2. Remove the first element
                        numbers.RemoveAt(0);

                        // 3. Insert the first element at the end
                        numbers.Add(firstElement);
                    }
                    else if (direction == "right")
                    {
                        // Perform right shift => Last becomes first
                        // 1. Take last element and store it
                        int lastElement = numbers[numbers.Count - 1];

                        // 2. Remove the last element
                        numbers.RemoveAt(numbers.Count - 1);

                        // 3. Insert the last element at first position
                        numbers.Insert(0, lastElement);
                    }
                }
            }
        }

        // This method may be omitted
        static bool RemoveNumber(List<int> numbers, int index)
        {
            bool result = false; // By default I assume that removal is NOT successful
            if (IsIndexValid(numbers, index))
            {
                numbers.RemoveAt(index);
                result = true;
            }

            return result;
        }

        // This method may be omitted
        static bool InsertNumber(List<int> numbers, int number, int index)
        {
            // ReSharper disable once ReplaceWithSingleAssignment.True
            bool result = false; // By default I assume that insertion is NOT successful
            if (IsIndexValid(numbers, index))
            {
                numbers.Insert(index, number);
                result = true;
            }

            return result;
        }

        static bool IsIndexValid(List<int> numbers, int index)
        {
            // ReSharper disable once ReplaceWithSingleAssignment.False
            bool result = false; // By default I assume that the index is invalid
            if (index >= 0 && index < numbers.Count)
            {
                result = true;
            }

            return result;
        }
    }
}