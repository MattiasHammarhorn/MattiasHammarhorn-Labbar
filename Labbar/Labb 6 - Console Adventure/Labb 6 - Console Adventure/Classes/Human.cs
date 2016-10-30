using Labb_6___Console_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure.Classes
{
    class Human  :  INonPlayerCharacter
    {
        //Ger klassen properties och metoder från interfacet
        public string Name { get; set; }
        public string Response { get; set; }
        public string Appearance { get; set; }

        //Metoder som returnerar properties
        public string Speak()
        {
            return Response;
        }
        
        public string Observe()
        {
            return Appearance;
        }
    }
}
