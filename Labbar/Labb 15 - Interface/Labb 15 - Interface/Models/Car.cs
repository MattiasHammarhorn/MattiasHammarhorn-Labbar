using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("You try to start the car it is rigged with a bomb and explodes on you.");
        }

        public void Stop()
        {
            Console.WriteLine("You put your feet on the break-pedal to test it but it was boboytrapped, causing your legs to blow off.");
        }

        public void Lock()
        {
            Console.WriteLine("You try to lock the car but it says 'no' and runs you over.");
        }

        public void Unlock()
        {
            Console.WriteLine("You unlock the car but it is on a steep hill and runs you over.");
        }
    }
}
