using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_3___Biljettbokning
{
    public class Festival : Event
    {
        public string FestivalType { get; set; }

        //overrides informaton with the events unique properties
        public override string Information()
        {
            return String.Format("{0}: {1}\t{2}\t{3}", Name, FestivalType, Date, Location);
        }
    }
}