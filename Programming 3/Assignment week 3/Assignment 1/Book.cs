using System;

namespace Assginment_1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; private set; }
        public int Count { get; set; }
        public double Price { get; set; }
        private double calculated;
        public double Calculated
        {
            get
            {
                return Price * Count;
            }
            private set
            {
                calculated = value;
            }
        }

        public Book(string title, string author, double price, int count)
        {
            Title = title;
            Author = author;
            Price = price;
            Count = count;
        }
        public virtual void Print()
        {
            Console.WriteLine($"[Book]'{Title}' by {Author}, " + "{0:0.00}, ({1}X)", Price, Count);
        }
    }
}
