using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

                string bossName = options[0];
                string teamName = options[1];

                if (teams.Where(x => x.Name == teamName).ToList().Count == 1)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Where(x => x.Boss == bossName).ToList().Count == 1)
                {
                    Console.WriteLine($"{bossName} cannot create another team!");
                }
                else
                {
                    Team team = new Team();
                    team.Name = teamName;
                    team.Boss = bossName;
                    team.Members = new List<string>() { };

                    teams.Add(team);

                    Console.WriteLine($"Team {teamName} has been created by {bossName}!");
                }

            }



            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] options = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string user = options[0];
                string teamName = options[1];

                if (teams.Where(x => x.Name == teamName).ToList().Count == 0)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Where(x => x.Members.Contains(user) || x.Boss == user).ToList().Count > 0)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    teams[teams.FindIndex(x => x.Name == teamName)].Members.Add(user);
                }

            }

            foreach (var item in teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine($"- {item.Boss}");
                foreach (var member in item.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine(item.Name);
            }

        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Boss { get; set; }
        public List<string> Members { get; set; }
    }

}
