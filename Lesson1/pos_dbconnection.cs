using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // added for MessageBox

namespace Lesson2
{
    internal class pos_dbconnection
    {
        // Database variables
        public string pos_connectionString = null;
        public SqlConnection pos_sql_connection;
        public SqlCommand pos_sql_command;
        public DataSet pos_sql_dataset;
        public SqlDataAdapter pos_sql_dataadapter;
        public string pos_sql = null;

        // Connect to database
        public void pos_connString()
        {
            // Codes to establish connection from C# forms to the SQL Server Database
            pos_sql_connection = new SqlConnection();
            pos_connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True;";
            pos_sql_connection = new SqlConnection(pos_connectionString);
            pos_sql_connection.ConnectionString = pos_connectionString;
            pos_sql_connection.Open();
        }

        // Create command
        public void pos_cmd()
        {
            pos_sql_command = new SqlCommand(pos_sql, pos_sql_connection);
            pos_sql_command.CommandType = CommandType.Text;
        }

        // SELECT
        public void pos_sqladapterSelect()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.SelectCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        // INSERT
        public void pos_sqladapterInsert()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        // DELETE
        public void pos_sqldataadapterDelete()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        // UPDATE
        public void pos_sqldataadapterUpdate()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        // SELECT dataset (for product table)
        public void pos_sqldatasetSELECT()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_nameTbl");
        }

        // SELECT dataset (for sales table)
        public void pos_sqldatasetSELECTSALES()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "salesTbl");
        }

        // Queries
        public void pos_select()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id";
        }

        public void pos_select_cashier()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                      "WHERE pos_nameTbl.pos_id = '1'";
        }

        public void pos_select_cashier1()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                      "WHERE pos_nameTbl.pos_id = '2'";
        }

        public void pos_select_cashier_display()
        {
            pos_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, pos_terminal_no, account_type " +
                      "FROM pos_empRegTbl " +
                      "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                      "WHERE account_type = 'Administrator'";
        }

        public void pos_select_cashier_SELECTdisplay()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_empRegTbl");
        }
    }
}
