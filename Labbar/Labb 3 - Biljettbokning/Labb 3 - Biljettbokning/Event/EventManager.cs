using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Biljettbokning
{
    class EventManager
    {
        //make list properties out of our events
        public List<Concert> concertList { get; set; }
        public List<Film> filmList { get; set; }
        public List<Festival> festivalList { get; set; }


        public EventManager()
        {
            //new lists of all events
            concertList = new List<Concert>()
            {
                new Concert { Name = "Concert 1", ArtistName = "Artist 1", Date = "Date 1", Location = "Place 1", MusicGenre = "Genre 1" },
                new Concert { Name = "Concert 2", ArtistName = "Artist 2", Date = "Date 2", Location = "Place 2", MusicGenre = "Genre 2" },
                new Concert { Name = "Concert 3", ArtistName = "Artist 3", Date = "Date 3", Location = "Place 3", MusicGenre = "Genre 3" },
                new Concert { Name = "Concert 4", ArtistName = "Artist 4", Date = "Date 4", Location = "Place 4", MusicGenre = "Genre 4" }
            };

            filmList = new List<Film>()
            {
                new Film { Name = "Film 1", Date = "Date 1", FilmGenre = "Genre 1", Length = "Length 1", Location = "Cinema 1"},
                new Film { Name = "Film 2", Date = "Date 2", FilmGenre = "Genre 2", Length = "Length 2", Location = "Cinema 2"},
                new Film { Name = "Film 3", Date = "Date 3", FilmGenre = "Genre 3", Length = "Length 3", Location = "Cinema 3"},
            };

            festivalList = new List<Festival>()
            {
                new Festival {Name = "Festival 1", FestivalType = "Type 1", Date = "Date 1", Location = "Location 1"},
                new Festival {Name = "Festival 2", FestivalType = "Type 2", Date = "Date 2", Location = "Location 2"},
                new Festival {Name = "Festival 3", FestivalType = "Type 3", Date = "Date 3", Location = "Location 3"},
            };
        }

        //displays a list of concerts
        public void DisplayConcerts()
        {
            foreach (var concert in concertList)
            {
                Console.WriteLine("{0}:\n{1}", concert.Name, concert.Information());
            }

            Console.ReadKey();
        }

        //displays a list of films
        public void DisplayFilms()
        {
            foreach (var film in filmList)
            {
                Console.WriteLine(film.Information());

            }

            Console.ReadKey();
        }

        //displays a list of festivals
        public void DisplayFestivals()
        {
            foreach (var festival in festivalList)
            {
                Console.WriteLine(festival.Information());

            }

            Console.ReadKey();
        }
    }
}
