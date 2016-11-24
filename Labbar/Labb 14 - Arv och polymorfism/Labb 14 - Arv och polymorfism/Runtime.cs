using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Arv_och_polymorfism
{
    class Runtime
    {
        public void Start()
        {
            var listManager = new ListManager();
            var loop = true;

            while (loop)
            {
                Console.Clear();
                Menu.MainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        listManager.FilterByAuthor();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        loop = false;
                        break;
                }
            }
        }
    }
}
