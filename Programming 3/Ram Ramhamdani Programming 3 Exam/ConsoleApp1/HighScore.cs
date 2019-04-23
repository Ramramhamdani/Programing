using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class HighScore
    {
        public List<Score> Scores { get => new List<Score>(); set { Scores = value; } }
        public DateTime Date { get { return Date = DateTime.Today; } set { Date = value; } }

        private string name;
        public string Name { get => name; }
        private int value;
        public int Value
        {
            get
            {
                foreach (Score item in Scores)
                {
                    int itValue = item.ComputeValue();
                    value = +itValue;
                }
                return value;
            }
            set { Value = value; }
        }

        public HighScore(string name, DateTime date)
        {
            this.name = name;
        }
    }
}
