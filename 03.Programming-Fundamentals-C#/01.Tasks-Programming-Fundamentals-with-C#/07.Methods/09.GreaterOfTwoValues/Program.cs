using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            Console.WriteLine(GameMax(inputName, name1, name2));
        }

        static string GameMax(string inputName, string name1, string name2)
        {
            string result = "";

            switch (inputName)
            {
                case "int":
                    result = (Math.Max(int.Parse(name1), int.Parse(name2))).ToString();
                    break;
                case "char":
                case "string":
                    return name1[0] > name2[0] ? name1 : name2;
                default:
                    break;
            }

            return result;
        }
    }
}