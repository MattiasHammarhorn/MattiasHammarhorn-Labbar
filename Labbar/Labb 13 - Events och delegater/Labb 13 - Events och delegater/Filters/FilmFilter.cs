using Labb_13___Events_och_delegater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13___Events_och_delegater.Filters
{
    class FilmFilter
    {
        public static bool IsOrOver120(Film film)
        {
            return film.Length >= 120;
        }

        public static bool IsUnder120(Film film)
        {
            return film.Length < 120;
        }
    }
}
