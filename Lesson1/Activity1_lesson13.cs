using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lesson2
{

    public partial class Activity1_lesson13 : Form
    {
        // declaration of variables used in form programs for database connections
        String picpath; 
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        public Activity1_lesson13()
        {
            // codes in creating and establishing SQL Connection Object
            connectionString = "Data Source = localhost\\SQLEXPRESS ; Initial Catalog =  SampleDatabaseDb; Trusted_Connection = True";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Activity1_lesson13_Load(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            // code to open the connection between c# and ms sql
            connection.Open();
            //mssql query to insert or save data from GUI interface to the student table
            sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) VALUES('" + studentNumTxtBox.Text + "', '" +
                studentNameTxtBox.Text + "', '" + departmentTxtBox.Text + "', '" + picturepathTxtBox.Text + "')";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            // codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            // mssql query to display the contents of student table located inside the database
            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            // codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            // codes for mirroring the contents of the database inside MSSQL going to C# or VS studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            // codes for displaying the conetents of student table to the inside of data grid view
            dataGridView1.DataSource = dset.Tables[0];

            studentNameTxtBox.Clear();
            studentNumTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code to browse file explorer using browse button
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select a Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = openFileDialog.FileName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    picturepathTxtBox.Text = pictureBox1.ImageLocation;
                }
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            //mssql query to display the contents of the student table
            sql = "SELECT * FROM studentTbl WHERE student_id = '" + studentNumTxtBox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            // codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            // codes for mirroring the contents of the database inside MSSQL going to C# or VS studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            // codes for displaying the conetents of student table to the inside of data grid view
            dataGridView1.DataSource = dset.Tables[0];

            // codes for displaying the contentsof the student table to the textboxes
            studentNameTxtBox.Text = dset.Tables[0].Rows[0][1].ToString();
            departmentTxtBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picturepathTxtBox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picturepathTxtBox.Text);

            connection.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            // mssql query to modify the contents of student table located inside the database
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
