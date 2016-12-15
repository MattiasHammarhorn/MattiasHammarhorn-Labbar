using Labb_13___Events_och_delegater.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_13___Events_och_delegater.Delegates;

namespace Labb_13___Events_och_delegater
{
    class Runtime
    {
        FilmManager filmManager = new FilmManager();

        public void Start()
        {
            bool isRunning = true;
            filmManager.InvalidInput += new InvalidInputMessage(filmManager.InvalidInputMethod);

            while (isRunning)
            {
                Console.Clear();
                filmManager.PrintAllFilms();
                UI.PrintMainMenu();
                ConsoleKey input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        filmManager.AddFilm();
                        break;
                    case ConsoleKey.D2:
                        FilterMenu();
                        break;
                    case ConsoleKey.D3:
                        isRunning = false;
                        break;
                }
            }
        }

        public void FilterMenu()
        {
            bool isFilter = true;

            while (isFilter)
            {
                Console.Clear();
                UI.PrintFilterMenu();
                ConsoleKey input = Console.ReadKey(true).Key;
                
                switch (input)
                {
                    case ConsoleKey.D1:
                        filmManager.PrintWhere(film => film.Length < 120);
                        break;
                    case ConsoleKey.D2:
                        filmManager.PrintWhere(film => film.Length >= 120);
                        break;
                    case ConsoleKey.D3:
                        isFilter = false;
                        break;
                }
            }
        }
    }
}
