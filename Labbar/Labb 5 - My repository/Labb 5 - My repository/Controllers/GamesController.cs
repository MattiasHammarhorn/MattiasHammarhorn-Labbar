using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_5___My_repository.DataStores.Repositories;

namespace Labb_5___My_repository.Controller
{
    class GamesController
    {
        private IRepository gamesRepository = new ListRepository();

        public void CreateGame()
        {
            var newGame = UI.CreateGame();
            gamesRepository.AddGame(newGame);
        }

        public void RemoveGame()
        {
            var games = gamesRepository.GetGames();
            var index = UI.SelectGame(games) - 1;
            gamesRepository.RemoveGame(games[index]);
        }

        public void EditGame()
        {
            var games = gamesRepository.GetGames();
            UI.PrintGameList(games);
            int index = UI.SelectGame(games) - 1;

            UI.EditGame(games[index]);
        }

        public void PrintGameList()
        {
            Console.Clear();
            UI.PrintGameList(gamesRepository.GetGames());
            Console.ReadKey(true);
        }
    }
}
