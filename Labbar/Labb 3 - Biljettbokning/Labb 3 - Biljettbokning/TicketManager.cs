using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Biljettbokning
{
    class TicketManager
    {
        public List<Ticket> Tickets { get; set; }

        //constructor for each ticket to include a list of events
        public TicketManager()
        {
            Tickets = new List<Ticket>();
        }

        public void AddConcertTicket()
        {
            Ticket newTicket = new Ticket();

            Console.WriteLine("Enter username: ");
            newTicket.UserName = Console.ReadLine();

            newTicket.TicketType = "Concert";

            Tickets.Add(newTicket);
        }

        public void AddFilmTicket()
        {
            Ticket newTicket = new Ticket();

            Console.WriteLine("Enter username: ");
            newTicket.UserName = Console.ReadLine();

            newTicket.TicketType = "Film";

            Tickets.Add(newTicket);
        }

        public void AddFestivalTicket()
        {
            Ticket newTicket = new Ticket();

            Console.WriteLine("Enter username: ");
            newTicket.UserName = Console.ReadLine();

            newTicket.TicketType = "Festival";

            Tickets.Add(newTicket);
        }

        public void DisplayAllTickets()
        {
            foreach (var Ticket in Tickets)
            {
                Console.WriteLine("{0}: {1}", Ticket.UserName, Ticket.TicketType);
            }
        }
    }
}
