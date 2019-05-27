using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class Table_Service
    {
        Table_DAO tableDb = new Table_DAO();

        public List<Table> GetTables()
        {
            try
            {
                List<Table> tables = tableDb.GetTables();
                return tables;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
