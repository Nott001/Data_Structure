using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class useraccount_reports : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        public useraccount_reports()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void useraccount_select()
        {
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            optionCombo.Text = "";
            optionInputTxtbox.Clear();
            optionCombo.Focus();
        }

        private void cleartextboxes1()
        {
            optionInputTxtbox.Clear();
            optionInputTxtbox.Focus();
        }

        private void useraccount_reports_Load(object sender, EventArgs e)
        {
            optionCombo.Items.Add("user_id");
            optionCombo.Items.Add("employee_number");
            optionCombo.Items.Add("surname");
            optionCombo.Items.Add("firstname");
            optionCombo.Items.Add("active");
            optionCombo.Items.Add("deactivate");

            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, " +
                    "emp_fname, emp_mname, emp_surname, emp_age, emp_gender, " +
                    "emp_department, position, user_id, username, password, user_status, " +
                    "account_type, pos_terminal_no FROM pos_empRegTbl INNER JOIN useraccountTbl ON " +
                    "pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_select();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (optionCombo.Text == "user_id")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT " +
                        "pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, " +
                        "emp_age, emp_gender, emp_department, position, user_id, " +
                        "username, password, user_status, account_type, pos_terminal_no FROM " +
                        "pos_empRegTbl INNER JOIN useraccountTbl ON " +
                        "pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_id = " +
                        "'" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "employee_number")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT " +
                        "pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, " +
                        "emp_age, emp_gender, emp_department, position, user_id, " +
                        "username, password, user_status, account_type, pos_terminal_no FROM " +
                        "pos_empRegTbl INNER JOIN useraccountTbl ON " +
                        "pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE " +
                        "pos_empRegTbl.emp_id = '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "surname")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT " +
                        "pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, " +
                        "emp_age, emp_gender, emp_department, position, user_id, " +
                        "username, password, user_status, account_type, pos_terminal_no FROM " +
                        "pos_empRegTbl INNER JOIN useraccountTbl ON " +
                        "pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE emp_surname " +
                        "= '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "firstname")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT " +
                        "pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, " +
                        "emp_age, emp_gender, emp_department, position, user_id, " +
                        "username, password, user_status, account_type, pos_terminal_no FROM " +
                        "pos_empRegTbl INNER JOIN useraccountTbl ON " +
                        "pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE emp_fname = " +
                        "'" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "active")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT " +
                        "pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, " +
                        "emp_age, emp_gender, emp_department, position, user_id, " +
                        "username, password, user_status, account_type, pos_terminal_no FROM " +
                        "pos_empRegTbl INNER JOIN useraccountTbl ON " +
                        "pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_status " +
                        "= '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "deactivate")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT " +
                        "pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, " +
                        "emp_age, emp_gender, emp_department, position, user_id, " +
                        "username, password, user_status, account_type, pos_terminal_no FROM " +
                        "pos_empRegTbl INNER JOIN useraccountTbl ON " +
                        "pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_status " +
                        "= '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else
                {
                    MessageBox.Show("No Available Record Found!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, " +
                    "emp_fname, emp_mname, emp_surname, emp_age, emp_gender, " +
                    "emp_department, position, user_id, username, password, user_status, " +
                    "account_type, pos_terminal_no FROM pos_empRegTbl INNER JOIN useraccountTbl ON " +
                    "pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_select();
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}