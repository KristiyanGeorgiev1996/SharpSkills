int teamCount = int.Parse(Console.ReadLine());

List<Team> teams = new List<Team>();


for (int i = 0; i < teamCount; i++)
{
    string[] teamInfo = Console.ReadLine().Split("-");
    string creator = teamInfo[0];
    string teamName = teamInfo[1];

    if (teams.Any(t => t.Name == teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
    }
    else if (teams.Any(t => t.Creator == creator))
    {
        Console.WriteLine($"{creator} cannot create another team!");
    }
    else
    {
        Team newTeam = new Team { Name = teamName, Creator = creator, Members = new List<string>() };
        teams.Add(newTeam);
        Console.WriteLine($"Team {teamName} has been created by {creator}!");
    }
}

// Users join teams
while (true)
{
    string command = Console.ReadLine();
    if (command == "end of assignment")
    {
        break;
    }

    string[] joinInfo = command.Split("->");
    string user = joinInfo[0];
    string teamName = joinInfo[1];

    Team team = teams.FirstOrDefault(t => t.Name == teamName);
    if (team == null)
    {
        Console.WriteLine($"Team {teamName} does not exist!");
    }
    else if (teams.Any(t => t.Members.Contains(user) || t.Creator == user))
    {
        Console.WriteLine($"Member {user} cannot join team {teamName}!");
    }
    else
    {
        team.Members.Add(user);
    }
}

// Print teams with members
var validTeams = teams.Where(t => t.Members.Count > 0)
                      .OrderByDescending(t => t.Members.Count)
                      .ThenBy(t => t.Name);

foreach (var team in validTeams)
{
    Console.WriteLine(team.Name);
    Console.WriteLine($"- {team.Creator}");
    foreach (var member in team.Members.OrderBy(m => m))
    {
        Console.WriteLine($"-- {member}");
    }
}

var disbandedTeams = teams.Where(t => t.Members.Count == 0)
                          .OrderBy(t => t.Name);

Console.WriteLine("Teams to disband:");
foreach (var team in disbandedTeams)
{
    Console.WriteLine(team.Name);
}

class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}
