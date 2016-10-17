using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_2___Arv_och_Polymorfism
{
    public class Dog : Mammal
    {
        public string DoesHunt { get; set; }

        public override string Introduction()
        {
            return String.Format("{0} A {1} has {2} number of legs and {3}.", base.Introduction(), Name, NumberOfLegs, DoesHunt);
        }
    }
}