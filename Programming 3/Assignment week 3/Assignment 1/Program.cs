using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            BookStore bookStore = new BookStore();
            Book book1 = new Book("Dracula","Bram stoker",15,5);
            Book book2 = new Book("Joe speedboat", "Tommy Wieringa", 12.50,5);
            Book book3 = new Book("The hobbit", "J.R.R. Tolkien", 12.50,10);
            Magazine magazine = new Magazine("time", "", 3.90, DayOfWeek.Friday,4);
            bookStore.AddBooks(bookStore, book1);
            bookStore.AddBooks(bookStore, book2);
            bookStore.AddBooks(bookStore, book3);
            bookStore.AddBooks(bookStore, magazine);
            bookStore.PrintCompleteStock(bookStore);
            Console.ReadKey();
        }
    }
}
