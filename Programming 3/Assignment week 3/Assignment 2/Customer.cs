using System;
namespace Assignment_2
{
    class Customer
    {
        public string name { get; private set; }
        public int age;
        public DateTime date;
        public int Age { get; private set; }
        public DateTime Date { get; private set; }
        public int DateOfBirth
        {
            set
            {
                if (Date.Year < date.Year)
                {
                    Age = value;
                }
            }
            get
            {
                return Age = Date.Year - age;
            }
        }
        public bool Discount
        {
            get
            {
                return true;
            }
            set
            {
                if (Age<10)
                {
                    Discount = value;
                }
            }
        }
        public Customer(string name,int age,DateTime date,DateTime dateOfBirth)
        {
            this.name = name;
            this.age = age;
            this.date = date;
            this.Date = dateOfBirth;
        }
    }
}
