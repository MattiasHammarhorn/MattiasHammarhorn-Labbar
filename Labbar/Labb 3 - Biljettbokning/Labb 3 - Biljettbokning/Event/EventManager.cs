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
                new Concert { Name = "Slayer Live Evil", ArtistName = "Slayer",
                    Date = "12/09", Location = "Fryshuset", MusicGenre = "heavy metal", bookingIndex = 1 },
                new Concert { Name = "Deep Purple Live at Gröna Lund", ArtistName = "Deep Purple",
                    Date = "5/9", Location = "Gröna Lund", MusicGenre = "hard rock", bookingIndex = 2 },
                new Concert { Name = "MomoClo LIVE at Ericsson", ArtistName = "Momoiro Clover Z",
                    Date = "12/21", Location = "Ericsson Globe", MusicGenre = "j-pop", bookingIndex = 3 },
                new Concert { Name = "L'Arc-en-Ciel LIVE", ArtistName = "L'Arc-en-Ciel",
                    Date = "11/09", Location = "Satsuma Stadium", MusicGenre = "alternative rock", bookingIndex = 4 }
            };

            filmList = new List<Film>()
            {
                new Film { Name = "The Line between Good and Bad", Date = "30/01", FilmGenre = "Psychological, War",
                    Length = "89 min", Location = "Sergels Bio", bookingIndex = 1},
                new Film { Name = "Nazi Supermutant Zombies vs Comrading Comrads", Date = "28/02", FilmGenre = "Generic Slasher, horror",
                    Length = "120 min", Location = "Heron City", bookingIndex = 2},
                new Film { Name = "Saving Ryan's Privates", Date = "30/05", FilmGenre = "Comedy, Satire, War",
                    Length = "69 min", Location = "Filmstaden Söder", bookingIndex = 3},
            };

            festivalList = new List<Festival>()
            {
                new Festival {Name = "Sweden Rock", FestivalType = "hard rock festival",
                    Date = "8/07", Location = "Somewhere too damn far down Sweden", bookingIndex = 1},
                new Festival {Name = "Stockholm Kulturfestival", FestivalType = "culture festival",
                    Date = "25/08", Location = "Gärdet", bookingIndex = 2},
                new Festival {Name = "Sokoku Festivalen", FestivalType = "culture festival",
                    Date = "21/12", Location = "Stockholm City", bookingIndex = 3},
            };
        }

        //displays a list of concerts
        public void DisplayConcerts()
        {
            foreach (var concert in concertList)
            {
                Console.WriteLine("{0}", concert.Information());
            }
        }

        //displays a list of films
        public void DisplayFilms()
        {
            foreach (var film in filmList)
            {
                Console.WriteLine(film.Information());

            }
        }

        //displays a list of festivals
        public void DisplayFestivals()
        {
            foreach (var festival in festivalList)
            {
                Console.WriteLine(festival.Information());

            }
        }
    }
}
