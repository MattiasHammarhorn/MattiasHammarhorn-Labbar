using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12___LINQ
{
    class Menus
    {
        public static void MainMenu()
        {
            Console.WriteLine("1. Filter options");
            Console.WriteLine("2. Sorting options");
            Console.WriteLine("3. Exit");
        }

        public static void FilterMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Filter by title");
            Console.WriteLine("2. Filter by genre");
            Console.WriteLine("3. Filter by length of under 120 minutes");
            Console.WriteLine("4. Filter by action films starting with 'A' and are under 120 minutes of length");
            Console.WriteLine("5. Go back");
        }

        public static void SortingMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Sort all films into a string array");
            Console.WriteLine("2. Save a specific film's title in a string variable");
            Console.WriteLine("3. Go Back");
        }
    }
}
