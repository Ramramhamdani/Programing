﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;
using ChapeauDAL;

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
            catch (SqlException e)
            {

                throw e;
            }
        }

        public List<Table> GetStatus(int tableNumber)
        {
            try
            {
                List<Table> tables = tableDb.GetStatus(tableNumber);
                return tables;
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
        public void UpdateStatus(Table table)
        {
            try
            {
                tableDb.UpdateStatus(table);
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
    }
}
