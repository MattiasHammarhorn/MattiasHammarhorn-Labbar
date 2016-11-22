using Labb_10___Delegater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_10___Delegater.Models.Book;

namespace Labb_10___Delegater.Managers
{
    class BookManager
    {
        public delegate bool BookFilter(Book book);

        List<Book> books = new List<Book>
        {
            new Book { Title = "The Tell-Tale Heart", Pages = 64, Genre = (GenreType)1, Price = 299 },
            new Book { Title = "Jane Eyre", Pages = 387, Genre = (GenreType)3, Price = 199 },
            new Book { Title = "The Fellowship of the Ring", Pages = 511, Genre = (GenreType)2, Price = 149 },
            new Book { Title = "A Small Place", Pages = 79, Genre = (GenreType)1, Price = 159 },
            new Book { Title = "Ronia the Robber's Daughter", Pages = 248, Genre = (GenreType)2, Price = 150 },
            new Book { Title = "Head First C#", Pages = 960, Genre = (GenreType)3, Price = 329 }
        };

        public void PrintWhere(BookFilter filter)
        {
            foreach(var book in books)
            {
                if (filter(book))
                {
                    Console.WriteLine("This book's title is: {0}", book.Title);
                    Console.WriteLine("This book's genre is: {0}", book.Genre);
                    Console.WriteLine("This book is {0} pages long", book.Pages);
                }
            }
        }

        #region bools to be looped
        public bool IsNovel(Book book)
        {
            if (book.Pages >= 100)
                return true;
            else
                return false;
        }

        public bool IsShortStory(Book book)
        {
            if (book.Pages < 100)
                return true;
            else
                return false;
        }

        public bool IsMystery(Book book)
        {
            if (book.Genre == (GenreType)1)
                return true;
            else
                return false;
        }

        public bool IsFantasy(Book book)
        {
            if (book.Genre == (GenreType)2)
                return true;
            else
                return false;
        }
            
        public bool IsRomance(Book book)
        {
            if (book.Genre == (GenreType)3)
                return true;
            else
                return false;
        }

        public bool IsCheap(Book book)
        {
            if (book.Price >= 150)
                return true;
            else
                return false;
        }

        public bool IsExpensive(Book book)
        {
            if (book.Price > 150)
                return true;
            else
                return false;
        }
        #endregion
    }
}
