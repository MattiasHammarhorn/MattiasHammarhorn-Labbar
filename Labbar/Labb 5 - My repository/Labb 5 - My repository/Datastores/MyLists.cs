using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_5___My_repository.Models;

namespace Labb_5___My_repository.DataStores
{
    class MyLists
    {
        private static List<Film> films;        // Private properties
        private static List<Game> games;

        public static List<Film> Films
        {
            get
            {
                if (films == null)              // If there are no games in the list
                    films = new List<Film>();   // Create a new list

                return films;                   // And return it to the private list
            }
        }

        public static List<Game> Games
        {
            get
            {
                if (games == null)
                    games = new List<Game>();

                return games;
            }
        }
    }
}
