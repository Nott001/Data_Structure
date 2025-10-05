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
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void login_page_Load(object sender, EventArgs e)
        {
            username_box.Focus();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username, password;
            if (username_box.Text == "admin" && passwordbox.Text == "Villamor12345")
            {
                MessageBox.Show("Welcome Admin Page!!!");
                Main_form adminfrm = new Main_form();
                adminfrm.Show();
                username_box.Clear();
                passwordbox.Clear();
                this.Hide();
            }
            else if (username_box.Text == "cashier1" && passwordbox.Text == "Villamor12345")
            {
                MessageBox.Show("Welcome Cashier Point of Sale Page!!!");
                Activity2_lesson2 adminfrm = new Activity2_lesson2();
                adminfrm.Show();
                username_box.Clear();
                passwordbox.Clear();
                this.Hide();
            }
            else if (username_box.Text == "cashier2" && passwordbox.Text == "Villamor12345")
            {
                MessageBox.Show("Welcome Cashier Ordering POS Page!!!");
                Activity4_lesson2 adminfrm = new Activity4_lesson2();
                adminfrm.Show();
                this.Hide();
            }
            else if (username_box.Text == "payroll1" && passwordbox.Text == "Villamor12345")
            {
                MessageBox.Show("Welcome Payroll Page!!!");
                Activity_lesson5 adminfrm = new Activity_lesson5();
                adminfrm.Show();
                this.Hide();
            }
            else if (username_box.Text == "payroll2" && passwordbox.Text == "Villamor12345")
            {
                MessageBox.Show("Welcome Payroll2 Page!!!");
                Activity5_lesson3 adminfrm = new Activity5_lesson3();
                adminfrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_box.Clear();
                passwordbox.Clear();
                username_box.Focus();
            }


        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            username_box.Clear();
            passwordbox.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}