using System;
using System.Collections.Generic;
using System.Linq;

public class Dragon
{
    public string Name { get; set; }

    public double Damage { get; set; }

    public double Health { get; set; }

    public double Armor { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split();

            string type = input[0], dragonName = input[1], damage = input[2], health = input[3], armor = input[4];

            if (damage == "null")
                damage = "45";
            if (health == "null")
                health = "250";
            if (armor == "null")
                armor = "10";

            Dragon dragon = new Dragon()
            {
                Name = dragonName,
                Damage = double.Parse(damage),
                Health = double.Parse(health),
                Armor = double.Parse(armor)
            };

            if (!dragons.ContainsKey(type))
            {
                var temp = new List<Dragon>();
                temp.Add(dragon);
                dragons.Add(type, temp);
            }
            else if (dragons.ContainsKey(type))
            {
                bool containsName = false;
                foreach (var dr in dragons[type].Where(n => n.Name == dragonName))
                {
                    dr.Damage = double.Parse(damage);
                    dr.Health = double.Parse(health);
                    dr.Armor = double.Parse(armor);
                    containsName = true;
                }
                if (!containsName)
                {
                    dragons[type].Add(dragon);
                }
            }
        }

        foreach (var dragon in dragons)
        {
            double averageDamage = 0, averageHealth = 0, averageArmor = 0;

            foreach (var item in dragon.Value)
            {
                averageDamage += item.Damage;
                averageHealth += item.Health;
                averageArmor += item.Armor;
            }

            Console.WriteLine($"{dragon.Key}::({averageDamage / dragon.Value.Count:f2}/{averageHealth / dragon.Value.Count:f2}/{averageArmor / dragon.Value.Count:f2})");
            foreach (var element in dragon.Value.OrderBy(n => n.Name))
            {
                Console.WriteLine($"-{element.Name} -> damage: {element.Damage}, health: {element.Health}, armor: {element.Armor}");
            }
        }
    }
}