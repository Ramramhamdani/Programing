using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class CustomerDAO:LibraryDAL
    {
        public List<Customer> GetAll()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM db", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = ReadCustomer(reader);
                customers.Add(customer);
            }
            reader.Close();
            connection.Close();
            return customers;
        }
        public Customer ReadCustomer(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string name = (string)reader["Firstname"];
            Customer customer = new Customer(id, name, name, name);
            return customer;
        }

    }
}
