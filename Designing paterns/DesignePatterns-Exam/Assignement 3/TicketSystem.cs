using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_3
{
    class TicketSystem
    {
        static Dictionary<string,int> tickets;

        public TicketSystem()
        {
            tickets = new Dictionary<string, int>();
            tickets.Add("Bruno Mars", 250);
            tickets.Add("Coldplay", 175);
            tickets.Add("Ed Sheeran", 150);
        }

        public void SellTickets(string artist , int count)
        {
            int value = 0;
            if (tickets.ContainsKey(artist))
            {
                tickets[artist] -= count;
            }
        }
        public void DisplayAllTickets()
        {
            int num = tickets["Bruno Mars"];
            num = num + tickets["Coldplay"];
            num = num + tickets["Ed Sheeran"];
            Console.WriteLine($"number of tickets: {num}");
        }
    }
}
