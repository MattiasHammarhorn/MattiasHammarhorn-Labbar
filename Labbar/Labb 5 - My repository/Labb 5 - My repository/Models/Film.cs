﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository.Models
{
    class Film
    {
        public enum GenreType { Action = 1, Romance, Horror }
        public string Name { get; set; }
        public GenreType Genre { get; set; }
    }
}
