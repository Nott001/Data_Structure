using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Payroll_shortened : Form
    {

        Payroll_helper_class helper = new Payroll_helper_class();
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();

        public Payroll_shortened()
        {
            payrol_db_connect.payrol_connString();
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

            // Disable employee info (from registration page)
            middle_name_box.Enabled = false;
            surname_box.Enabled = false;
            emp_status_box.Enabled = false;
            department_box.Enabled = false;
            designation_box.Enabled = false;   // position
            civil_stat_box.Enabled = false;
            num_dependents_box.Enabled = false;
            dateTimePicker1.Enabled = false;    // paydate (auto-set)

            // Disable computed payroll boxes
            Income_per_cutoff.Enabled = false;
            Total_honor_pay_box.Enabled = false;
            total_other_income_pay_box.Enabled = false;
            Gross_income_box.Enabled = false;
            Total_deductions_box.Enabled = false;
            Net_income_box.Enabled = false;

            // Defaults
            Sss_contri_box.Text = "0.00";
            Pagibig_contri_box.Text = "0.00";
            Phil_health_contri_box.Text = "0.00";
            Tax_box.Text = "0.00";

            dateTimePicker1.Value = DateTime.Now;

            // Set default values
            string[] defaultBoxes = { "Sss_contri_box", "Pagibig_contri_box", "Phil_health_contri_box", "Tax_box",
                                      "Sss_loan_box", "Pagibig_loan_box", "faculty_savings_dep_box",
                                      "fac_savings_loan_box", "salary_loan_box", "Others_other_deduc_box" };

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

        private void new_button_Click(object sender, EventArgs e)
        {
            helper.ClearAllTextboxes(this);
            emp_num_box.Focus();

            Sss_contri_box.Text = "0.00";
            Pagibig_contri_box.Text = "0.00";
            Phil_health_contri_box.Text = "0.00";
            Tax_box.Text = "0.00";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            helper.ClearAllTextboxes(this);
            emp_num_box.Focus();

            Sss_contri_box.Text = "0.00";
            Pagibig_contri_box.Text = "0.00";
            Phil_health_contri_box.Text = "0.00";
            Tax_box.Text = "0.00";
        }



        // Browse image
        private void browse_button_Click(object sender, EventArgs e)
        {
            helper.BrowseImage(pictureBox1, pic_path_textbox);
        }

        private void exit_button_Click(object sender, EventArgs e) => helper.ExitApp(this);

        private void print_payslip_button_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                // ================= EMPLOYEE INFO =================
                payrol_db_connect.payrol_sql =
                    "SELECT emp_fname, emp_mname, emp_surname, emp_work_status, emp_department, " +
                    "position, emp_status, emp_no_of_dependents " +
                    "FROM pos_empRegTbl WHERE emp_id = '" + emp_num_box.Text + "'";

                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqldataadapterSelect();
                payrol_db_connect.payrol_sqldatasetSELECT();

                if (payrol_db_connect.payrol_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Employee not found.");
                    return;
                }

                DataRow emp = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0];

                first_name_box.Text = emp["emp_fname"].ToString();
                middle_name_box.Text = emp["emp_mname"].ToString();
                surname_box.Text = emp["emp_surname"].ToString();
                emp_status_box.Text = emp["emp_work_status"].ToString();
                department_box.Text = emp["emp_department"].ToString();
                designation_box.Text = emp["position"].ToString();
                civil_stat_box.Text = emp["emp_status"].ToString();
                num_dependents_box.Text = emp["emp_no_of_dependents"].ToString();

                // ================= PAYROLL INFO =================
                payrol_db_connect.payrol_sql =
                    "SELECT * FROM payrollTbl WHERE emp_id = '" + emp_num_box.Text + "'";
                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqldataadapterSelect();
                payrol_db_connect.payrol_sqldatasetSELECT();

                if (payrol_db_connect.payrol_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow pay = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0];

                    rate_7_hr.Text = pay["basic_rate_hr"].ToString();
                    Num_hrs_basic.Text = pay["basic_no_of_hrs_cutoff"].ToString();
                    Income_per_cutoff.Text = pay["basic_income_per_cutoff"].ToString();

                    Rate_hr_honorarium_box.Text = pay["honorarium_rate_hr"].ToString();
                    Num_hrs_honorarium_box.Text = pay["honorarium_no_of_hrs_cutoff"].ToString();
                    Total_honor_pay_box.Text = pay["honorarium_income_per_cutoff"].ToString();

                    Rate_hr_other_income_box.Text = pay["other_rate_hr"].ToString();
                    Num_hrs_other_income_box.Text = pay["other_no_of_hrs_cutoff"].ToString();
                    total_other_income_pay_box.Text = pay["other_income_per_cutoff"].ToString();

                    // ===== DEDUCTIONS =====
                    Sss_contri_box.Text = pay["sss_contrib"].ToString();
                    Phil_health_contri_box.Text = pay["philhealth_contrib"].ToString();
                    Pagibig_contri_box.Text = pay["pagibig_contrib"].ToString();
                    Tax_box.Text = pay["tax_contrib"].ToString();

                    Sss_loan_box.Text = pay["sss_loan"].ToString();
                    Pagibig_loan_box.Text = pay["pagibig_loan"].ToString();
                    faculty_savings_loan_box.Text = pay["fac_savings_loan"].ToString();
                    faculty_savings_dep_box.Text = pay["fac_savings_deposit"].ToString();
                    salary_loan_box.Text = pay["salary_loan"].ToString();
                    Others_other_deduc_box.Text = pay["other_loans"].ToString();

                    Gross_income_box.Text = pay["gross_income"].ToString();
                    Total_deductions_box.Text = pay["total_deductions"].ToString();
                    Net_income_box.Text = pay["net_income"].ToString();

                    dateTimePicker1.Value = Convert.ToDateTime(pay["pay_date"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }



        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payrol_sql =
                "INSERT INTO payrollTbl VALUES (" +
                "'" + rate_7_hr.Text + "', " +
                "'" + Num_hrs_basic.Text + "', " +
                "'" + Income_per_cutoff.Text + "', " +
                "'" + Rate_hr_honorarium_box.Text + "', " +
                "'" + Num_hrs_honorarium_box.Text + "', " +
                "'" + Total_honor_pay_box.Text + "', " +
                "'" + Rate_hr_other_income_box.Text + "', " +
                "'" + Num_hrs_other_income_box.Text + "', " +
                "'" + total_other_income_pay_box.Text + "', " +
                "'" + Sss_contri_box.Text + "', " +
                "'" + Phil_health_contri_box.Text + "', " +
                "'" + Pagibig_contri_box.Text + "', " +
                "'" + Tax_box.Text + "', " +
                "'" + Sss_loan_box.Text + "', " +
                "'" + Pagibig_loan_box.Text + "', " +
                "'" + faculty_savings_dep_box.Text + "', " +
                "'" + faculty_savings_loan_box.Text + "', " +
                "'" + salary_loan_box.Text + "', " +
                "'" + Others_other_deduc_box.Text + "', " +
                "'" + Total_deductions_box.Text + "', " +
                "'" + Gross_income_box.Text + "', " +
                "'" + Net_income_box.Text + "', " +
                "'" + emp_num_box.Text + "', " +
                "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";

                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqldataadapterInsert();

                MessageBox.Show("Payroll saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save error: " + ex.Message);
            }
        }


        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payrol_sql =
                "UPDATE payrollTbl SET " +
                "basic_rate_hr = '" + rate_7_hr.Text + "', " +
                "basic_no_of_hrs_cutoff = '" + Num_hrs_basic.Text + "', " +
                "basic_income_per_cutoff = '" + Income_per_cutoff.Text + "', " +
                "honorarium_rate_hr = '" + Rate_hr_honorarium_box.Text + "', " +
                "honorarium_no_of_hrs_cutoff = '" + Num_hrs_honorarium_box.Text + "', " +
                "honorarium_income_per_cutoff = '" + Total_honor_pay_box.Text + "', " +
                "other_rate_hr = '" + Rate_hr_other_income_box.Text + "', " +
                "other_no_of_hrs_cutoff = '" + Num_hrs_other_income_box.Text + "', " +
                "other_income_per_cutoff = '" + total_other_income_pay_box.Text + "', " +
                "sss_contrib = '" + Sss_contri_box.Text + "', " +
                "philhealth_contrib = '" + Phil_health_contri_box.Text + "', " +
                "pagibig_contrib = '" + Pagibig_contri_box.Text + "', " +
                "tax_contrib = '" + Tax_box.Text + "', " +
                "sss_loan = '" + Sss_loan_box.Text + "', " +
                "pagibig_loan = '" + Pagibig_loan_box.Text + "', " +
                "fac_savings_deposit = '" + faculty_savings_dep_box.Text + "', " +
                "fac_savings_loan = '" + faculty_savings_loan_box.Text + "', " +
                "salary_loan = '" + salary_loan_box.Text + "', " +
                "other_loans = '" + Others_other_deduc_box.Text + "', " +
                "total_deductions = '" + Total_deductions_box.Text + "', " +
                "gross_income = '" + Gross_income_box.Text + "', " +
                "net_income = '" + Net_income_box.Text + "', " +
                "pay_date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' " +
                "WHERE emp_id = '" + emp_num_box.Text + "'";

                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqldataadapterUpdate();

                MessageBox.Show("Payroll updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit error: " + ex.Message);
            }
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payrol_sql =
                    "DELETE FROM payrollTbl WHERE emp_id = '" + emp_num_box.Text + "'";

                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqldataadapterDelete();

                MessageBox.Show("Payroll deleted.");
                helper.ClearAllTextboxes(this);
                emp_num_box.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
        }

    }
}
