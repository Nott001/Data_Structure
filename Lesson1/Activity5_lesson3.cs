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
    public partial class Activity5_lesson3 : Form
    {
        // declaration of global variables
        private string picpath;
        private Double basic_netincome = 0.00;
        Double basic_numhrs = 0.00;
        Double basic_rate = 0.00;
        Double hono_netincome = 0.00;
        Double hono_numhrs = 0.00;
        Double other_rate = 0.00;

        private Double netincome = 0.00;
        Double grossincome = 0.00;
        Double sss_contrib = 0.00;
        Double pagibig_contrib = 0.00;
        Double philhealth_contrib = 0.00;
        Double tax_contrib = 0.00;

        private Double sss_loan = 0.00;
        Double pagibig_loan = 0.00;
        Double salary_loan = 0.00;
        Double salary_savings = 0.00;
        Double faculty_savings_loan = 0.00;
        Double other_deduction = 0.00;
        Double total_deduction = 0.00;
        Double total_contrib = 0.00;
        Double total_loan = 0.00;

        public Activity5_lesson3()
        {
            InitializeComponent();
        }

        private void Activity5_Load(object sender, EventArgs e)
        {
            // Codes for disabling
            Income_per_cutoff.Enabled = false;
            Total_honor_pay_box.Enabled = false;
            total_other_income_pay_box.Enabled = false;
            Net_income.Enabled = false;
            Gross_income.Enabled = false;
            Total_deductions.Enabled = false;
            Sss_contri_box.Text = "0.00";
            Pagibig_contri_box.Text = "0.00";
            Phil_health_contri_box.Text = "0.00";
            Tax_box.Text = "0.00";
            Sss_loan.Text = "0.00";
            Pagibig_loan.Text = "0.00";
            Faculty_Savings_deposit.Text = "0.00";
            Faculty_savings_loan.Text = "0.00";
            Others_other_deduc.Text = "0.00";
            Others_combobox.Text = "Select other deduction";
            Others_combobox.Items.Add("Other 1");
            Others_combobox.Items.Add("Other 2");
            Others_combobox.Items.Add("Other 3");
            Others_combobox.Items.Add("Other 4");
            pic_path_textbox.Hide();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            //Codes for putting data from textboxes to variables
            sss_contrib = Convert.ToDouble(Sss_contri_box.Text);
            pagibig_contrib = Convert.ToDouble(Pagibig_contri_box.Text);
            philhealth_contrib = Convert.ToDouble(Phil_health_contri_box);
            tax_contrib = Convert.ToDouble(Tax_box.Text);
            sss_loan = Convert.ToDouble(Sss_loan.Text);
            pagibig_loan = Convert.ToDouble(Pagibig_loan.Text);
            salary_loan = Convert.ToDouble(Salary_loan.Text);
            faculty_savings_loan = Convert.ToDouble(Faculty_savings_loan.Text);
            salary_savings = Convert.ToDouble(Faculty_Savings_deposit.Text);
            other_deduction = Convert.ToDouble(Others_other_deduc.Text);

            //Formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_savings_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            //Codes for converting numeric data to string type for display
            Total_deductions.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            Net_income.Text = netincome.ToString("n");
        }

        private void Others_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void total_other_income_pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num_hrs_basic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
