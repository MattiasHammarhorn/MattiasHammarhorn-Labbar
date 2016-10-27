using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_3___Biljettbokning
{
    public class Film : Event
    {
        public string FilmGenre { get; set; }
        public string Length { get; set; }

        //overrides informaton with the events unique properties
        public override string Information()
        {
            return String.Format("{0}. {1}:\n Date: {2}\tLocation: {3}\tGenre: {4}\tLength: {5}", bookingIndex, Name, Date, Location, FilmGenre, Length);
        }
    }
}