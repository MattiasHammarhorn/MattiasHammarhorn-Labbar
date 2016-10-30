using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure.Interfaces
{
    //Ger interfacet properties och metoder
    interface INonPlayerCharacter
    {
        string Name { get; set; }
        string Response { get; set; }
        string Appearance { get; set; }
        string Speak();
        string Observe();
    }
}
