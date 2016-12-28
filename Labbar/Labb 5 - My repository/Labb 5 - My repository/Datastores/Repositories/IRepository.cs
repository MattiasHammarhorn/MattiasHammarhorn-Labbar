using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_5___My_repository.Models;

namespace Labb_5___My_repository.DataStores.Repositories
{
    interface IRepository
    {
        Film[] GetFilms();          // Interface will have an array of films
        void AddFilm(Film newFilm); // A method for adding films that takes in a film 'newFilm'
        void RemoveFilm(Film film); // A methodfor removing films that takes in a 'film'

        Game[] GetGames();
        void AddGame(Game newGame);
        void RemoveGame(Game game);
    }
}
