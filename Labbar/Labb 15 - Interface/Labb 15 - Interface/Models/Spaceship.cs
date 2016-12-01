using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class Spaceship : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("You try to start the spaceship but forgot to undue the fuel cable, causing the entire place to burst into flames.");
        }

        public void Stop()
        {
            Console.WriteLine("You try the stopping button but accidenty warp into light speed and collide with a neutron star.");
        }

        public void Lock()
        {
            Console.WriteLine("You accidently mistake the 'lock' button for the 'self-destruct' button and blow up together with the ship.");
        }

        public void Unlock()
        {
            Console.WriteLine("You try to unlock the spaceship but are attacked by the Andromeda Federation. Who could have expected this attack...");
        }
    }
}
