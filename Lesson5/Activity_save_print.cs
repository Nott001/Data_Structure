using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class Activity_save_print : Form
    {
        public Activity_save_print()
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
            sss_wisp_box.Text = "750.00";
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
