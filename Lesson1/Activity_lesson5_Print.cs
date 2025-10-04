using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson2
{
    public partial class Activity_lesson5_Print : Form
    {
        public Activity_lesson5_Print()
        {
            InitializeComponent();
        }

        public string CombinedText
        {
            get { return employee_name_box.Text; }
            set { employee_name_box.Text = value; }
        }

        private void emp_num_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Activity_save_print_Load(object sender, EventArgs e)
        {
            company_box.Enabled = false;
            employee_name_box.Enabled = false;
            emp_num_box.Enabled = false;
            department_box.Enabled = false;
            cut_off_box.Enabled = false;
            paydate_box.Enabled = false;

            emp_num_box.Enabled = false;
            department_box.Enabled = false;
            paydate_box.Enabled = false;
            cut_off_box.Enabled = false;
            basic_hrs_box.Enabled = false;
            honorarium_hrs_box.Enabled = false;
            other_hrs_box.Enabled = false;
            basic_income_box.Enabled = false;
            honorarium_income_box.Enabled = false;
            other_income_box.Enabled = false;
            gross_income_box.Enabled = false;
            total_deduction_box.Enabled = false;
            tax_contri_box.Enabled = false;
            sss_contri_box.Enabled = false;
            philhealth_contri_box.Enabled = false;
            pagibig_contri_box.Enabled = false;
            net_income_box.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            sss_wisp_box.Enabled = false;
            gross_box_2.Enabled = false;
            deductions_box_2.Enabled = false;

            company_box.Text = "Lyceum of the Philippines University Cavite";
            textBox1.Text = "0.00";
            textBox2.Text = "0.00";
            textBox3.Text = "0.00";
            textBox4.Text = "0.00";
            textBox5.Text = "0.00";
            textBox6.Text = "0.00";
            textBox7.Text = "0.00";
            textBox8.Text = "0.00";
            textBox9.Text = "0.00";
            textBox10.Text = "0.00";
            textBox11.Text = "0.00";
            textBox12.Text = "0.00";
            textBox13.Text = "0.00";

            sss_wisp_box.Text = "750.00";

            gross_box_2.Text = gross_income_box.Text;
            deductions_box_2.Text = total_deduction_box.Text;


        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Activity_save_print_Load_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
