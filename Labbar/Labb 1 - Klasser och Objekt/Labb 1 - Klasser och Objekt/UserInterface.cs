using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Klasser_och_Objekt
{
    class UserInterface
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add dog");
            Console.WriteLine("2. Remove dog");
            Console.WriteLine("3. Display list of dogs");
            Console.WriteLine("4. Quit");
        }
    }
}
