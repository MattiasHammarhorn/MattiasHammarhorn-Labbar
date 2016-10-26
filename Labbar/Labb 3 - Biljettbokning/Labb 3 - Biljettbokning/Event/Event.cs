using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_3___Biljettbokning
{
    public abstract class Event
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }

        public virtual string Information()
        {
            return String.Format("");
        }
    }
}