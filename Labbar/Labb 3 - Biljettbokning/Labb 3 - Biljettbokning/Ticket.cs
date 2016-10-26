using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Biljettbokning
{
    class Ticket
    {
        public string UserName { get; set; }
        public string TicketType { get; set; }
        public List<Event> Tickets { get; set; }


        //constructor for each ticket to include a list of events
        public Ticket()
        {
            Tickets = new List<Event>();
        }
    }
}
