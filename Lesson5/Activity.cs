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
    public partial class Activity : Form
    {
        double basic_income = 0;
        double honoarium_income = 0;
        double other_income = 0;
        double gross_income = 0;
        double total_deductions = 0;
        double net_income = 0;

        public Activity()
        {
            InitializeComponent();
        }

        private void Activity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            double sss_contri = 0;
            double philhealth_contri = 0;
            double income_tax = 0;
            double pagibig_contri = 200.00;

            double sss_loan = 0.00;
            double pagibig_loan = 0.00;
            double faculty_savings_deposit = 0.00;
            double faculty_savings_loan = 0.00;
            double salary_loan = 0.00;
            double other_loan = 0.00;

            //Calculating for income tax
            if (gross_income <= 250000.00)
            {
                 income_tax = 0.00;
            }
            else if (gross_income > 250000.00 && gross_income <= 400000.00)
            {
                income_tax = (gross_income - 250000.00) * 0.15;
            }
            else if (gross_income > 400000.00 && gross_income <= 800000.00)
            {
                income_tax = 22500.00 + ((gross_income - 400000.00) * 0.20);
            }
            else if (gross_income > 800000.00 && gross_income <= 2000000.00)
            {
                income_tax = 102500.00 + ((gross_income - 800000.00) * 0.25);
            }
            else if (gross_income > 2000000.00 && gross_income <= 8000000.00)
            {
                income_tax = 402500.00 + ((gross_income - 2000000.00) * 0.30);
            }
            else if (gross_income > 8000000.00)
            {
                income_tax = 2202500 + ((gross_income - 8000000.00) * 0.35);
            }

            //Calculating for Philhealth contribution
            if (gross_income <= 10000.00)
            {
                philhealth_contri = 0.00;
            }
            else if (gross_income >= 10000.00)
            {
                philhealth_contri = gross_income * 0.05;

            }

            //Calculating for SSS contribution
            if (gross_income < 5250.00)
            {
                sss_contri = 760.00;
            }
            else if (gross_income >= 5250.00 && gross_income <= 5749.99)
            {
                sss_contri = 835.00;
            }
            else if (gross_income >= 6250.00 && gross_income <= 6249.99)
            {
                sss_contri = 910.00;
            }


            //Calculating for total deductions
            pagibig_contri = Convert.ToDouble(pagibig_contri_box.Text);
            sss_loan = Convert.ToDouble(sss_loan_box.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loan_box.Text);
            faculty_savings_deposit = Convert.ToDouble(faculty_savings_deposit_box.Text);
            faculty_savings_loan = Convert.ToDouble(faculty_savings_loan_box.Text);
            salary_loan = Convert.ToDouble(salary_loan_box.Text);
            other_loan = Convert.ToDouble(other_loan_box.Text);

            total_deductions = sss_contri + philhealth_contri + income_tax + pagibig_contri + sss_loan +
                pagibig_loan + faculty_savings_deposit + faculty_savings_loan + salary_loan + other_loan;

            net_income = gross_income - total_deductions;

            total_deduction_box.Text = total_deductions.ToString("n");
            net_income_box.Text = net_income.ToString("n");


        }
    }
}
