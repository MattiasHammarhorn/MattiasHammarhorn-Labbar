using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure.Interfaces
{
    //Ger interfacet properties och metoder
    interface IEnvironment
    {
        string AreaName();
        void Observe();
        List<INonPlayerCharacter> nonPlayerCharacters { get; set; }
    }
}
