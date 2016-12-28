using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_5___My_repository.Models;

namespace Labb_5___My_repository.DataStores.Repositories
{
    class ListRepository : IRepository
    {
        #region Film methods
        public Film[] GetFilms()            // Public film array
        {
            return MyLists.Films.ToArray(); // Returns all films from MyLists.Films to the array
        }

        public void AddFilm(Film newFilm)   // A method inherited from IRepository
        {
            MyLists.Films.Add(newFilm);     // Adds newFilm to MyLists.Films
        }

        public void RemoveFilm(Film film)   // A method inheried from IRepository
        {
            MyLists.Films.Remove(film);     // Removes selected film from MyLists.Films
        }
        #endregion

        #region Game methods
        public Game[] GetGames()
        {
            return MyLists.Games.ToArray();
        }

        public void AddGame(Game newGame)
        {
            MyLists.Games.Add(newGame);
        }

        public void RemoveGame(Game game)
        {
            MyLists.Games.Remove(game);
        }
        #endregion
    }
}
