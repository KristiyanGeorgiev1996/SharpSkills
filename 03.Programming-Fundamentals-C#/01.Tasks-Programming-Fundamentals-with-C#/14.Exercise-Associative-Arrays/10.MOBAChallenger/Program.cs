using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace MOBAChallenger_withClass
{
    public class Program
    {
        private static void Main()
        {
            var dictNamePlayer = new Dictionary<string, Player>();
            string command;
            while ((command = Console.ReadLine()) != "Season end")
            {
                if (!command.Contains("vs"))
                {
                    var commandArray = command.Split(" -> ");
                    var playerName = commandArray[0];
                    var position = commandArray[1];
                    var skill = int.Parse(commandArray[2]);

                    if (!dictNamePlayer.ContainsKey(playerName))
                    {
                        var newPlayer = new Player(playerName);
                        dictNamePlayer.Add(playerName, newPlayer);
                    }

                    dictNamePlayer[playerName].AddOrUpdatePosition(position, skill);
                }
                else
                {
                    var commandArray = command.Split(' ');
                    var firstPlayer = commandArray[0];
                    var secondPlayer = commandArray[2];

                    if (!dictNamePlayer.ContainsKey(firstPlayer) || !dictNamePlayer.ContainsKey(secondPlayer))
                    {
                        continue;
                    }

                    var playerOne = dictNamePlayer[firstPlayer];
                    var playerTwo = dictNamePlayer[secondPlayer];

                    if (playerOne.GetTotalSkillPoints() == playerTwo.GetTotalSkillPoints())
                    {
                        continue;
                    }

                    var duelsCount = playerOne.GetPositions()
                        .Intersect(playerTwo.GetPositions())
                        .Count();

                    if (duelsCount <= 0)
                    {
                        continue;
                    }

                    dictNamePlayer.Remove(playerOne.GetTotalSkillPoints() > playerTwo.GetTotalSkillPoints()
                        ? playerTwo.Name
                        : playerOne.Name);
                }
            }

            PrintResult(dictNamePlayer.Values.ToList());
        }

        private static void PrintResult(IEnumerable<Player> players)
        {
            foreach (var player in players
                .OrderByDescending(player => player.GetTotalSkillPoints())
                .ThenBy(player => player.Name))
            {
                Console.WriteLine($"{player.Name}: {player.GetTotalSkillPoints()} skill");

                foreach (var (position, skill) in player
                    .GetPositionsAndSkillsDictionary()
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position} <::> {skill}");
                }
            }
        }

        private class Player
        {
            public string Name { get; }

            private readonly Dictionary<string, int> _dictPositionSkill;

            public Player(string name)
            {
                Name = name;
                _dictPositionSkill = new Dictionary<string, int>();
            }

            public void AddOrUpdatePosition(string position, int skill)
            {
                if (!_dictPositionSkill.ContainsKey(position))
                {
                    _dictPositionSkill.Add(position, skill);
                }
                else if (_dictPositionSkill[position] < skill)
                {
                    _dictPositionSkill[position] = skill;
                }
            }

            public IEnumerable<string> GetPositions()
            {
                return _dictPositionSkill.Keys;
            }

            public ImmutableDictionary<string, int> GetPositionsAndSkillsDictionary()
            {
                return _dictPositionSkill.ToImmutableDictionary();
            }

            public int GetTotalSkillPoints()
            {
                return _dictPositionSkill.Values.Sum();
            }
        }
    }
}