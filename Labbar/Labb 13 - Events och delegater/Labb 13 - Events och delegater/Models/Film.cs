using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13___Events_och_delegater.Models
{
    class Film
    {
        public string Title { get; set; }
        public enum GenreType { Action = 1, Romance, Comedy }
        public GenreType Genre { get; set; }
        public int Length { get; set; }

        public string PrintInfo()
        {
            return String.Format("Title: {0,-15}Genre: {1,-15}Length: {2,-15}", Title, Genre, Length);
        }
    }
}
