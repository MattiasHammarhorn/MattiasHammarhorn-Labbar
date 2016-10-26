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
            Ticket ticket = new Ticket();

            bool isProgramRunning = true;

            while (isProgramRunning)
            {
                Menus.DisplayMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Menus.DisplayEvent();
                        bool isEventsRunning = true;

                        while (isEventsRunning)
                        {
                            int inputEvent = int.Parse(Console.ReadLine());

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

                                    isBookingRunning = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Choose film: ");
                                    eventManager.DisplayFilms();
                                    isBookingRunning = false;
                                    break;
                                case 3:
                                    Console.WriteLine("Choose festival: ");
                                    eventManager.DisplayFestivals();
                                    isBookingRunning = false;
                                    break;
                                case 4:
                                    isBookingRunning = false;
                                    break;
                            }
                        }

                        break;
                    case 3:

                        break;
                    case 4:
                        isProgramRunning = false;
                        break;
                }
            }
        }
    }
}
