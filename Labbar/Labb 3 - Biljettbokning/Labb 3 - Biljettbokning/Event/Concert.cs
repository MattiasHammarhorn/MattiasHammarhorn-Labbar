using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_3___Biljettbokning
{
    public class Concert : Event
    {
        public string ArtistName { get; set; }
        public string MusicGenre { get; set; }

        public override string Information()
        {
            return String.Format("{0}: {1}\t{2}\t{3}\t{4}", Name, ArtistName, Date, Location, MusicGenre);
        }
    }
}