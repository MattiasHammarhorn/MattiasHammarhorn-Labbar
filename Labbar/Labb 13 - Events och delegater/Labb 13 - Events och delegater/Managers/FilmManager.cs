using Labb_13___Events_och_delegater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_13___Events_och_delegater.Delegates;

namespace Labb_13___Events_och_delegater.Managers
{
    class FilmManager
    {
        public event InvalidInputMessage InvalidInput;

        List<Film> Films = new List<Film>
        {
            new Film { Title = "Film 1", Genre = Film.GenreType.Action, Length = 119 },
            new Film { Title = "Film 2", Genre = Film.GenreType.Romance, Length = 120 },
            new Film { Title = "Film 3", Genre = Film.GenreType.Comedy, Length = 119 }
        };

        public void PrintAllFilms()
        {
            for (int i = 1; i <= Films.Count; i++)
            {
                Console.WriteLine("{0}\n", Films[i - 1].PrintInfo());
            }
        }

        public void AddFilm()
        {
            Console.Clear();
            Film newFilm = new Film();

            Console.Write("Enter new title: ");
            string input = Console.ReadLine();

            if (input.Length > 0 && input.Length <= 10)
                newFilm.Title = input;
            else
            {
                InvalidInput.Invoke();
                return;
            }

            Console.Write("Enter new length: ");
            int inputLength = int.Parse(Console.ReadLine());

            if (inputLength > 0 && inputLength < 858)
                newFilm.Length = inputLength;
            else
            {
                InvalidInput.Invoke();
                return;
            }

            Console.WriteLine("Enter new genre:");
            foreach (Film.GenreType genre in Enum.GetValues(typeof(Film.GenreType)))
            {
                Console.WriteLine("{0}. {1}", (int)genre, genre);
            }

            int index = int.Parse(Console.ReadLine());
            Console.Write("Choice: ");

            if (index == 1 || index == 2 || index == 3)
                newFilm.Genre = (Film.GenreType)index;
            else
            {
                InvalidInput.Invoke();
                return;
            }

            Films.Add(newFilm);
        }

        public void PrintWhere(FilmFilter filter)
        {
            Console.Clear();
            foreach (Film film in Films)
            {
                if (filter(film))
                    Console.WriteLine(film.PrintInfo());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        public void InvalidInputMethod()
        {
            Console.WriteLine("Invalid input. Aborting operation...");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
