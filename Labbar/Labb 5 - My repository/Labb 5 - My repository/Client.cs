using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_5___My_repository.Controller;

namespace Labb_5___My_repository
{
    class Client
    {
        public void Start()
        {
            bool isRunning = true;

            while (isRunning)                                       // Run while the bool 'isRunning' is still true
            {
                UI.PrintMainMenu();
                ConsoleKey menuChoice = Console.ReadKey(true).Key;

                switch (menuChoice)
                {
                    case ConsoleKey.D1:
                        FilmMenu();
                        break;
                    case ConsoleKey.D2:
                        GameMenu();
                        break;
                    case ConsoleKey.D3:
                        isRunning = false;
                        break;
                }
            }
        }

        public void FilmMenu()
        {
            FilmsController films = new FilmsController();
            bool isFilmMenuRunning = true;

            while (isFilmMenuRunning)
            {
                UI.PrintFilmMenu();
                ConsoleKey filmChoice = Console.ReadKey(true).Key;

                switch (filmChoice)
                {
                    case ConsoleKey.D1:
                        films.CreateFilm();
                        break;
                    case ConsoleKey.D2:
                        films.RemoveFilm();
                        break;
                    case ConsoleKey.D3:
                        films.PrintFilmList();
                        break;
                    case ConsoleKey.D4:
                        films.EditFilm();
                        break;
                    case ConsoleKey.D5:
                        isFilmMenuRunning = false;
                        break;
                }
            }
        }

        public void GameMenu()
        {
            GamesController games = new GamesController();
            bool isGameMenuRunning = true;

            while (isGameMenuRunning)
            {
                UI.PrintGameMenu();
                ConsoleKey gameChoice = Console.ReadKey(true).Key;

                switch (gameChoice)
                {
                    case ConsoleKey.D1:
                        games.CreateGame();
                        break;
                    case ConsoleKey.D2:
                        games.RemoveGame();
                        break;
                    case ConsoleKey.D3:
                        games.PrintGameList();
                        break;
                    case ConsoleKey.D4:
                        games.EditGame();
                        break;
                    case ConsoleKey.D5:
                        isGameMenuRunning = false;
                        break;
                }
            }
        }
    }
}
