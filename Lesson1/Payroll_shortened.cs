using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Payroll_shortened : Form
    {

        Payroll_helper_class helper = new Payroll_helper_class();

        public Payroll_shortened()
        {
            InitializeComponent();
        }

        private void Payroll_shortened_Load(object sender, EventArgs e)
        {
            // Disable boxes
            Income_per_cutoff.Enabled = false;
            Total_honor_pay_box.Enabled = false;
            total_other_income_pay_box.Enabled = false;
            Net_income_box.Enabled = false;
            Gross_income_box.Enabled = false;
            Total_deductions_box.Enabled = false;

            // Set default values
            string[] defaultBoxes = { "Sss_contri_box", "Pagibig_contri_box", "Phil_health_contri_box", "Tax_box",
                                      "Sss_loan_box", "Pagibig_loan_box", "faculty_savings_dep_box",
                                      "faculty_savings_loan_box", "salary_loan_box", "Others_other_deduc_box" };

            foreach (Control c in this.Controls)
                if (c is TextBox && Array.Exists(defaultBoxes, name => name == c.Name))
                    ((TextBox)c).Text = "0.00";

            Others_combobox.Text = "Select other deduction";
            Others_combobox.Items.AddRange(new string[] { "Other 1", "Other 2", "Other 3", "Other 4" });
            pic_path_textbox.Hide();
        }

        // Calculate Basic Pay
        private void Num_hrs_basic_TextChanged(object sender, EventArgs e)
        {
            helper.ComputeBasicIncome(Num_hrs_basic, rate_7_hr, Income_per_cutoff);
        }

        // Calculate Honorarium
        private void Num_hrs_honorarium_box_TextChanged(object sender, EventArgs e)
        {
            helper.ComputeHonorarium(Num_hrs_honorarium_box, Rate_hr_honorarium_box, Total_honor_pay_box);
        }

        // Calculate Other Income, then Gross, then Contributions
        private void Num_hrs_other_income_box_TextChanged(object sender, EventArgs e)
        {
            helper.ComputeOtherIncome(Num_hrs_other_income_box, Rate_hr_other_income_box, total_other_income_pay_box, Gross_income_box);
            helper.UpdateContributions(helper.GrossIncome, Sss_contri_box, Pagibig_contri_box, Phil_health_contri_box, Tax_box);
        }

        // Calculate button
        private void calculate_button_Click(object sender, EventArgs e)
        {
            helper.ComputeDeductions(
    Sss_contri_box, Pagibig_contri_box, Phil_health_contri_box, Tax_box, Sss_loan_box, Pagibig_loan_box, salary_loan_box, 
    faculty_savings_loan_box, faculty_savings_dep_box, Others_other_deduc_box,Total_deductions_box, Net_income_box);
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        // Preview payslip
        private void preview_button_Click(object sender, EventArgs e)
        {
            helper.PreviewPayslip(Payslip_view_listbox, emp_num_box, first_name_box, middle_name_box, surname_box,
                                  emp_status_box, dateTimePicker1, Gross_income_box, Total_deductions_box, Net_income_box);
        }

        private void new_button_Click(object sender, EventArgs e) => helper.ClearAllTextboxes(this);
        private void cancel_button_Click(object sender, EventArgs e) => helper.ClearAllTextboxes(this);


        // Browse image
        private void browse_button_Click(object sender, EventArgs e)
        {
            helper.BrowseImage(pictureBox1, pic_path_textbox);
        }

        private void exit_button_Click(object sender, EventArgs e) => helper.ExitApp(this);

        private void print_payslip_button_Click(object sender, EventArgs e)
        {

        }
    }
}
