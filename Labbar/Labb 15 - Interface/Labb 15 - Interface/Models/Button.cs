using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class Button : IPushable
    {
        public void Push()
        {
            Console.WriteLine("You push the button but it turns out it was liked to a nuclear arsenal. Prepare for nuclear annihilation...");
        }
    }
}
