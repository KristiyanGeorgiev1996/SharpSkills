List<People> peoples = new List<People>();

while (true)
{
    string command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }
    else
    {
        People people = new People();
        string[] splittedCommand = command.Split(" ");
        string name = splittedCommand[0];
        string ID = splittedCommand[1];
        int age = int.Parse(splittedCommand[2]);

        people.ID = ID;
        people.Age = age;
        people.Name = name;
        peoples.Add(people);
    }
}
peoples = peoples.OrderBy(a => a.Age).ToList();
foreach (People people in peoples)
{
    Console.WriteLine($"{people.Name} with ID: {people.ID} is {people.Age} years old.");
}
class People
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
}