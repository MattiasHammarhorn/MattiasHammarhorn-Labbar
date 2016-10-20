using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_2___Arv_och_Polymorfism
{
    public class Penguin : Bird
    {
        public string DoesNest { get; set; }

        public override string Introduction()
        {
            return String.Format("{0} The {1} {2} its hatchlings.", base.Introduction(), Name, DoesNest);
        }
    }
}