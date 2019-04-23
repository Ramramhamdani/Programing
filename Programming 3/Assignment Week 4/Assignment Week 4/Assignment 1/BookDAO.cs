using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment_1
{
    class BookDAO:LibraryDAL
    {
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOKS", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = ReadBook(reader);
                books.Add(book);
            }
            reader.Close();
            connection.Close();
            return books;
        }

        private Book ReadBook(SqlDataReader reader)
        {
            List<Book> books = new List<Book>();
            Book book = new Book
            {
                Id = (int)reader["ID"],
                Title = (string)reader["Title"],
                Author = (string)reader["Author"]
            };
            return book;
        }
    }
}
