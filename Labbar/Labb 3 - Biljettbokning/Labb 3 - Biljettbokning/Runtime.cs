using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Biljettbokning
{
    class Runtime
    {
        public void Start()
        {
            EventManager eventManager = new EventManager();
            TicketManager ticketManager = new TicketManager();

            bool isProgramRunning = true;

            //while-loop used to keep the program from closing down
            while (isProgramRunning)
            {
                Menus.DisplayMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                //switch that waits for input
                switch (input)
                {
                    //brings you to the events graphics
                    case 1:
                        Menus.DisplayEvent();

                        //separate bool to keep a new while-loop going
                        bool isEventsRunning = true;

                        while (isEventsRunning)
                        {
                            int inputEvent = int.Parse(Console.ReadLine());

                            //1-3 cases calls on each event and then returns back to the first while-loop (the "main menu")
                            switch (inputEvent)
                            {
                                case 1:
                                    eventManager.DisplayConcerts();
                                    isEventsRunning = false;
                                    break;
                                case 2:
                                    eventManager.DisplayFilms();
                                    isEventsRunning = false;
                                    break;
                                case 3:
                                    eventManager.DisplayFestivals();
                                    isEventsRunning = false;
                                    break;
                                case 4:
                                    isEventsRunning = false;
                                    break;
                            }
                        }
                        break;

                    //second case in the first loop does the same as first
                    case 2:
                        Menus.DisplayBooking();
                        bool isBookingRunning = true;

                        while (isBookingRunning)
                        {
                            int inputBooking = int.Parse(Console.ReadLine());

                            switch (inputBooking)
                            {
                                case 1:

                                    Console.WriteLine("Choose concert: ");
                                    eventManager.DisplayConcerts();

                                    int bookingChoice1 = int.Parse(Console.ReadLine());

                                    //if the input is the same as the index of an item inside he list,
                                    //then a concert will be returned into the variable 'concertToBook'
                                    var concertToBook = eventManager.concertList.SingleOrDefault(concert => concert.bookingIndex == bookingChoice1);

                                    //aslong as concertToBook has an existing concert inside it, then it will go to a method
                                    //otherwise it crashes
                                    if (concertToBook != null)
                                    {
                                        ticketManager.AddConcertTicket();
                                    }

                                    isBookingRunning = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Choose film: ");
                                    eventManager.DisplayFilms();
                                    string test = Console.ReadLine();
                                    int bookingChoice2 = int.Parse(test);

                                    //var eventToBook = eventManager.concertList[bookingChoice];
                                    var filmToBook = eventManager.filmList.SingleOrDefault(film => film.bookingIndex == bookingChoice2);
                                    if (filmToBook != null)
                                    {
                                        ticketManager.AddFilmTicket();
                                    }

                                    isBookingRunning = false;
                                    break;
                                case 3:
                                    Console.WriteLine("Choose festival: ");
                                    eventManager.DisplayFestivals();

                                    int bookingChoice3 = int.Parse(Console.ReadLine());

                                    var festivalToBook = eventManager.festivalList.SingleOrDefault(festival => festival.bookingIndex == bookingChoice3);
                                    if (festivalToBook != null)
                                    {
                                        ticketManager.AddFestivalTicket();
                                    }

                                    isBookingRunning = false;
                                    break;
                                case 4:
                                    isBookingRunning = false;
                                    break;
                            }
                        }

                        break;
                    case 3:
                        ticketManager.DisplayAllTickets();
                        break;
                    case 4:
                        isProgramRunning = false;
                        break;
                }
            }
        }
    }
}
