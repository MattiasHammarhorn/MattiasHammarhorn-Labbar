using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Bosses_bilar_och_bågar
{
    class Menu
    {
        // Grafiker för varje meny
        public static void DisplayMainMenu()
        {
            Console.WriteLine("1. Display vehicles");
            Console.WriteLine("2. Add new vehicle");
            Console.WriteLine("3. Remove vehicle");
            Console.WriteLine("4. Browse vehicles");
            Console.WriteLine("5. Sell vehicles");
            Console.WriteLine("6. Exit");
        }

        public static void DisplayVehicles()
        {
            Console.WriteLine("1. Show all cars");
            Console.WriteLine("2. Show all motorbikes");;
            Console.WriteLine("3. Filter vehicles by manufacturer");
            Console.WriteLine("4. Go back");
        }

        public static void FilterVehicles()
        {
            Console.WriteLine("1. Filter car manufacturers");
            Console.WriteLine("2. Filter motorbike manufacturers");
            Console.WriteLine("3. Go back");
        }

        public static void BrowseVehicles()
        {
            Console.WriteLine("1. Browse cars");
            Console.WriteLine("2. Browse motorbikes");
            Console.WriteLine("3. Browse used cars");
            Console.WriteLine("4. Browse used motorbikes");
            Console.WriteLine("5. Go back");
        }

        public static void SellVehicles()
        {
            Console.WriteLine("1. Sell cars");
            Console.WriteLine("2. Sell motorbikes");
            Console.WriteLine("3. Sell used cars");
            Console.WriteLine("4. Sell used motorbikes");
            Console.WriteLine("5. Go back");
        }
    }
}
