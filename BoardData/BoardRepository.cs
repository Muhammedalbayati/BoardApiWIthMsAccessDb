using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardData
{
  public  class BoardRepository
    {

        //public DataSet GetAllData()
        //{
        //    String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Tables.accdb;Persist Security Info=True";
        //    string sql = "SELECT Clients  FROM Tables";
        //    DataSet ds = new DataSet();
        //    using (OleDbConnection conn = new OleDbConnection(connection))
        //    {
        //        conn.Open();
                
        //        //DataGridView dataGridView1 = new DataGridView();
        //        using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
        //        {
        //            adapter.Fill(ds);
        //            //dataGridView1.DataSource = ds;
        //            // Of course, before addint the datagrid to the hosting form you need to 
        //            // set position, location and other useful properties. 
        //            // Why don't you create the DataGrid with the designer and use that instance instead?
        //            //this.Controls.Add(dataGridView1);
        //        }
        //    }

        //    return ds;

        //}


        public DataTable GetAllUsers()
        {
            //|DataDirectory|
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\muham\source\repos\BoardApiWIthMsAccessDb\myDb.accdb";
                                 //Jet OLEDB:Database Password=MyDbPassword;";

            DataTable results = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM UsersTable", conn);

                conn.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                adapter.Fill(results);
            }
            return results;
        }




    }
}
