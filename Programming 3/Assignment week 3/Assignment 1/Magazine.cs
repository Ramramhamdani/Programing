using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_1
{
    class Magazine:Book
    {
    // only this field should be property
        DayOfWeek releasDay;
        public Magazine(string title, string author, double price,DayOfWeek dayOfWeek,int count)
            :base(title,author,price,count)
        {
            Title = title;
            Price = price;
            releasDay = dayOfWeek;
        }
        public override void Print()
        {
            //base.Print();
            Console.WriteLine($"[Magazine]'{Title}' release day: {releasDay}, " + "{0:0.00}, ({1}X)", Calculated,Count);
        }
    }
}
