using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure
{
    class Menus
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\t 1. Play Game");
            Console.WriteLine("\t 2. Exit Game");
            Console.WriteLine("---------------------------------");
        }

        public static void ActionMenu()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\t 1. Observe");
            Console.WriteLine("\t 2. Interact");
            Console.WriteLine("\t 3. Exit area");
            Console.WriteLine("---------------------------------");
        }

        public static void AreaMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\t 1. Mss.Fairfax's living room");
            Console.WriteLine("\t 2. Mss.Fairfax's garden");
            Console.WriteLine("\t 3. Townsquare");
            Console.WriteLine("\t 4. Exit game");
            Console.WriteLine("---------------------------------");
        }
    }
}
