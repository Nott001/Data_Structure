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
        Double hono_rate = 0.00;
        Double hono_numhrs = 0.00;
        Double other_rate = 0.00;
        Double other_numhrs = 0.00;
        Double other_netincome = 0.00;

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
            Net_income_box.Enabled = false;
            Gross_income_box.Enabled = false;
            Total_deductions_box.Enabled = false;
            Sss_contri_box.Text = "0.00";
            Pagibig_contri_box.Text = "0.00";
            Phil_health_contri_box.Text = "0.00";
            Tax_box.Text = "0.00";
            Sss_loan_box.Text = "0.00";
            Pagibig_loan_box.Text = "0.00";
            faculty_savings_dep_box.Text = "0.00";
            faculty_savings_loan_box.Text = "0.00";
            salary_loan_box.Text = "0.00";
            Others_other_deduc_box.Text = "0.00";
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
            philhealth_contrib = Convert.ToDouble(Phil_health_contri_box.Text);
            tax_contrib = Convert.ToDouble(Tax_box.Text);
            sss_loan = Convert.ToDouble(Sss_loan_box.Text);
            pagibig_loan = Convert.ToDouble(Pagibig_loan_box.Text);
            salary_loan = Convert.ToDouble(salary_loan_box.Text);
            faculty_savings_loan = Convert.ToDouble(faculty_savings_loan_box.Text);
            salary_savings = Convert.ToDouble(faculty_savings_dep_box.Text);
            other_deduction = Convert.ToDouble(Others_other_deduc_box.Text);

            //Formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_savings_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            //Codes for converting numeric data to string type for display
            Total_deductions_box.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            Net_income_box.Text = netincome.ToString("n");
        }

        private void Others_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void total_other_income_pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num_hrs_basic_TextChanged(object sender, EventArgs e)
        {
            //Calculating for basic income per cut off
            basic_numhrs = Double.Parse(Num_hrs_basic.Text);
            basic_rate = Convert.ToDouble(rate_7_hr.Text);
            basic_netincome = basic_numhrs * basic_rate;
            Income_per_cutoff.Text = basic_netincome.ToString("n");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void print_payslip_button_Click(object sender, EventArgs e)
        {
            //Codes to show items on the listbox on a seperate form
            Activity5_lesson3_Print print = new Activity5_lesson3_Print();
            print.Payslip_view_listbox.Items.AddRange(this.Payslip_view_listbox.Items);
            print.Show();

        }

        private void preview_button_Click(object sender, EventArgs e)
        {
            //Codes to add items into the payslip
            Payslip_view_listbox.Items.Add("Employee Number: " + " " + emp_num_box.Text);
            Payslip_view_listbox.Items.Add("Firstname: " + " " + first_name_box.Text);
            Payslip_view_listbox.Items.Add("Middlename: " + " " + middle_name_box.Text);
            Payslip_view_listbox.Items.Add("Surname: " + " " + surname_box.Text);
            Payslip_view_listbox.Items.Add("Designation: " + " " + designation_box);
            Payslip_view_listbox.Items.Add("Employee Status" + " " + emp_status_box.Text);
            Payslip_view_listbox.Items.Add("Pay Date: " + " " + dateTimePicker1.Text);
            Payslip_view_listbox.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------");
            Payslip_view_listbox.Items.Add("BP Num. of Hrs.: " + "P" + Num_hrs_basic.Text);
            Payslip_view_listbox.Items.Add("BP Rate / HR.: " + "P" + rate_7_hr.Text);
            Payslip_view_listbox.Items.Add("Basic Pay Income: " + "P" + Income_per_cutoff.Text);
            Payslip_view_listbox.Items.Add(" ");
            Payslip_view_listbox.Items.Add("HI Num. of Hrs.: " + "P" + Num_hrs_honorarium_box.Text);
            Payslip_view_listbox.Items.Add("HI Rate / Hr.: " + "P" + Rate_hr_honorarium_box);
            Payslip_view_listbox.Items.Add("Honorarium Income: " + "P" + Total_honor_pay_box.Text);
            Payslip_view_listbox.Items.Add(" ");
            Payslip_view_listbox.Items.Add("OTI Num. of Hrs.: " + "P" + Num_hrs_other_income_box.Text);
            Payslip_view_listbox.Items.Add("OTI Rate / Hr.: " + "P" + Rate_hr_honorarium_box.Text);
            Payslip_view_listbox.Items.Add("Other Income: " + "P" + total_other_income_pay_box.Text);
            Payslip_view_listbox.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------");
            Payslip_view_listbox.Items.Add("SSS Contribution: " + "P" + Sss_contri_box.Text);
            Payslip_view_listbox.Items.Add("Philhealth Contribution" + "P" + Phil_health_contri_box.Text);
            Payslip_view_listbox.Items.Add("Pagibig Contribution" + "P" + Pagibig_contri_box.Text);
            Payslip_view_listbox.Items.Add("Tax Contribution" + "P" + Tax_box.Text);
            Payslip_view_listbox.Items.Add("SSS Loan: " + "P" + Sss_loan_box.Text);
            Payslip_view_listbox.Items.Add("Pagibig Loan: " + "P" + Pagibig_loan_box.Text);
            Payslip_view_listbox.Items.Add("Faculty Savings Deposit: " + "P" + faculty_savings_dep_box.Text);
            Payslip_view_listbox.Items.Add("Faculty Savings Loan: " + "P" + faculty_savings_loan_box.Text);
            Payslip_view_listbox.Items.Add("Salary Loan: " + "P" + salary_loan_box.Text);
            Payslip_view_listbox.Items.Add("Other Loan: " + "P" + Others_other_deduc_box.Text);
            Payslip_view_listbox.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------");
            Payslip_view_listbox.Items.Add("Total deduction: " + "P" + Total_deductions_box.Text);
            Payslip_view_listbox.Items.Add("Gross Income: " + "P" + Gross_income_box.Text);
            Payslip_view_listbox.Items.Add("Net Income: " + "P" + Net_income_box.Text);

        }

        private void new_button_Click(object sender, EventArgs e)
        {
            //Clearing all textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //CLearing all textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            //Code to browse file explorer for an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif * .jpg * .png * .bmp";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            pic_path_textbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            //Code to close the porgram
            this.Close();
        }

        private void Num_hrs_honorarium_box_TextChanged(object sender, EventArgs e)
        {
            //Codes to calculate for the total honorarium pay
            hono_numhrs = Double.Parse(Num_hrs_honorarium_box.Text);
            hono_rate = Convert.ToDouble(Rate_hr_honorarium_box.Text);
            hono_netincome = hono_numhrs * hono_rate;
            Total_honor_pay_box.Text = hono_netincome.ToString("n");
        }

        private void Num_hrs_other_income_box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Codes to calculate for the total other income and gross income
                other_numhrs = Convert.ToDouble(Num_hrs_other_income_box.Text);
                other_rate = Convert.ToDouble(Rate_hr_other_income_box.Text);
                other_netincome = other_numhrs * other_rate;
                total_other_income_pay_box.Text = other_netincome.ToString("n");
                grossincome = basic_netincome + hono_netincome + other_netincome;
                Gross_income_box.Text = grossincome.ToString("n");
                Pagibig_contri_box.Text = "100.00";

                //Philhealth contribution based from the current table
                if (grossincome < 10000)
                {
                    Phil_health_contri_box.Text = "137.50";
                }
                else if (grossincome > 10000 && grossincome <= 11000)
                {
                    Phil_health_contri_box.Text = "151.25";
                }
                else if (grossincome > 11000 && grossincome <= 12000)
                {
                    Phil_health_contri_box.Text = "165.00";
                }
                else if (grossincome > 12000 && grossincome <= 13000)
                {
                    Phil_health_contri_box.Text = "178.75";
                }
                else if (grossincome > 13000 && grossincome <= 14000)
                {
                    Phil_health_contri_box.Text = "192.50";
                }
                else if (grossincome > 14000 && grossincome <= 15000)
                {
                    Phil_health_contri_box.Text = "206.25";
                }
                else if (grossincome > 15000 && grossincome <= 16000)
                {
                    Phil_health_contri_box.Text = "220.00";
                }
                else if (grossincome > 16000 && grossincome <= 17000)
                {
                    Phil_health_contri_box.Text = "233.75";
                }
                else if (grossincome > 17000 && grossincome <= 18000)
                {
                    Phil_health_contri_box.Text = "247.50";
                }
                else if (grossincome > 18000 && grossincome <= 19000)
                {
                    Phil_health_contri_box.Text = "261.25";
                }
                else if (grossincome > 19000 && grossincome <= 20000)
                {
                    Phil_health_contri_box.Text = "275.25";
                }
                else if (grossincome > 20000 && grossincome <= 21000)
                {
                    Phil_health_contri_box.Text = "288.75";
                }
                else if (grossincome > 21000 && grossincome <= 22000)
                {
                    Phil_health_contri_box.Text = "302.50";
                }
                else if (grossincome > 22000 && grossincome <= 23000)
                {
                    Phil_health_contri_box.Text = "316.25";
                }
                else if (grossincome > 23000 && grossincome <= 24000)
                {
                    Phil_health_contri_box.Text = "330.00";
                }
                else if (grossincome > 24000 && grossincome <= 25000)
                {
                    Phil_health_contri_box.Text = "343.75";
                }
                else if (grossincome > 25000 && grossincome <= 26000)
                {
                    Phil_health_contri_box.Text = "357.50";
                }
                else if (grossincome > 26000 && grossincome <= 27000)
                {
                    Phil_health_contri_box.Text = "371.25";
                }
                else if (grossincome > 27000 && grossincome <= 28000)
                {
                    Phil_health_contri_box.Text = "385.00";
                }
                else if (grossincome > 28000 && grossincome <= 29000)
                {
                    Phil_health_contri_box.Text = "398.75";
                }
                else if (grossincome > 29000 && grossincome <= 30000)
                {
                    Phil_health_contri_box.Text = "412.50";
                }
                else if (grossincome > 30000 && grossincome <= 31000)
                {
                    Phil_health_contri_box.Text = "426.25";
                }
                else if (grossincome > 31000 && grossincome <= 32000)
                {
                    Phil_health_contri_box.Text = "440.00";
                }
                else if (grossincome > 32000 && grossincome <= 33000)
                {
                    Phil_health_contri_box.Text = "453.75";
                }
                else if (grossincome > 33000 && grossincome <= 34000)
                {
                    Phil_health_contri_box.Text = "467.50";
                }
                else if (grossincome > 34000 && grossincome <= 35000)
                {
                    Phil_health_contri_box.Text = "481.25";
                }
                else if (grossincome > 35000 && grossincome <= 36000)
                {
                    Phil_health_contri_box.Text = "495.00";
                }
                else if (grossincome > 36000 && grossincome <= 37000)
                {
                    Phil_health_contri_box.Text = "508.75";
                }
                else if (grossincome > 37000 && grossincome <= 38000)
                {
                    Phil_health_contri_box.Text = "522.50";
                }
                else if (grossincome > 38000 && grossincome <= 39000)
                {
                    Phil_health_contri_box.Text = "536.25";
                }
                else if (grossincome > 39000 && grossincome <= 33999.99)
                {
                    Phil_health_contri_box.Text = "543.13";
                }
                else
                    Phil_health_contri_box.Text = "550.00";

                //SSS contribution based on the current table from SSS
                if (grossincome < 1000.00)
                {
                    Sss_contri_box.Text = "0.00";
                }
                else if (grossincome >= 1000.00 && grossincome <= 1249.99)
                {
                    Sss_contri_box.Text = "36.30";
                }
                else if (grossincome >= 1250.00 && grossincome <= 1749.99)
                {
                    Sss_contri_box.Text = "54.50";
                }
                else if (grossincome >= 1750.00 && grossincome <= 2249.99)
                {
                    Sss_contri_box.Text = "72.70";
                }
                else if (grossincome >= 2250.00 && grossincome <= 2749.99)
                {
                    Sss_contri_box.Text = "90.80";
                }
                else if (grossincome >= 2750.00 && grossincome <= 3249.99)
                {
                    Sss_contri_box.Text = "109.00";
                }
                else if (grossincome >= 3250.00 && grossincome <= 3749.99)
                {
                    Sss_contri_box.Text = "127.20";
                }
                else if (grossincome >= 3750.00 && grossincome <= 4249.99)
                {
                    Sss_contri_box.Text = "145.30";
                }
                else if (grossincome >= 4250.00 && grossincome <= 4749.99)
                {
                    Sss_contri_box.Text = "163.50";
                }
                else if (grossincome >= 4750.00 && grossincome <= 5249.99)
                {
                    Sss_contri_box.Text = "181.70";
                }
                else if (grossincome >= 5250.00 && grossincome <= 5749.99)
                {
                    Sss_contri_box.Text = "199.80";
                }
                else if (grossincome >= 5750.00 && grossincome <= 6249.99)
                {
                    Sss_contri_box.Text = "218.00";
                }
                else if (grossincome >= 6250.00 && grossincome <= 6749.99)
                {
                    Sss_contri_box.Text = "236.20";
                }
                else if (grossincome >= 6750.00 && grossincome <= 7249.99)
                {
                    Sss_contri_box.Text = "254.30";
                }
                else if (grossincome >= 7250.00 && grossincome <= 7749.99)
                {
                    Sss_contri_box.Text = "272.50";
                }
                else if (grossincome >= 7750.00 && grossincome <= 8249.99)
                {
                    Sss_contri_box.Text = "290.70";
                }
                else if (grossincome >= 8250.00 && grossincome <= 8749.99)
                {
                    Sss_contri_box.Text = "308.80";
                }
                else if (grossincome >= 8750.00 && grossincome <= 9249.99)
                {
                    Sss_contri_box.Text = "327.00";
                }
                else if (grossincome >= 9250.00 && grossincome <= 9749.99)
                {
                    Sss_contri_box.Text = "345.20";
                }
                else if (grossincome >= 9750.00 && grossincome <= 10249.99)
                {
                    Sss_contri_box.Text = "363.30";
                }
                else if (grossincome >= 10250.00 && grossincome <= 10749.99)
                {
                    Sss_contri_box.Text = "381.50";
                }
                else if (grossincome >= 10750.00 && grossincome <= 11249.99)
                {
                    Sss_contri_box.Text = "399.70";
                }
                else if (grossincome >= 11250.00 && grossincome <= 11749.99)
                {
                    Sss_contri_box.Text = "417.80";
                }
                else if (grossincome >= 11750.00 && grossincome <= 12249.99)
                {
                    Sss_contri_box.Text = "436.00";
                }
                else if (grossincome >= 12250.00 && grossincome <= 12749.99)
                {
                    Sss_contri_box.Text = "454.20";
                }
                else if (grossincome >= 12750.00 && grossincome <= 13249.99)
                {
                    Sss_contri_box.Text = "472.30";
                }
                else if (grossincome >= 13250.00 && grossincome <= 13749.99)
                {
                    Sss_contri_box.Text = "490.50";
                }
                else if (grossincome >= 13750.00 && grossincome <= 14249.99)
                {
                    Sss_contri_box.Text = "508.70";
                }
                else if (grossincome >= 14250.00 && grossincome <= 14749.99)
                {
                    Sss_contri_box.Text = "526.80";
                }
                else if (grossincome >= 14750.00 && grossincome <= 15249.99)
                {
                    Sss_contri_box.Text = "545.00";
                }
                else if (grossincome >= 15250.00 && grossincome <= 15749.99)
                {
                    Sss_contri_box.Text = "563.20";
                }
                else if (grossincome >= 15750.00 && grossincome <= 16249.99)
                {
                    Sss_contri_box.Text = "581.30";
                }
                else // For grossincome greater than 16249.99
                {
                    Sss_contri_box.Text = "581.30";
                }

                //tax contribution per month based on the new table of TAX 2019
                if (grossincome < (250000 / 24)) // grossincome < 10416.67
                {
                    Tax_box.Text = "0.00";
                }
                else if (grossincome > 10416.67 && grossincome <= 16666.67)
                {
                    // Taxable income is (grossincome * 24) - 250000.00 (Annual Exemption)
                    tax_contrib = ((((grossincome * 24) - 250000) * 0.20) / 24);
                    Tax_box.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome <= 33333.33)
                {
                    // P30,000 + 25% of excess over P400,000 (Annual)
                    tax_contrib = (((((grossincome * 24) - 400000) * 0.25) + 30000) / 24);
                    Tax_box.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 83333.33)
                {
                    // P130,000 + 30% of excess over P800,000 (Annual)
                    tax_contrib = (((((grossincome * 24) - 800000) * 0.30) + 130000) / 24);
                    Tax_box.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome <= 333333.33)
                {
                    // P490,000 + 32% of excess over P2,000,000 (Annual)
                    tax_contrib = (((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24);
                    Tax_box.Text = tax_contrib.ToString("n");
                }
                else // For grossincome > 333333.33
                {
                    // P2,410,000 + 35% of excess over P8,000,000 (Annual)
                    tax_contrib = (((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24);
                    Tax_box.Text = tax_contrib.ToString("n");
                }
            }

            catch (Exception)
            {
                // Error handling block
                MessageBox.Show("Invalid data entry");
                Num_hrs_other_income_box.Clear();
                Num_hrs_other_income_box.Focus();
            }
        }
    

        private void Rate_hr_other_income_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
