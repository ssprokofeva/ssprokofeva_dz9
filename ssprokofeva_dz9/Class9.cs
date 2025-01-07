using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssprokofeva_dz9
{
    class Team
    {
        public string Name { get; set; }
        private List<IGame> games = new List<IGame>();

        public Team(string name)
        {
            this.Name = name;

            games.Add(new Beach());
            games.Add(new Mousetrap());
            games.Add(new Sea());
            games.Add(new Fishing());
            games.Add(new Postmen());
            games.Add(new Slide());
            games.Add(new Forest());
        }

        public void PlayGames(int numberOfGames)
        {
            System.Random random = new System.Random();

            for (int i = 0; i < numberOfGames; i++)
            {
                int gameIndex = random.Next(games.Count);
                IGame selectedGame = games[gameIndex];

                System.Console.WriteLine($"Команда {Name}: Игра №{i + 1}");
                selectedGame.Play();
            }
        }
    }
}
