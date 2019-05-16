using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_1
{
    class BookStore
    {
        private List<Book> bookStoreItems = new List<Book>();
        // only parameter book
        public BookStore AddBooks(BookStore bookStore, Book book)
        {
            bookStoreItems.Add(book);
            return bookStore;
        }
        public void PrintCompleteStock(BookStore bookStore)
        {
            // I dont need parameters in print method
            double totalPrice = 0;
            foreach (Book item in bookStoreItems)
            {
                item.Print();
                totalPrice += item.Calculated;
            }
            Console.WriteLine("\n"+$"Total sales price: {totalPrice}");
        }
    }
}
