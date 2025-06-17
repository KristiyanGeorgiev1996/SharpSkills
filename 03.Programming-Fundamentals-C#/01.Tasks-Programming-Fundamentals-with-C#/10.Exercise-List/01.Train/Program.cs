using System;

List<int> passangers = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxPassangers = int.Parse(Console.ReadLine());
string command = Console.ReadLine();


while (command != "end")
{
    string[] commandArray = command.Split();

    if (commandArray[0] == "Add")
    {
        int numberToAdd = int.Parse(commandArray[1]);
        passangers.Add(numberToAdd);
    }
    else if (commandArray[0] != "Add" && commandArray[0] != "end")
    {
        int myInt = int.Parse(command);
        ///// if (myInt > maxPassangers)
        ////{
        ////    passangers.Add(myInt);
        //// }
        if (myInt <= maxPassangers)
        {
            for (int i = 0; i < passangers.Count; i++)
            {
                if (passangers[i] + myInt <= maxPassangers)
                {
                    passangers[i] = passangers[i] + myInt;
                    break;
                }
            }
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", passangers));



