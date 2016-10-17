using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv_och_Polymorfism
{
    class Menu
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add object");
            Console.WriteLine("2. Remove object");
            Console.WriteLine("3. Display lists of animals");
            Console.WriteLine("4. Exit");
        }

        public static void DisplayAddObject()
        {
            Console.Clear();
            Console.WriteLine("1. Add new dog");
            Console.WriteLine("2. Add new snake");
            Console.WriteLine("3. Add new penguin");
            Console.WriteLine("4. Back");
        }
        
        public static void DisplayRemoveObject()
        {
            Console.Clear();
            Console.WriteLine("1. Remove existing dog");
            Console.WriteLine("2. Remove existing snake");
            Console.WriteLine("3. Remove existing penguin");
            Console.WriteLine("4. Back");
        }

        public static void DisplayListOfAnimals()
        {
            Console.Clear();
            Console.WriteLine("1. Dislay list of dogs");
            Console.WriteLine("2. Dislay list of snakes");
            Console.WriteLine("3. Dislay list of penguins");
            Console.WriteLine("4. Back");
        }
    }
}
