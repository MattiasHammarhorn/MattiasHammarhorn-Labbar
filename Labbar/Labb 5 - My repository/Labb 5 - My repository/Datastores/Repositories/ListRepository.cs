using Labb_5___My_repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository.Datastores.Repositories
{
    class ListRepository : IRepository
    {
        public Dvd[] GetDvds()
        {
            return MyLists.Dvds.ToArray();
        }

        public Manga[] GetManga()
        {
            return MyLists.Manga.ToArray();
        }

        public void AddDvd(Dvd newDvd)
        {
            MyLists.Dvds.Add(newDvd);
        }

        public void AddManga(Manga newManga)
        {
            MyLists.Manga.Add(newManga);
        }

        public void RemoveDvd(Dvd dvd)
        {
            MyLists.Dvds.Remove(dvd);
        }

        public void RemoveManga(Manga manga)
        {
            MyLists.Manga.Remove(manga);
        }
    }
}
