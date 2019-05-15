using System;
namespace Assignment_2
{

    class Ticket
    {
        private string movieName;
        public string MovieName
        {
            get
            {
                return movieName;
            }
            set
            {
                if (movieName != "")
                {
                    movieName = value;
                }
            }
        }
        private int cinemaRoom;
        public int CinemaRoom
        {
            get
            {
                return cinemaRoom;
            }
            set
            {
                if (cinemaRoom >= 1 || cinemaRoom <= 5)
                {
                    cinemaRoom = value;
                }
                else
                {
                    Console.WriteLine("Invalid cinema room!");
                }
            }
        }
        private DateTime startTime;
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                if (startTime.Minute == 0 || startTime.Minute == 30)
                {
                    startTime = value;
                }
                else
                {
                    Console.WriteLine("Invalid starting time!");
                }
            }
        }
        public double Price { get; set; }
        private int minimumAge;
        public int MinimumAge
        {
            get => minimumAge;
            set
            {
                if (value == 0 || value == 6 || value == 9 || value == 12 || value == 16)
                {
                    minimumAge = value;
                }
            }
        }
        private bool discount;
        public bool Discount
        {
            get
            {
                if (StartTime.DayOfWeek == DayOfWeek.Monday || StartTime.DayOfWeek == DayOfWeek.Tuesday)
                {
                    return discount = true;
                }
                return discount = false;
            }
            set
            {

            }
        }
        public Ticket(string movieName, int cinemaRoom, DateTime startTime, int minimumAge, double price)
        {
            this.movieName = movieName;
            this.cinemaRoom = cinemaRoom;
            this.startTime = startTime;
            this.minimumAge = minimumAge;
            Price = price;
        }
    }

}
