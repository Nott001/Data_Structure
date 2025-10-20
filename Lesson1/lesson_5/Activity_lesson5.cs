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
    public partial class Activity_lesson5 : Form
    {
        double basic_income = 0;
        double honoarium_income = 0;
        double other_income = 0;
        double gross_income = 0;
        double total_deductions = 0;
        double net_income = 0;

        public Activity_lesson5()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Calculatiuons for basic income
            int basic_no_hours = 0;
            double basic_rate_hour = 0;

            basic_no_hours = Convert.ToInt32(basic_hrs_box.Text);
            basic_rate_hour = Convert.ToDouble(basic_rate_hr_box.Text);

            basic_income = basic_no_hours * basic_rate_hour;

            basic_income_box.Text = basic_income.ToString("n");

            //Calculations for overtime income
            int honoarium_no_hours = 0;
            double honoarium_rate_hour = 0;

            honoarium_no_hours = Convert.ToInt32(honorarium_hrs_box.Text);
            honoarium_rate_hour = Convert.ToDouble(honorarium_rate_hr_box.Text);

            honoarium_income = honoarium_no_hours * honoarium_rate_hour;

            honorarium_income_box.Text = honoarium_income.ToString("n");

            //Calculations for other income
            int other_no_hours = 0;
            double other_rate_hour = 0;

            other_no_hours = Convert.ToInt32(other_hrs_box.Text);
            other_rate_hour = Convert.ToDouble(other_rate_hr_box.Text);

            other_income = other_no_hours * other_rate_hour;

            other_income_box.Text = other_income.ToString("n");

            //Calculations for gross income
            gross_income = basic_income + honoarium_income + other_income;
            gross_income_box.Text = gross_income.ToString("n");
        }

        private void Activity_Load_1(object sender, EventArgs e)
        {
            basic_income_box.Enabled = false;
            honorarium_income_box.Enabled = false;
            other_income_box.Enabled = false;
            sss_contri_box.Enabled = false;
            philhealth_contri_box.Enabled = false;
            tax_contri_box.Enabled = false;
            total_deduction_box.Enabled = false;
            pagibig_contri_box.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double sss_contri = 0.00;
            double philhealth_contri = 0.00;
            double income_tax = 0.00;
            double pagibig_contri = 200.00;
            double sss_wisp = 750.00;

            double sss_loan = 0.00;
            double pagibig_loan = 0.00;
            double faculty_savings_deposit = 0.00;
            double faculty_savings_loan = 0.00;
            double salary_loan = 0.00;
            double other_loan = 0.00;

            //Calculating for income tax
            if (gross_income <= ((250000.00) / 12))
            {
                income_tax = 0.00;
            }
            else if (gross_income > ((250000.00) / 12) && gross_income <= ((400000.00) / 12))
            {
                income_tax = (gross_income - ((250000.00) / 12)) * 0.15;
            }
            else if (gross_income > ((400000.00) / 12) && gross_income <= ((800000.00) / 12))
            {
                income_tax = ((22500.00) / 12) + ((gross_income - ((400000.00) / 12)) * 0.20);
            }
            else if (gross_income > ((800000.00) / 12) && gross_income <= ((2000000.00) / 12))
            {
                income_tax = ((102500.00) / 12) + ((gross_income - ((800000.00) / 12)) * 0.25);
            }
            else if (gross_income > ((2000000.00) / 12) && gross_income <= ((8000000.00) / 12))
            {
                income_tax = ((402500.00) / 12) + ((gross_income - ((2000000.00) / 12)) * 0.30);
            }
            else if (gross_income > ((8000000.00) / 12))
            {
                income_tax = ((2202500) / 12) + ((gross_income - ((8000000.00) / 12)) * 0.35);
            }

            // Calculating for PhilHealth contribution
            if (gross_income <= 10000.00)
            {
                philhealth_contri = 500.00;
            }
            else if (gross_income >= 100000.00)
            {
                philhealth_contri = 5000.00;
            }
            else
            {
                philhealth_contri = gross_income * 0.05;
            }

            //Calculating for SSS contribution
            if (gross_income < 5250.00)
            {
                sss_contri = 250.00;
            }
            else if (gross_income >= 34750.00)
            {
                sss_contri = 1750.00;
            }
            else
            {
                // Each 500 step increases contribution by 75
                int step = (int)((gross_income - 5250.00) / 500.00);
                sss_contri = 275.00 + (step * 25.00);
            }

            //Calculating for total deductions
            sss_loan = Convert.ToDouble(sss_loan_box.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loan_box.Text);
            faculty_savings_deposit = Convert.ToDouble(faculty_savings_deposit_box.Text);
            faculty_savings_loan = Convert.ToDouble(faculty_savings_loan_box.Text);
            salary_loan = Convert.ToDouble(salary_loan_box.Text);
            other_loan = Convert.ToDouble(other_loan_box.Text);

            total_deductions = sss_contri + philhealth_contri + income_tax + pagibig_contri + sss_loan +
                pagibig_loan + faculty_savings_deposit + faculty_savings_loan + salary_loan + other_loan + sss_wisp;

            net_income = gross_income - total_deductions;

            //Displaying outputs
            philhealth_contri_box.Text = philhealth_contri.ToString("n");
            tax_contri_box.Text = income_tax.ToString("n");
            pagibig_contri_box.Text = pagibig_contri.ToString("n");
            sss_contri_box.Text = sss_contri.ToString("n");
            total_deduction_box.Text = total_deductions.ToString("n");
            net_income_box.Text = net_income.ToString("n");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Activity_lesson5_Print print = new Activity_lesson5_Print();

            string combined = surname_box.Text + "," + firstname_box.Text + middlename_box.Text;
            print.CombinedText = combined;

            print.emp_num_box.Text = this.emp_num_box.Text;
            print.department_box.Text = this.department_box.Text;
            print.paydate_box.Text = this.dateTimePicker1.Text;
            print.cut_off_box.Text = this.dateTimePicker1.Text;
            print.basic_hrs_box.Text = this.basic_hrs_box.Text;
            print.honorarium_hrs_box.Text = this.honorarium_hrs_box.Text;
            print.other_hrs_box.Text = this.other_hrs_box.Text;
            print.basic_income_box.Text = this.basic_income_box.Text;
            print.honorarium_income_box.Text = this.honorarium_income_box.Text;
            print.other_income_box.Text = this.other_income_box.Text;
            print.gross_income_box.Text = this.gross_income_box.Text;
            print.total_deduction_box.Text = this.total_deduction_box.Text;
            print.tax_contri_box.Text = this.tax_contri_box.Text;
            print.sss_contri_box.Text = this.sss_contri_box.Text;
            print.philhealth_contri_box.Text = this.philhealth_contri_box.Text;
            print.pagibig_contri_box.Text = this.pagibig_contri_box.Text;
            print.net_income_box.Text = this.net_income_box.Text;

            print.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Code to browse file explorer using browse button
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Code to allow only images
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select a Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the picturebox image to the selected photo
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void department_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
