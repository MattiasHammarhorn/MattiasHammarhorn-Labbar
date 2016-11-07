using Labb_5___My_repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository.Datastores
{
    class MyLists
    {
        private static List<Dvd> dvds;
        private static List<Manga> manga;

        public static List<Dvd> Dvds
        {
            get
            {
                if (dvds == null)
                    dvds = new List<Dvd>();

                return dvds;
            }
        }

        public static List<Manga> Manga
        {
            get
            {
                if (manga == null)
                    manga = new List<Manga>();

                return manga;
            }
        }
    }
}
