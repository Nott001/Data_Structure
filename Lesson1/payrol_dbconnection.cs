using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class payrol_dbconnection
    {
        public String payrol_connectionString = null;
        public SqlConnection payrol_sql_connection;
        public SqlCommand payrol_sql_command;
        public DataSet payrol_sql_dataset;
        public SqlDataAdapter payrol_sql_dataadapter;
        public string payrol_sql = null;

        public void payrol_connString()
        {
            payrol_sql_connection = new SqlConnection();
            // CONNECTION STRING AND OPEN CONNECTION
            payrol_connectionString = "Data Source=10.211.147.115;Initial Catalog=POSDB; User=sa; Password=yuta123; TrustServerCertificate=True";
            payrol_sql_connection = new SqlConnection(payrol_connectionString);
            payrol_sql_connection.ConnectionString = payrol_connectionString;
            payrol_sql_connection.Open();
        }


        // SQL COMMAND
        public void payrol_cmd()   // supports MSSQL query execution
        {
            payrol_sql_command = new SqlCommand(payrol_sql, payrol_sql_connection);
            payrol_sql_command.CommandType = CommandType.Text;
        }


        // SELECT
        public void payrol_sqldataadapterSelect()   // mediates C# and MSSQL SELECT command
        {
            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.SelectCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }


        // INSERT
        public void payrol_sqldataadapterInsert()   // mediates C# and MSSQL INSERT command
        {
            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.InsertCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }


        // DELETE
        public void payrol_sqldataadapterDelete()   // mediates C# and MSSQL DELETE command
        {
            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.DeleteCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }


        // UPDATE
        public void payrol_sqldataadapterUpdate()   // mediates C# and MSSQL UPDATE command
        {
            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.UpdateCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }


        // DATASET SELECT
        public void payrol_sqldatasetSELECT()   // mirrors database contents to C# / Visual Studio
        {
            payrol_sql_dataset = new DataSet();
            payrol_sql_dataadapter.Fill(payrol_sql_dataset, "pos_empRegTbl");
        }
    }
}
