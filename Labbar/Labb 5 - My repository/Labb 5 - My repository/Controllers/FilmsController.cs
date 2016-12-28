using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_5___My_repository.DataStores.Repositories;

namespace Labb_5___My_repository.Controller
{
    class FilmsController
    {
        private IRepository filmRepository = new ListRepository();

        public void CreateFilm()
        {
            var newFilm = UI.CreateFilm();
            filmRepository.AddFilm(newFilm);
        }

        public void RemoveFilm()
        {
            var films = filmRepository.GetFilms();
            var index = UI.SelectFilm(films) - 1;
            filmRepository.RemoveFilm(films[index]);
        }

        public void EditFilm()
        {
            var films = filmRepository.GetFilms();
            UI.PrintFilmList(films);
            int index = UI.SelectFilm(films) - 1;

            UI.EditFilm(films[index]);
        }

        public void PrintFilmList()
        {
            Console.Clear();
            UI.PrintFilmList(filmRepository.GetFilms());
            Console.ReadKey(true);
        }
    }
}
