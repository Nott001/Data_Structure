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
    public partial class employee_reports : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
        public employee_reports()
        {
            payrol_db_connect.payrol_connString();
            InitializeComponent();
        }

        private void payrol_select()
        {
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqldataadapterSelect();
            payrol_db_connect.payrol_sqldatasetSELECT();
            dataGridView1.DataSource = payrol_db_connect.payrol_sql_dataset.Tables[0];
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

        private void employee_reports_Load(object sender, EventArgs e)
        {
            optionCombo.Items.Add("employee_number");
            optionCombo.Items.Add("surname");
            optionCombo.Items.Add("firstname");
            optionCombo.Items.Add("department");
            optionCombo.Items.Add("designation");
            optionCombo.Items.Add("zipcode");
            optionCombo.Items.Add("province");
            optionCombo.Items.Add("city");

            payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl";
            payrol_select();
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }
    }
}
