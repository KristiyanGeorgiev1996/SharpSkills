namespace _03.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] creatorAndTeam = Console.ReadLine().Split('-');
                string creator = creatorAndTeam[0];
                string teamName = creatorAndTeam[1];

                // проверяваме дали има друг отбор с това име
                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");

                }// проверяваме този user дали е създател на друг отбор
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");

                }// в краен случай, създаваме отбора и го добавяме в колекцията
                else
                {
                    Team currentTeam = new Team(teamName, creator);
                    teams.Add(currentTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] userAndTeam = input.Split("->");
                string user = userAndTeam[0];
                string teamName = userAndTeam[1];

                // проверяваме дали има отбор с това име в списъка (с отрицание)
                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");

                }// проверяваме дали този user участва в други отбори
                else if (teams.Any(t => t.Members.Contains(user)) ||
                         teams.Any(t => t.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    // варя отборо от списъка по име
                    Team team = teams.First(t => t.Name == teamName);
                    // добавям отбора в списъка
                    team.Members.Add(user);
                }

                input = Console.ReadLine();
            }

            // сортирам отборите още докато ги избирам
            List<Team> temsWithMembers = teams.Where(t => t.Members.Count > 0)
                                              .OrderByDescending(t => t.Members.Count)
                                              .ThenBy(t => t.Name)
                                              .ToList();

            // сортирам отборите още докато ги избирам
            List<Team> disbandTeams = teams.Where(t => t.Members.Count == 0)
                                           .OrderBy(t => t.Name)
                                           .ToList();

            foreach (var team in temsWithMembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

}
namespace _03.TeamworkProjects
{
    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        //This is the team name
        public string Name { get; set; }

        // This property is creator of a team
        public string Creator { get; set; }

        //This property colects members of a team
        public List<string> Members { get; set; }
    }
}