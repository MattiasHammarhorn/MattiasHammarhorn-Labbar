using Labb_5___My_repository.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository
{
    class Client
    {
        public void Start()
        {
            //Nya instanser av controllers
            var dvds = new DvdController();
            var manga = new MangaController();
            var loop = true;

            while (loop)
            {
                UI.PrintMainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input) //Switch för varje val
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        dvds.CreateDvd();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        manga.CreateManga();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        dvds.RemoveDvd();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        manga.RemoveManga();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        dvds.PrintDvdList();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        manga.PrintMangaList();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        dvds.EditDvd();
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        manga.EditManga();
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        loop = false;
                        break;
                }
            }
        }
    }
}
