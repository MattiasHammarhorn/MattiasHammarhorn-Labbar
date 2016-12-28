using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_5___My_repository.Models;

namespace Labb_5___My_repository
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Film options");
            Console.WriteLine("2. Game options");
            Console.WriteLine("3. Exit");
        }

        #region Film Options
        public static Film CreateFilm()
        {
            Film newFilm = new Film();                          // Makes the user's input into the film's name
            Console.Clear();
            Console.Write("Enter name: ");
            newFilm.Name = Console.ReadLine();

            Console.WriteLine("Film genres: ");
            PrintFilmGenres();
            Console.WriteLine("Choice: ");
            int genreChoice = int.Parse(Console.ReadLine());
            newFilm.Genre = (Film.GenreType)genreChoice;        // The film's genre should be one that exists in Film.Genretype-enum

            return newFilm;                                     // returns newFilm into the GamesController method
        }

        public static void EditFilm(Film film)
        {
            Console.Clear();
            Console.WriteLine("1. Edit film name");
            Console.WriteLine("2. Edit film genre");
            Console.WriteLine("3. Go back");
            Console.Write("Choice");
            ConsoleKey editChoice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Film: {0}. Genre: {1}", film.Name, film.Genre);

            switch (editChoice)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Enter new name for game: ");
                    film.Name = Console.ReadLine();                     // Makes the user's input into the film's name
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("List of genres: ");
                    PrintFilmGenres();
                    Console.WriteLine("Enter new genre for game: ");
                    film.Genre = (Film.GenreType)int.Parse(Console.ReadLine()); // Parses the input and chooses the genre that matches the input
                    break;
                case ConsoleKey.D3:
                    break;
            }
        }

        public static int SelectFilm(Film[] films)  // Int to be returned that takes in the Film array 'films'
        {
            PrintFilmList(films);
            Console.Write("Select game: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintFilmGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Film.GenreType)))   // Foreach value in GenreType
            {
                Console.WriteLine("{0}. {1}", (int)genre, genre);           // Write the number of and the genre
            }
        }

        public static void PrintFilmList(Film[] films)
        {
            Console.Clear();
            foreach (Film film in films)
            {
                Console.WriteLine("{0} Game: {1,-15} Genre: {2,-15}",
                    Array.IndexOf(films, film) + 1,             // Writes out the index of the film in the array
                    film.Name,                              // Its name
                    film.Genre);                            // And its genre
            }
        }

        public static void PrintFilmMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add new film");
            Console.WriteLine("2. Remove film");
            Console.WriteLine("3. Display all films");
            Console.WriteLine("4. Edit existing films");
            Console.WriteLine("5. Go back");
        }
        #endregion

        #region Game Options
        public static Game CreateGame()
        {
            Game newGame = new Game();
            Console.Clear();
            Console.Write("Enter name: ");
            newGame.Name = Console.ReadLine();

            Console.WriteLine("Game genres: ");
            PrintGameGenres();
            Console.WriteLine("Choice: ");
            int genreChoice = int.Parse(Console.ReadLine());
            newGame.Genre = (Game.GenreType)genreChoice;

            return newGame;
        }

        public static void EditGame(Game game)
        {
            Console.Clear();
            Console.WriteLine("1. Edit game name");
            Console.WriteLine("2. Edit game genre");
            Console.WriteLine("3. Go back");
            Console.Write("Choice");
            ConsoleKey editChoice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Game: {0}. Genre: {1}", game.Name, game.Genre);

            switch (editChoice)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Enter new name for game: ");
                    game.Name = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("List of genres: ");
                    PrintGameGenres();
                    Console.WriteLine("Enter new genre for game: ");
                    game.Genre = (Game.GenreType)int.Parse(Console.ReadLine());
                    break;
                case ConsoleKey.D3:
                    break;
            }
        }

        public static int SelectGame(Game[] games)
        {
            PrintGameList(games);
            Console.Write("Select game: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintGameGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Game.GenreType)))
            {
                Console.WriteLine("{0}. {1}", (int)genre, genre);
            }
        }

        public static void PrintGameList(Game[] games)
        {
            Console.Clear();
            foreach (Game game in games)
            {
                Console.WriteLine("{0} Game: {1,-15} Genre: {2,-15}",
                    Array.IndexOf(games, game) + 1,
                    game.Name,
                    game.Genre);
            }
        }

        public static void PrintGameMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add new game");
            Console.WriteLine("2. Remove game");
            Console.WriteLine("3. Display all games");
            Console.WriteLine("4. Edit existing game");
            Console.WriteLine("5. Go back");
        }
        #endregion
    }
}