using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_1
{
    abstract class BookstoreItem
    {
        public string Title { get; set; }
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
        public BookstoreItem(string title,int count,double price)
        {
            Title = title;
            Count = count;
            Price = price;
        }
        public virtual void Print()
        {
            Console.WriteLine($"[Book]'{Title}' " + "{0:0.00}, ({1}X)", Price, Count);
        }
    }
}
