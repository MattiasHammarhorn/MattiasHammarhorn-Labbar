using Labb_5___My_repository.Datastores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository.Controllers
{
    class DvdController
    {
        private IRepository repository = new ListRepository();

        public void CreateDvd()
        {
            var newDvd = UI.CreateDvd();
            repository.AddDvd(newDvd);
        }

        public void RemoveDvd()
        {
            var dvds = repository.GetDvds();
            var index = UI.SelectDvd(dvds) - 1;
            repository.RemoveDvd(dvds[index]);
        }

        public void EditDvd()
        {
            var dvds = repository.GetDvds();
            UI.PrintDvdList(dvds);
            int index = UI.SelectDvd(dvds) - 1;

            UI.EditDvd(dvds[index]);
        }

        public void PrintDvdList()
        {
            Console.Clear();
            UI.PrintDvdList(repository.GetDvds());
            Console.ReadKey(true);
        }
    }
}
