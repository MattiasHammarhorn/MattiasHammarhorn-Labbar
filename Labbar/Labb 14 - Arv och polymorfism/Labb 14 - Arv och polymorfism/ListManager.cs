using Labb_14___Arv_och_polymorfism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Arv_och_polymorfism
{
    class ListManager
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<Magazine> Magazines { get; set; }
        public List<Paper> Papers { get; set; }

        public ListManager() // Konstruktor där alla listor fylls med objekt
        {
            Authors = new List<Author>
            {
                new Author { Name = "Author 1", Age = 1 },
                new Author { Name = "Author 2", Age = 2 }
            };

            Books = new List<Book>
            {
                new Book { Title = "Book 1", Author = Authors
                .SingleOrDefault(Author => Author.Name.Equals("Author 1")), Genre = Book.GenreType.First, Pages = 1,
                 ReleaseDate = new DateTime(2015, 1, 1 )},
                new Book { Title = "Book 2", Author = Authors.
                SingleOrDefault(Author => Author.Name.Equals("Author 2")), Genre = Book.GenreType.Second, Pages = 2,
                ReleaseDate = new DateTime(2015, 1, 2 ) }
            };

            Magazines = new List<Magazine>
            {
                new Magazine { Title = "Magazine 1", Author = Authors
                .SingleOrDefault(Author => Author.Name.Equals("Author 1")), Volume = 16,
                ReleaseDate = new DateTime(2015, 1, 3) },
                new Magazine { Title = "Magazine 2", Author = Authors
                .SingleOrDefault(Author => Author.Name.Equals("Author 1")), Volume = 15,
                ReleaseDate = new DateTime(2015, 1, 4) }
            };  // Appearently the date here is written; year, month, day but I meant: day, month and year

        Papers = new List<Paper>
            {
                new Paper { Title = "Paper 1", Author = Authors
                .SingleOrDefault(Author => Author.Name.Equals("Author 1")), University= "Cambridge University",
                ReleaseDate = new DateTime(2015, 1, 5) },
                new Paper { Title = "Paper 2", Author = Authors
                .SingleOrDefault(Author => Author.Name.Equals("Author 2")), University = "Oxford University",
                ReleaseDate = new DateTime(2015, 1, 6) }
            };  // Appearently the date here is written; year, month, day but I meant: day, month and year
    }

        public void FilterByAuthor()
        {
            Console.Clear();
            Console.WriteLine("Enter name of author: ");

            var input = Console.ReadLine();
            List<Publication>AuthorPublications = new List<Publication>();  
            // Lägger in alla objekt med Publication in i en list
            AuthorPublications.AddRange(Books);
            AuthorPublications.AddRange(Magazines);
            AuthorPublications.AddRange(Papers);

            Publication[] publicationsToPrint = AuthorPublications // Letar efter authorns namn i varje publication
                .Where(authorPublications => authorPublications.Author.Name.Contains(input))
                .ToArray();

            foreach (var publication in publicationsToPrint)
            {
                Console.WriteLine(publication.PrintInfo());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
