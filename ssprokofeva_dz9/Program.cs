using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssprokofeva_dz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teams = new List<Team>
            {
                new Team("Россия"),
                new Team("Франция"),
                new Team("Китай"),
                new Team("Казахстан")
            };

            foreach (var team in teams)
            {
                System.Console.WriteLine($"\n*** Команда {team.Name} ***");
                team.PlayGames(6);
            }
        }
    }
    
}
