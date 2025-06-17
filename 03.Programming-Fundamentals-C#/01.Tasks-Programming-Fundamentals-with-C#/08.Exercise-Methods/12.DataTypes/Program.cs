using System;

class Program
{
    static void Main()
    {
        // Read the type of data
        string dataType = Console.ReadLine().Trim();

        // Read and process the input based on the data type
        switch (dataType)
        {
            case "int":
                int intValue = int.Parse(Console.ReadLine().Trim());
                ProcessInput(intValue);
                break;

            case "real":
                double doubleValue = double.Parse(Console.ReadLine().Trim());
                ProcessInput(doubleValue);
                break;

            case "string":
                string stringValue = Console.ReadLine().Trim();
                ProcessInput(stringValue);
                break;

            default:
                Console.WriteLine("Invalid data type entered.");
                break;
        }
    }

    static void ProcessInput(int number)
    {
        int result = number * 2;
        Console.WriteLine(result);
    }

    static void ProcessInput(double number)
    {
        double result = number * 1.5;
        Console.WriteLine(result.ToString("F2"));
    }

    static void ProcessInput(string text)
    {
        string result = $"${text}$";
        Console.WriteLine(result);
    }
}
