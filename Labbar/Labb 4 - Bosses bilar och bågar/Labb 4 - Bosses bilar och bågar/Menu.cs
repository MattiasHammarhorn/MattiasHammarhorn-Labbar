using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Bosses_bilar_och_bågar
{
    class Menu
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("1. Display vehicles");
            Console.WriteLine("2. Add new vehicle");
            Console.WriteLine("3. Remove vehicle");
            Console.WriteLine("4. Browse vehicles");
            Console.WriteLine("5. Exit");
        }

        public static void DisplayVehicles()
        {
            Console.WriteLine("1. Show all vehicles");
            Console.WriteLine("2. Show all cars");
            Console.WriteLine("3. Show all motorbikes");;
            Console.WriteLine("4. Filter vehicles by manufacturers");
            Console.WriteLine("5. Exit");
        }
    }
}
