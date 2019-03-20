using System;
namespace Assignment_2
{

    class Ticket
    {
        public string MovieName { get { return ""; } set { MovieName = value; } }
        public int CinemaRoom
        {
            get
            {
                return CinemaRoom;
            }
            set
            {
                if (CinemaRoom >= 1 || CinemaRoom <= 5)
                {
                    CinemaRoom = value;
                }
                else
                {
                    Console.WriteLine("Invalid cinema room!");
                }
            }
        }
        public DateTime startTime;
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                if (startTime.Minute == 0 || startTime.Minute == 30)
                {
                    StartTime = value;
                }
                else
                {
                    Console.WriteLine("Invalid starting time!");
                }
            }
        }
        public decimal Price { get; set; }
        public int MinimumAge
        {
            get => MinimumAge;
            set
            {
                if (MinimumAge == 0 || MinimumAge == 6 || MinimumAge == 9 || MinimumAge == 12 || MinimumAge == 16)
                {
                    MinimumAge = value;
                }
            }
        }
        private bool discount;
        public bool Discount
        {
            get { return discount = true; }
            set
            {
                if (StartTime.DayOfWeek == DayOfWeek.Monday || StartTime.DayOfWeek == DayOfWeek.Tuesday)
                {
                    Discount = value;
                }
            }
        }
    }

}
