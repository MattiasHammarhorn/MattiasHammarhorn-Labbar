using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Store_app
{
    class Menus
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Browse wares");
            Console.WriteLine("2. Remove Wares");
            Console.WriteLine("3. Add Wares");
            Console.WriteLine("4. Exit");
        }

        public static void DisplayCategories()
        {
            Console.Clear();
            Console.WriteLine("1. Browse electronics");
            Console.WriteLine("2. Browse food");
            Console.WriteLine("3. Browse toys");
            Console.WriteLine("4. Exit");
        }

        public static void ProductsToRemove()
        {
            Console.Clear();
            Console.WriteLine("1. Remove electronic product");
            Console.WriteLine("2. Remove food product");
            Console.WriteLine("3. Remove toy product");
            Console.WriteLine("4. Exit");
        }

        public static void ProductsToAdd()
        {
            Console.Clear();
            Console.WriteLine("1. Add new electronic product");
            Console.WriteLine("2. Add new food product");
            Console.WriteLine("3. Add new toy product");
            Console.WriteLine("4. Exit");
        }
    }
}
