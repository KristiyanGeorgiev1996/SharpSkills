namespace _04.PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

        public string Name { get; set; }

        public string Element { get; set; }

        public int Health { get; set; }
    }
}
namespace _04.PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string[] trainerInfo = input.Split(' ');
                string trainerName = trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string pokemonElement = trainerInfo[2];
                int pokemonHealth = int.Parse(trainerInfo[3]);

                // търся дали вече има треньор с това име
                if (trainers.Any(t => t.Name == trainerName))
                {
                    // изваждам си съществуващия треньор от списъка
                    Trainer existingTrainer = trainers.First(t => t.Name == trainerName);
                    Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                    // добавям покемона към треньора
                    existingTrainer.Pokemons.Add(newPokemon);
                }
                else
                {
                    // създавам си нов треньор
                    Trainer newTrainer = new Trainer(trainerName);
                    Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                    // добавям покемона към треньора
                    newTrainer.Pokemons.Add(newPokemon);

                    // добавям новия треньор в списъка
                    trainers.Add(newTrainer);
                }

                input = Console.ReadLine();
            }

            string element = Console.ReadLine();

            while (element != "End")
            {
                // обикалям всички треньори в спосъка
                foreach (var currentTrainer in trainers)
                {
                    // проверявам дали той има поне един покемон с този елемент
                    if (currentTrainer.Pokemons.Any(p => p.Element == element))
                    {
                        // получава една значка
                        currentTrainer.NumberOfBadges++;
                    }
                    else // той няма полемон с този елемент
                    {
                        // обикалям всички покемони и вадя от всеки 10 Health
                        foreach (var pokemon in currentTrainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        // премахвам всички покемони на който Health е <= 0
                        currentTrainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

                element = Console.ReadLine();
            }

            foreach (var trainer in trainers
                                       .OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
namespace _04.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }
    }
}