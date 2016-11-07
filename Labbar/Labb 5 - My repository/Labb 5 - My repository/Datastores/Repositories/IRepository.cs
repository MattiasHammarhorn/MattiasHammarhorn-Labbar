using Labb_5___My_repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository.Datastores.Repositories
{
    interface IRepository
    {
        Dvd[] GetDvds();
        void AddDvd(Dvd newDvd);
        void RemoveDvd(Dvd Dvd);

        Manga[] GetManga();
        void AddManga(Manga newManga);
        void RemoveManga(Manga Manga);
    }
}
