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

        //overrides informaton with the events unique properties
        public override string Information()
        {
            return String.Format("{0}. {1}:\n Artist: {2}\tDate: {3}\tLocation: {4}\tMusicgenre: {5}", bookingIndex ,Name, ArtistName, Date, Location, MusicGenre);
        }
    }
}