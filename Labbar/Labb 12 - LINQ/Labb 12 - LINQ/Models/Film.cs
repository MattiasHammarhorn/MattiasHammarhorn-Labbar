using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12___LINQ.Models
{
    class Film
    {
        public enum GenreType
        {
            Romance = 1,
            Comedy,
            Horror,
            Action,
            Fantasy
        }

        public string Title { get; set; }
        public int Length { get; set; }
        public GenreType Genre { get; set; }

        public virtual string Information()
        {
            return String.Format("Title: {0}\tGenre: {1}\tLength: {2} minutes",
                                    Title,
                                    Genre,
                                    Length);
        }
    }
}
