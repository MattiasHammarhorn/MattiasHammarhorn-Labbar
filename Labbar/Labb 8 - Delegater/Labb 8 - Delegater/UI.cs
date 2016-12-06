using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("1. Print all strings in the string array as a single, comma-separated string");
            Console.WriteLine("2. Add all floats in the float array into a single float");
            Console.WriteLine("3. Multiply all floats in the float array into a single float");
            Console.WriteLine("4. Print all names in the product lists as a single string");
            Console.WriteLine("5. Print the sum of all prices with their respective mathematical operations");
            Console.WriteLine("6. Exit");
        }
    }
}
