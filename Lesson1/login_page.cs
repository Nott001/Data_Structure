using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class login_page : Form
    {
        // Initializes variables and database connection
        private String username1, password1, user_level;
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        loginDb_dbconnection login_db_connect = new loginDb_dbconnection();


        public login_page()
        {
            login_db_connect.login_connString(); // Database connection
            InitializeComponent();
        }

        private void cleartextboxes() // Method for clearing textboxes
        {
            username_box.Clear();
            username_box.Focus();
            passwordbox.Clear();
        }


        private void login_page_Load(object sender, EventArgs e)
        {
            username_box.Focus();
        }

        private void login_button_Click(object sender, EventArgs e) // Codes for login button
        {
            try
            {
                login_db_connect.login_sql =
                    "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, username, password, " +
                    "account_type, pos_terminal_no " +
                    "FROM pos_empRegTbl " +
                    "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                    "WHERE username = '" + username_box.Text +
                    "' AND password = '" + passwordbox.Text + "'";

                login_db_connect.login_cmd();
                login_db_connect.login_sqladapterSelect();
                login_db_connect.login_sqldatasetSELECT();

                username1 =
                    login_db_connect.login_sql_dataset.Tables[0].Rows[0][3].ToString();

                password1 =
                    login_db_connect.login_sql_dataset.Tables[0].Rows[0][4].ToString();

                user_level =
                    login_db_connect.login_sql_dataset.Tables[0].Rows[0][5].ToString();

                if ((username1 == username_box.Text) && // Checking if username and password match up
                    (password1 == passwordbox.Text))
                {
                    if (user_level == "Administrator") // Checking which one to load based on user level
                    {
                        MessageBox.Show("Access granted");
                        Main_form myform = new Main_form();
                        myform.Show();
                        cleartextboxes();
                        this.Hide();
                    }
                    else if (user_level == "Cashier1") // Checking which one to load based on user level
                    {
                        MessageBox.Show("Access granted");
                        POS1_shortened myform = new POS1_shortened();

                        myform.emp_id_TxtBox.Text =
                            login_db_connect.login_sql_dataset.Tables[0].Rows[0][0].ToString();

                        myform.emp_name_TxtBox.Text =
                            login_db_connect.login_sql_dataset.Tables[0].Rows[0][2].ToString();

                        myform.terminal_no_TxtBox.Text =
                            login_db_connect.login_sql_dataset.Tables[0].Rows[0][6].ToString();


                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "Cashier2") // Checking which one to load based on user level
                    {
                        MessageBox.Show("Access granted");
                        POS2_shortened myform = new POS2_shortened();
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "HR Staff") // Checking which one to load based on user level
                    {
                        MessageBox.Show("Access granted");
                        Employee_registration myform = new Employee_registration();
                        myform.delete_button.Enabled = false;
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "Accounting Staff") // Checking which one to load based on user level
                    {
                        MessageBox.Show("Access granted");
                        Payroll_shortened myform = new Payroll_shortened();

                        myform.edit_button.Hide();
                        myform.delete_button.Hide();

                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "IT Staff") // Checking which one to load based on user level
                    {
                        MessageBox.Show("Access granted");
                        user_account myform = new user_account();

                        myform.search_for_update_button.Hide();
                        myform.update_button.Hide();
                        myform.delete_button.Hide();

                        cleartextboxes();
                        myform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Access Denied");
                        cleartextboxes();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please contact your administrator");
                cleartextboxes();
            }


        }

        private void exit_button_Click(object sender, EventArgs e) // Codes for exit button
        {
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e) // Codes for cancel button
        {
            username_box.Clear();
            passwordbox.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}