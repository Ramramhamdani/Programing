using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_1
{
    class BookStore
    {
        private List<BookstoreItem> bookStoreItems = new List<BookstoreItem>();
        // only parameter book
        public BookStore AddBooks(BookStore bookStore, BookstoreItem bookstoreItem)
        {
            bookStoreItems.Add(bookstoreItem);
            return bookStore;
        }
        public void PrintCompleteStock()
        {
            // I dont need parameters in print method
            double totalPrice = 0;
            foreach (BookstoreItem item in bookStoreItems)
            {
                item.Print();
                totalPrice += item.Calculated;
            }
            Console.WriteLine("\n"+$"Total sales price: {totalPrice}");
        }
    }
}
