using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository.Models
{
    class Dvd
    {
        public enum GenreType
        {
            Action = 1,
            Comedy,
            Drama,
            Fantasy,
            Horror,
            Romance
        }

        public string DvdName { get; set; }
        public GenreType DvdGenre { get; set; }
    }
}
