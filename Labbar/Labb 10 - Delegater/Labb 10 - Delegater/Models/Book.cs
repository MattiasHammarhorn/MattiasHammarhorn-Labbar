using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_10___Delegater.Models
{
    class Book
    {
        public enum GenreType
        {
            Mystery = 1,
            Fantasy,
            Romance
        }

        public string Title { get; set; }
        public int Pages { get; set; }
        public GenreType Genre { get; set; }
        public double Price { get; set; }
    }
}
