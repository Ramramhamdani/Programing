using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            Console.ReadKey();
        }
        void Start()
        {
            TicketSystem ticketSystem = new TicketSystem();
            ticketSystem.DisplayAllTickets();
            ticketSystem.SellTickets("bruno Mars", 3);
        }
    }
}
