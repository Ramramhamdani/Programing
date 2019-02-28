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

        public BookStore AddBooks(BookStore bookStore, Book book)
        {
            bookStoreItems.Add(book);
            return bookStore;
        }
        public void PrintCompleteStock(BookStore bookStore)
        {
            double totalPrice = 0;
            foreach (Book item in bookStoreItems)
            {
                item.Print();
                totalPrice += item.price;
            }
            Console.WriteLine("\n"+$"Total sales price: {totalPrice}");
        }
    }
}
