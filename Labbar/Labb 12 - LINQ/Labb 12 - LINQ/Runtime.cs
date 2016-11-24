using Labb_12___LINQ.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12___LINQ
{
    class Runtime
    {
        public void Start()
        {
            var filmManager = new FilmManager();

            bool mainloop = true;

            while (mainloop)
            {
                Console.Clear();
                Menus.MainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        filmManager.FilterOptions();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        filmManager.SortingOptions();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        mainloop = false;
                        break;
                }
            }
        }
    }
}
