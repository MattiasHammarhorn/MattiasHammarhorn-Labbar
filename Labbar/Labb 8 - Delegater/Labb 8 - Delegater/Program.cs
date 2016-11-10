using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kör ny instans utav runtime
            var runtime = new Runtime();
            runtime.Start();

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
