using System;

namespace Assginment_1
{
    class Book : BookstoreItem
    {
        // this class should be derived from the book store item and it should have only the unique properties 
        // class bookStoreItem should be present
        public string Author { get; private set; }

        public Book(string title, string author, double price, int count) : base(title, count, price)
        {
            Title = title;
            Author = author;
            Price = price;
            Count = count;
        }
        public override void Print()
        {
            Console.WriteLine($"[Book]'{Title}' by {Author}, " + "{0:0.00}, ({1}X)", Price, Count);
        }
    }
}
