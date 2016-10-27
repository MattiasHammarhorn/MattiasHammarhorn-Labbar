using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Biljettbokning
{
    class Menus
    {
        //graphic for menus
        public static void DisplayMenu()
        {
            Console.WriteLine("1. See upcoming events");
            Console.WriteLine("2. Book an event");
            Console.WriteLine("3. Display bookings");
            Console.WriteLine("4. Exit");
        }

        public static void DisplayEvent()
        {
            Console.Clear();
            Console.WriteLine("1. See upcoming concerts");
            Console.WriteLine("2. See upcoming films");
            Console.WriteLine("3. See upcoming festivals");
            Console.WriteLine("4. Exit");
        }

        public static void DisplayBooking()
        {
            Console.Clear();
            Console.WriteLine("1. Book concert");
            Console.WriteLine("2. Book film");
            Console.WriteLine("3. Book festival");
            Console.WriteLine("4. Exit ");
        }
    }
}
