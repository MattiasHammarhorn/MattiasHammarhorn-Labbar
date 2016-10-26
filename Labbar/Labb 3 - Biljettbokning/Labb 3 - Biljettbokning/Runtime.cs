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

                            //currently, the switch only has options to showcase each list of events
                            //i have no idea how to implement an index-based "menu"
                            //the PLAN is to make sure that i can use an "input" that is integer based with readline.
                            //the input is gonna correspond with the number of event
                            //the event is gonna be taken in to the "Tickets"-list.
                            switch (inputBooking)
                            {
                                case 1:

                                    Console.WriteLine("Choose concert: ");
                                    eventManager.DisplayConcerts();

                                    //the PLAN is to make sure that i can use an "input" that is integer based with readline.
                                    //the input is gonna correspond with the number of event
                                    //the event is gonna be taken in to the "Tickets"-list.
                                    isBookingRunning = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Choose film: ");
                                    eventManager.DisplayFilms();

                                    //the PLAN is to make sure that i can use an "input" that is integer based with readline.
                                    //the input is gonna correspond with the number of event
                                    //the event is gonna be taken in to the "Tickets"-list.
                                    isBookingRunning = false;
                                    break;
                                case 3:
                                    Console.WriteLine("Choose festival: ");
                                    eventManager.DisplayFestivals();

                                    //the PLAN is to make sure that i can use an "input" that is integer based with readline.
                                    //the input is gonna correspond with the number of event
                                    //the event is gonna be taken in to the "Tickets"-list.
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
