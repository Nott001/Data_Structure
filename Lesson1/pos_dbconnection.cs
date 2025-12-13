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
            pos_sql = "SELECT pos_nameTbl.pos_id, " +
                      "pos_nameTbl.name1, pos_nameTbl.name2, pos_nameTbl.name3, pos_nameTbl.name4, pos_nameTbl.name5, " +
                      "pos_nameTbl.name6, pos_nameTbl.name7, pos_nameTbl.name8, pos_nameTbl.name9, pos_nameTbl.name10, " +
                      "pos_nameTbl.name11, pos_nameTbl.name12, pos_nameTbl.name13, pos_nameTbl.name14, pos_nameTbl.name15, " +
                      "pos_nameTbl.name16, pos_nameTbl.name17, pos_nameTbl.name18, pos_nameTbl.name19, pos_nameTbl.name20, " +
                      "pos_picTbl.pic1, pos_picTbl.pic2, pos_picTbl.pic3, pos_picTbl.pic4, pos_picTbl.pic5, " +
                      "pos_picTbl.pic6, pos_picTbl.pic7, pos_picTbl.pic8, pos_picTbl.pic9, pos_picTbl.pic10, " +
                      "pos_picTbl.pic11, pos_picTbl.pic12, pos_picTbl.pic13, pos_picTbl.pic14, pos_picTbl.pic15, " +
                      "pos_picTbl.pic16, pos_picTbl.pic17, pos_picTbl.pic18, pos_picTbl.pic19, pos_picTbl.pic20, " +
                      "pos_priceTbl.price1, pos_priceTbl.price2, pos_priceTbl.price3, pos_priceTbl.price4, pos_priceTbl.price5, " +
                      "pos_priceTbl.price6, pos_priceTbl.price7, pos_priceTbl.price8, pos_priceTbl.price9, pos_priceTbl.price10, " +
                      "pos_priceTbl.price11, pos_priceTbl.price12, pos_priceTbl.price13, pos_priceTbl.price14, pos_priceTbl.price15, " +
                      "pos_priceTbl.price16, pos_priceTbl.price17, pos_priceTbl.price18, pos_priceTbl.price19, pos_priceTbl.price20 " +
                      "FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id";
        }

        public void pos_select_cashier()
        {
            pos_sql = "SELECT pos_nameTbl.pos_id, " +
                      "pos_nameTbl.name1, pos_nameTbl.name2, pos_nameTbl.name3, pos_nameTbl.name4, pos_nameTbl.name5, " +
                      "pos_nameTbl.name6, pos_nameTbl.name7, pos_nameTbl.name8, pos_nameTbl.name9, pos_nameTbl.name10, " +
                      "pos_nameTbl.name11, pos_nameTbl.name12, pos_nameTbl.name13, pos_nameTbl.name14, pos_nameTbl.name15, " +
                      "pos_nameTbl.name16, pos_nameTbl.name17, pos_nameTbl.name18, pos_nameTbl.name19, pos_nameTbl.name20, " +
                      "pos_picTbl.pic1, pos_picTbl.pic2, pos_picTbl.pic3, pos_picTbl.pic4, pos_picTbl.pic5, " +
                      "pos_picTbl.pic6, pos_picTbl.pic7, pos_picTbl.pic8, pos_picTbl.pic9, pos_picTbl.pic10, " +
                      "pos_picTbl.pic11, pos_picTbl.pic12, pos_picTbl.pic13, pos_picTbl.pic14, pos_picTbl.pic15, " +
                      "pos_picTbl.pic16, pos_picTbl.pic17, pos_picTbl.pic18, pos_picTbl.pic19, pos_picTbl.pic20, " +
                      "pos_priceTbl.price1, pos_priceTbl.price2, pos_priceTbl.price3, pos_priceTbl.price4, pos_priceTbl.price5, " +
                      "pos_priceTbl.price6, pos_priceTbl.price7, pos_priceTbl.price8, pos_priceTbl.price9, pos_priceTbl.price10, " +
                      "pos_priceTbl.price11, pos_priceTbl.price12, pos_priceTbl.price13, pos_priceTbl.price14, pos_priceTbl.price15, " +
                      "pos_priceTbl.price16, pos_priceTbl.price17, pos_priceTbl.price18, pos_priceTbl.price19, pos_priceTbl.price20 " +
                      "FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                      "WHERE pos_nameTbl.pos_id = '1'";
        }

        public void pos_select_cashier1()
        {
            pos_sql = "SELECT pos_nameTbl.pos_id, " +
                      "pos_nameTbl.name1, pos_nameTbl.name2, pos_nameTbl.name3, pos_nameTbl.name4, pos_nameTbl.name5, " +
                      "pos_nameTbl.name6, pos_nameTbl.name7, pos_nameTbl.name8, pos_nameTbl.name9, pos_nameTbl.name10, " +
                      "pos_nameTbl.name11, pos_nameTbl.name12, pos_nameTbl.name13, pos_nameTbl.name14, pos_nameTbl.name15, " +
                      "pos_nameTbl.name16, pos_nameTbl.name17, pos_nameTbl.name18, pos_nameTbl.name19, pos_nameTbl.name20, " +
                      "pos_picTbl.pic1, pos_picTbl.pic2, pos_picTbl.pic3, pos_picTbl.pic4, pos_picTbl.pic5, " +
                      "pos_picTbl.pic6, pos_picTbl.pic7, pos_picTbl.pic8, pos_picTbl.pic9, pos_picTbl.pic10, " +
                      "pos_picTbl.pic11, pos_picTbl.pic12, pos_picTbl.pic13, pos_picTbl.pic14, pos_picTbl.pic15, " +
                      "pos_picTbl.pic16, pos_picTbl.pic17, pos_picTbl.pic18, pos_picTbl.pic19, pos_picTbl.pic20, " +
                      "pos_priceTbl.price1, pos_priceTbl.price2, pos_priceTbl.price3, pos_priceTbl.price4, pos_priceTbl.price5, " +
                      "pos_priceTbl.price6, pos_priceTbl.price7, pos_priceTbl.price8, pos_priceTbl.price9, pos_priceTbl.price10, " +
                      "pos_priceTbl.price11, pos_priceTbl.price12, pos_priceTbl.price13, pos_priceTbl.price14, pos_priceTbl.price15, " +
                      "pos_priceTbl.price16, pos_priceTbl.price17, pos_priceTbl.price18, pos_priceTbl.price19, pos_priceTbl.price20 " +
                      "FROM pos_nameTbl " +
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
