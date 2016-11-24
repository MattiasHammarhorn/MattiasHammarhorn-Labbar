using Labb_12___LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_12___LINQ.Models.Film;

namespace Labb_12___LINQ.Managers
{
    class FilmManager
    {
        List<Film> films = new List<Film>
        {
            new Film { Title = "1", Length = 120, Genre = (GenreType)1 },
            new Film { Title = "1.1", Length = 119, Genre = (GenreType)1 },
            new Film { Title = "2", Length = 119, Genre = (GenreType)2 },
            new Film { Title = "2.1", Length = 120, Genre = (GenreType)2 },
            new Film { Title = "3", Length = 120, Genre = (GenreType)3 },
            new Film { Title = "4", Length = 119, Genre = (GenreType)4 },
            new Film { Title = "A1", Length = 121, Genre = (GenreType)4 },
            new Film { Title = "A1", Length = 121, Genre = (GenreType)2 },
            new Film { Title = "A2", Length = 120, Genre = (GenreType)5 }
        };

        #region Filtering methods
        public void FilterByTitle()
        {
            Console.Clear();

            Console.WriteLine("Enter the name of an existing film:");
            var input = Console.ReadLine();

            Film[] subset = films   // Letar efter all filmer med en Title som passar användarens input
                .Where(films => films.Title == input)
                .ToArray();

            foreach (var film in subset)
            {
                Console.WriteLine(film.Information());
            }

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey(true);
        }

        public void FilterByGenre()
        {
            foreach (var genre in Enum.GetValues(typeof(Film.GenreType)))
            {
                Console.WriteLine("\n{0}. {1}", (int)genre, genre);
            }
            Console.WriteLine("Choose film genre: ");

            int input = int.Parse(Console.ReadLine());

            Film[] subset = films
                .Where(films => films.Genre == (Film.GenreType)input)
                .ToArray();

            for (int i = 1; i <= subset.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, subset[i - 1].Information());
            }

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey(true);
        }

        public void FilterByLength()
        {
            Console.Clear();
            Film[] subsets = films // Letar efter filmer med en Length under 120
                .Where(films => films.Length < 120)
                .ToArray();

            Console.WriteLine("These films are shorter than 120 minutes:");
            foreach (var film in subsets)
            {
                Console.WriteLine(film.Information());
            }

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey(true);
        }

        public void FilterByALengthGenre()
        {
            Console.Clear();
            Console.WriteLine("These films' titles start with an 'A', their genre is action and they run for less than 120 minutes.");

            Film[] subsets = films // Letar efter filmer vars titel böjar på 'A', genre är aktion och är över 120 minuter långa
                .Where(films => films.Title[0] == 'A' && films.Length > 120 && films.Genre == GenreType.Action)
                .ToArray();

            foreach (var film in subsets)
            {
                Console.WriteLine(film.Information());
            }

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey(true);
        }
        #endregion

        #region Sorting methods
        public void SortIntoStringArray()
        {
            Console.Clear();

            string[] subset = films // Väljer alla filmers Title och lägger in den i en string array
                .Select(films => films.Title)
                .ToArray();

            for (int i = 0; i < subset.Length; i++) // Skriver ut varje string i arrayen vi precis la alla film Title-properties i
            {
                Console.WriteLine(subset[i]);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        public void SaveIntoStringVariable() // Sparar till en string variabel (tror jag)
        {
            Console.Clear();
            Console.WriteLine("Enter the specific title of a film: ");
            string input = Console.ReadLine().ToLower();

            string filmTitle = films
                .Where(film => film.Title.ToLower().Equals(input))
                .Select(film => film.Title)
                .FirstOrDefault();
            
            Console.WriteLine(filmTitle);

            if (filmTitle == null)
            {
                Console.WriteLine("Lol no");
            }

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey(true);
        }
        #endregion

        #region Menu-switches
        public void FilterOptions()
        {
            bool loop = true;
            Menus.FilterMenu();

            while (loop)
            {
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        FilterByTitle();
                        loop = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        FilterByGenre();
                        loop = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        FilterByLength();
                        loop = false;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        FilterByALengthGenre();
                        loop = false;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        loop = false;
                        break;
                }
            }
        }

        public void SortingOptions()
        {
            bool loop = true;
            Menus.SortingMenu();

            while (loop)
            {
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        SortIntoStringArray();
                        loop = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        SaveIntoStringVariable();
                        loop = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        loop = false;
                        break;
                }
            }
        }
        #endregion
    }
}
