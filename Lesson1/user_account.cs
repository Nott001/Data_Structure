using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lesson2
{
    public partial class user_account : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        public string PicturePath;

        public user_account()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            emp_idTxtbox.Clear();
            userIDTxtbox.Clear();
            firstnameTxtbox.Clear();
            middlenameTxtbox.Clear();
            surnameTxtbox.Clear();
            designationTxtbox.Clear();
            usernameTxtbox.Clear();
            passwordTxtbox.Clear();
            textBox9.Clear();
            picpathTxtbox.Clear();
            accountTypeComboBox.SelectedIndex = -1;
            account_statusComboBox.SelectedIndex = -1;
            terminalNoComboBox.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void user_account_Load(object sender, EventArgs e)
        {
            try
            {
                firstnameTxtbox.Enabled = false;
                middlenameTxtbox.Enabled = false;
                surnameTxtbox.Enabled = false;
                designationTxtbox.Enabled = false;
                picpathTxtbox.Enabled = false;
                picpathTxtbox.Hide();

                // Populate combo boxes
                accountTypeComboBox.Items.AddRange(new string[] { "Administrator", "Cashier1", "Cashier2", "HR Staff", "Accounting Staff", "IT Staff" });
                account_statusComboBox.Items.AddRange(new string[] { "Active", "Inactive", "Suspended" });

                // Populate terminal numbers (1-10 as example, adjust as needed)
                for (int i = 1; i <= 10; i++)
                {
                    terminalNoComboBox.Items.Add(i.ToString());
                }

                // Hide terminal number components initially
                terminalNoComboBox.Visible = false;

                // Wire up the event handler for account type selection
                accountTypeComboBox.SelectedIndexChanged += new EventHandler(accountTypeComboBox_SelectedIndexChanged);

                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataGrid()
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, " +
                    "emp_fname, emp_mname, emp_surname, position, user_id, username, " +
                    "password, user_status, account_type, pos_terminal_no FROM pos_empRegTbl INNER JOIN " +
                    "useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // Event handler for Account Type ComboBox
        private void accountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountTypeComboBox.Text == "Cashier1")
            {
                terminalNoComboBox.Visible = true;
            }
            else if(accountTypeComboBox.Text == "Cashier2")
            {

            }
            else
            {
                terminalNoComboBox.Visible = false;
                terminalNoComboBox.SelectedIndex = -1;
            }
        }

        // SEARCH BUTTON - Search by Employee ID
        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(emp_idTxtbox.Text))
                {
                    MessageBox.Show("Please enter Employee ID.");
                    return;
                }

                // Search employee information
                useraccount_db_connect.useraccount_sql =
                    "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                if (useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Employee not found.");
                    return;
                }

                DataRow emp = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0];
                firstnameTxtbox.Text = emp["emp_fname"].ToString();
                middlenameTxtbox.Text = emp["emp_mname"].ToString();
                surnameTxtbox.Text = emp["emp_surname"].ToString();
                designationTxtbox.Text = emp["position"].ToString();
                picpathTxtbox.Text = emp["picpath"].ToString();

                // Load and display image
                if (!string.IsNullOrEmpty(picpathTxtbox.Text) && File.Exists(picpathTxtbox.Text))
                {
                    pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
                }
                else
                {
                    pictureBox1.Image = null;
                }

                MessageBox.Show("Employee found successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif";
                ofd.Title = "Select Employee Picture";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PicturePath = ofd.FileName;
                    picpathTxtbox.Text = PicturePath;
                    pictureBox1.Image = Image.FromFile(PicturePath);
                }
            }
        }

        private void search_for_update_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userIDTxtbox.Text))
                {
                    MessageBox.Show("Please enter User ID.");
                    return;
                }

                // Search user account information
                useraccount_db_connect.useraccount_sql =
                    "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, " +
                    "user_id, username, password, user_status, account_type, picpath, pos_terminal_no " +
                    "FROM pos_empRegTbl INNER JOIN useraccountTbl " +
                    "ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                    "WHERE user_id = " + userIDTxtbox.Text;

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                if (useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("User account not found.");
                    return;
                }

                DataRow user = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0];

                // Populate all fields
                emp_idTxtbox.Text = user["emp_id"].ToString();
                firstnameTxtbox.Text = user["emp_fname"].ToString();
                middlenameTxtbox.Text = user["emp_mname"].ToString();
                surnameTxtbox.Text = user["emp_surname"].ToString();
                designationTxtbox.Text = user["position"].ToString();
                usernameTxtbox.Text = user["username"].ToString();
                passwordTxtbox.Text = user["password"].ToString();
                textBox9.Text = user["password"].ToString();
                picpathTxtbox.Text = user["picpath"].ToString();

                // Set combo box values
                account_statusComboBox.Text = user["user_status"].ToString();
                accountTypeComboBox.Text = user["account_type"].ToString();

                // Set terminal number if cashier
                if (user["account_type"].ToString() == "Cashier1")
                {
                    terminalNoComboBox.Visible = true;
                    if (!string.IsNullOrEmpty(user["pos_terminal_no"].ToString()))
                    {
                        terminalNoComboBox.Text = user["pos_terminal_no"].ToString();
                    }
                }
                else if(user["account_type"].ToString() == "Cashier2")
                {
                    terminalNoComboBox.Visible = true;
                    if (!string.IsNullOrEmpty(user["pos_terminal_no"].ToString()))
                    {
                        terminalNoComboBox.Text = user["pos_terminal_no"].ToString();
                    }
                }

                // Load and display image
                if (!string.IsNullOrEmpty(picpathTxtbox.Text) && File.Exists(picpathTxtbox.Text))
                {
                    pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
                }
                else
                {
                    pictureBox1.Image = null;
                }

                MessageBox.Show("User account loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void update_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userIDTxtbox.Text))
                {
                    MessageBox.Show("Please search for a user account first using 'Search for Update' button.");
                    return;
                }

                // Validation
                if (string.IsNullOrWhiteSpace(usernameTxtbox.Text) ||
                    string.IsNullOrWhiteSpace(passwordTxtbox.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Check if Cashier and terminal number is required
                if (accountTypeComboBox.Text == "Cashier1" && terminalNoComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Terminal Number for Cashier accounts.");
                    return;
                }
                else if(accountTypeComboBox.Text == "Cashier2" && terminalNoComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Terminal Number for Cashier accounts.");
                    return;
                }

                // Check if passwords match
                if (passwordTxtbox.Text != textBox9.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to update this user account?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string terminalNo = accountTypeComboBox.Text == "Cashier" ? terminalNoComboBox.Text : "NULL";

                    useraccount_db_connect.useraccount_sql =
                        "UPDATE useraccountTbl SET " +
                        "account_type = '" + accountTypeComboBox.Text + "', " +
                        "username = '" + usernameTxtbox.Text + "', " +
                        "password = '" + passwordTxtbox.Text + "', " +
                        "confirm_password = '" + textBox9.Text + "', " +
                        "user_status = '" + account_statusComboBox.Text + "', " +
                        "pos_terminal_no = " + (terminalNo == "NULL" ? "NULL" : "'" + terminalNo + "'") + " " +
                        "WHERE user_id = " + userIDTxtbox.Text;

                    useraccount_db_connect.useraccount_cmd();
                    useraccount_db_connect.useraccount_sqladapterUpdate();

                    MessageBox.Show("User account updated successfully!");
                    cleartextboxes();
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delete_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userIDTxtbox.Text))
                {
                    MessageBox.Show("Please search for a user account first using 'Search for Update' button.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this user account? This action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    useraccount_db_connect.useraccount_sql =
                        "DELETE FROM useraccountTbl WHERE user_id = " + userIDTxtbox.Text;

                    useraccount_db_connect.useraccount_cmd();
                    useraccount_db_connect.useraccount_sqladapterDelete();

                    MessageBox.Show("User account deleted successfully!");
                    cleartextboxes();
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void submit_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(emp_idTxtbox.Text) ||
                    string.IsNullOrWhiteSpace(userIDTxtbox.Text) ||
                    string.IsNullOrWhiteSpace(usernameTxtbox.Text) ||
                    string.IsNullOrWhiteSpace(passwordTxtbox.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Check if Cashier and terminal number is required
                if (accountTypeComboBox.Text == "Cashier1" && terminalNoComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Terminal Number for Cashier accounts.");
                    return;
                } else if (accountTypeComboBox.Text == "Cashier2" && terminalNoComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Terminal Number for Cashier accounts.");
                    return;
                }


                    // Check if passwords match
                    if (passwordTxtbox.Text != textBox9.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }

                // Check if employee ID exists
                useraccount_db_connect.useraccount_sql =
                    "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                if (useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Employee ID does not exist. Please search for a valid employee first.");
                    return;
                }

                // Check if user ID already exists
                useraccount_db_connect.useraccount_sql =
                    "SELECT * FROM useraccountTbl WHERE user_id = " + userIDTxtbox.Text;
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT_Account();

                if (useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("User ID already exists. Please use a different User ID.");
                    return;
                }

                // Prepare terminal number value
                string terminalNo = accountTypeComboBox.Text == "Cashier1" ? terminalNoComboBox.Text : "NULL";
                string terminalNo2 = accountTypeComboBox.Text == "Cashier2" ? terminalNoComboBox.Text : "NULL";

                // Insert new user account
                useraccount_db_connect.useraccount_sql =
                    "INSERT INTO useraccountTbl (user_id, account_type, username, password, " +
                    "confirm_password, user_status, emp_id, pos_terminal_no) VALUES (" +
                    userIDTxtbox.Text + ", '" +
                    accountTypeComboBox.Text + "', '" +
                    usernameTxtbox.Text + "', '" +
                    passwordTxtbox.Text + "', '" +
                    textBox9.Text + "', '" +
                    account_statusComboBox.Text + "', '" +
                    emp_idTxtbox.Text + "', " +
                    (terminalNo == "NULL" ? "NULL" : "'" + terminalNo + "'") + ")";

                // Insert new user account
                useraccount_db_connect.useraccount_sql =
                    "INSERT INTO useraccountTbl (user_id, account_type, username, password, " +
                    "confirm_password, user_status, emp_id, pos_terminal_no) VALUES (" +
                    userIDTxtbox.Text + ", '" +
                    accountTypeComboBox.Text + "', '" +
                    usernameTxtbox.Text + "', '" +
                    passwordTxtbox.Text + "', '" +
                    textBox9.Text + "', '" +
                    account_statusComboBox.Text + "', '" +
                    emp_idTxtbox.Text + "', " +
                    (terminalNo2 == "NULL" ? "NULL" : "'" + terminalNo2 + "'") + ")";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterInsert();

                MessageBox.Show("User account created successfully!");
                cleartextboxes();
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}