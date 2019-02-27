using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_1
{
    class Magazine:Book
    {
        DayOfWeek releasDay;
        public Magazine(string title, string author, double price,DayOfWeek dayOfWeek ) :base(title,author,price)
        {
            this.title = title;
            this.price = price;
            releasDay = dayOfWeek;
        }
        public override void Print()
        {
            //base.Print();
            Console.WriteLine($"[Magazine]'{title}' release day: {releasDay}, " + "{0:0.00}", price);
        }
    }
}
