using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13___Events_och_delegater
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("1. Add new film");
            Console.WriteLine("2. Filter films");
            Console.WriteLine("3. Exit");
        }

        public static void PrintFilterMenu()
        {
            Console.WriteLine("1. Filter movies under 120 minutes");
            Console.WriteLine("2. Filter movies by 120 minutes or higher");
            Console.WriteLine("3. Exit");
        }
    }
}
