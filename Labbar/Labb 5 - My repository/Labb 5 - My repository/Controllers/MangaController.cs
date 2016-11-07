using Labb_5___My_repository.Datastores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository.Controllers
{
    class MangaController
    {
        private IRepository repository = new ListRepository();

        public void CreateManga()
        {
            var newManga = UI.CreateManga();
            repository.AddManga(newManga);
        }

        public void RemoveManga()
        {
            var manga = repository.GetManga();
            var index = UI.SelectManga(manga) - 1;
            repository.RemoveManga(manga[index]);
        }

        public void EditManga()
        {
            var manga = repository.GetManga();
            UI.PrintMangaList(manga);
            int index = UI.SelectManga(manga) - 1;

            UI.EditManga(manga[index]);
        }

        public void PrintMangaList()
        {
            Console.Clear();
            UI.PrintMangaList(repository.GetManga());
            Console.ReadKey(true);
        }
    }
}
