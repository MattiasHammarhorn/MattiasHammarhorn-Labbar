using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Arv_och_polymorfism.Models
{
    class Publication
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual string PrintInfo()
        {
            return String.Format("Title: {0}\tAuthor: {1}\tReleaseDate: {2}", Title, Author.Name, ReleaseDate);
        }
    }
}
