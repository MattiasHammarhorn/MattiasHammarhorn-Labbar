using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("You start riding the bicycle but fall off a cliff.");
        }

        public void Stop()
        {
            Console.WriteLine("You try the breaks on the bicycle but they fall off, causing you to stumble and fall on your head.");
        }

        public void Lock()
        {
            Console.WriteLine("You try to lock the bicycle but you get a heart attack and die.");
        }

        public void Unlock()
        {
            Console.WriteLine("You unlock the bicycle but it rolls down a steep hill, your clothes get stuck in the bicycle and you fall dwon the hill.");
        }
    }
}
