using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_3___Biljettbokning
{
    public abstract class Event
    {
        //inherited properties for each Event per se
        public string Name { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }

        //an empty string that may be inherited for the use of displaying info about each events' properties
        //it may also be overwritten so that each event can show its own property
        public virtual string Information()
        {
            return String.Format("");
        }
    }
}