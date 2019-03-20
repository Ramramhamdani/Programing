using System;
namespace Assignment_1
{


    public class Book
    {
        private int id;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
        public override string ToString()
        {
            Console.Write($"{Id}, {Title}, {Author}");
            return base.ToString();
        }
    }


}
