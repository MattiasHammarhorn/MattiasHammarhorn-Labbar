using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Arv_och_polymorfism.Models
{
    class Book : Publication
    {
        public enum GenreType { First, Second, Third }
        public GenreType Genre { get; set; }
        public int Pages { get; set; }

        public override string PrintInfo()
        {
            return String.Format("{0}\tGenre: {1}\tPages: {2}", base.PrintInfo(), Genre, Pages);
        }
    }
}
