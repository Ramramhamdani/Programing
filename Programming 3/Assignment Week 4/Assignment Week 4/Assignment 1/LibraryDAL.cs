using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Assignment_1
{
    class LibraryDAL
    {
        protected SqlDataAdapter sql;
        protected SqlConnection connection;

        public LibraryDAL()
        {
            sql = new SqlDataAdapter();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings[""].ConnectionString);
        }   
    }
}
