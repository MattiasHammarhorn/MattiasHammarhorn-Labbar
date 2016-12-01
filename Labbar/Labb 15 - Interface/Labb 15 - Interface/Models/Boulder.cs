using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class Boulder : IPushable
    {
        public void Push()
        {
            Console.WriteLine("You try to push the boulder but it is too big for you and it breaks your back.");
        }
    }
}
