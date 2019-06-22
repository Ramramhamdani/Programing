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
            string query = "SELECT * FROM [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow item in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tableID = (int)item["TableID"],
                    status = (int)item["status"]
                };
                tables.Add(table);
            }
            return tables;
        }

        public List<Table> GetStatus(int tableNumber)
        {
            string query = $"SELECT status FROM Table WHERE TableID = {tableNumber}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadStatus(ExecuteSelectQuery(query, sqlParameters),tableNumber);
        }

        private List<Table> ReadStatus(DataTable dataTable,int tableNumber)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tableID = tableNumber,
                    status = (int)dataRow["status"]
                };
                tables.Add(table);
            }
            return tables;
        }

        public void UpdateStatus(Table table)
        {
            string query = $"UPDATE [Table] SET [status] = {table.status} WHERE TableID = {table.tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
