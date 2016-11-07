using Labb_5___My_repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_repository
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add dvd");
            Console.WriteLine("2. Add manga");
            Console.WriteLine("3. Remove dvd");
            Console.WriteLine("4. Remove manga");
            Console.WriteLine("5. Show all dvds");
            Console.WriteLine("6. Show all manga");
            Console.WriteLine("7. Edit dvd");
            Console.WriteLine("8. Edit manga");
            Console.WriteLine("9. Exit");
        }

        #region Editing methods
        public static void EditDvd(Dvd dvd)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change genre");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Dvd: {0}. Genre: {1}", dvd.DvdName, dvd.DvdGenre);

            switch (choice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Write("New name: ");
                    dvd.DvdName = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Write("Genre list: ");
                    PrintDvdGenres();
                    Console.Write("Choose genre: ");
                    dvd.DvdGenre = (Dvd.GenreType)int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static void EditManga(Manga manga)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change genre");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Dvd: {0}. Genre: {1}", manga.MangaName, manga.MangaGenre);

            switch (choice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Write("New name: ");
                    manga.MangaName = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Write("Genre list: ");
                    PrintMangaGenres();
                    Console.Write("Choose genre: ");
                    manga.MangaGenre = (Manga.GenreType)int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static int SelectDvd(Dvd[] dvds) //Chooses which dvd in the array
        {
            PrintDvdList(dvds);
            Console.Write("Select dvd: ");
            return int.Parse(Console.ReadLine());
        }

        public static int SelectManga(Manga[] manga) //Chooses which manga in the array
        {
            PrintMangaList(manga);
            Console.Write("Select manga: ");
            return int.Parse(Console.ReadLine());
        }
        #endregion

        #region Adding methods
        public static Dvd CreateDvd()
        {
            Dvd newDvd = new Dvd();
            Console.Clear();
            Console.Write("Dvd name: ");
            newDvd.DvdName = Console.ReadLine();

            Console.WriteLine("Dvd genre: ");
            PrintDvdGenres();
            Console.Write("Choose a genre: ");
            int choice = int.Parse(Console.ReadLine());
            newDvd.DvdGenre = (Dvd.GenreType)choice;

            return newDvd;
        }

        public static Manga CreateManga()
        {
            Manga newManga = new Manga();
            Console.Clear();
            Console.Write("Manga name: ");
            newManga.MangaName = Console.ReadLine();

            Console.WriteLine("Manga genre: ");
            PrintMangaGenres();
            Console.Write("Choose a genre: ");
            int choice = int.Parse(Console.ReadLine());
            newManga.MangaGenre = (Manga.GenreType)choice;

            return newManga;
        }
        #endregion

        #region Printing methods
        public static void PrintDvdGenres()
        {
            foreach (var dvdGenre in Enum.GetValues(typeof(Dvd.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)dvdGenre, dvdGenre);
            }
        }

        public static void PrintMangaGenres()
        {
            foreach (var mangaGenre in Enum.GetValues(typeof(Manga.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)mangaGenre, mangaGenre);
            }
        }

        public static void PrintDvdList(Dvd[] dvds)
        {
            Console.Clear();
            foreach (var dvd in dvds)
            {
                Console.WriteLine("{0}. Dvd: {1}, Genre: {2}",
                    Array.IndexOf(dvds, dvd) + 1,
                    dvd.DvdName,
                    dvd.DvdGenre);
            }
        }

        public static void PrintMangaList(Manga[] manga)
        {
            Console.Clear();
            foreach (var singleManga in manga)
            {
                Console.WriteLine("{0}. Manga: {1}, Genre: {2}",
                    Array.IndexOf(manga, singleManga) + 1,
                    singleManga.MangaName,
                    singleManga.MangaGenre);
            }
        }
        #endregion
    }
}
