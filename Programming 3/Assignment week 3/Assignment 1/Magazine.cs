using System;

namespace Assginment_1
{
    class Magazine : BookstoreItem
    {
        public DayOfWeek ReleasDay { get; set; }
        public Magazine(string title, string author, double price, DayOfWeek dayOfWeek, int count)
            : base(title, count, price)
        {
            Title = title;
            Price = price;
            ReleasDay = dayOfWeek;
        }
        public override void Print()
        {
            //base.Print();
            Console.WriteLine($"[Magazine]'{Title}' release day: {ReleasDay}, " + "{0:0.00}, ({1}X)", Calculated, Count);
        }
    }
}
