using Labb_13___Events_och_delegater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13___Events_och_delegater
{
    class Delegates
    {
        public delegate bool FilmFilter(Film film);
        public delegate void InvalidInputMessage();
    }
}
