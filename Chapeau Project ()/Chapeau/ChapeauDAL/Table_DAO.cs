using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class Table_DAO : Base
    {
        public List<Table> GetTables()
        {
            string query = "SELECT * FROM Table";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            dataTable = new DataTable();
            foreach (DataRow item in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tableID = (int)item["TableID"],
                    status = (bool)item["status"]
                };
                tables.Add(table);
            }
            return tables;
        }
    }
}
