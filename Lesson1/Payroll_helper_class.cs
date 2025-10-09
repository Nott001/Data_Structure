using System;
using System.Windows.Forms;
using System.Drawing;

namespace Lesson2
{
    public class Payroll_helper_class
    {
        // Fields and Properties
        public double BasicIncome { get; private set; }
        public double HonorariumIncome { get; private set; }
        public double OtherIncome { get; private set; }
        public double GrossIncome { get; private set; }
        public double TotalContrib { get; private set; }
        public double TotalLoan { get; private set; }
        public double TotalDeduction { get; private set; }
        public double NetIncome { get; private set; }
        public string PicturePath { get; private set; }

        // ---------- BASIC HELPERS ----------
        public double GetValue(TextBox box)
        {
            double.TryParse(box.Text, out double val);
            return val;
        }

        public void SetValue(TextBox box, double value)
        {
            box.Text = value.ToString("n");
        }

        // ---------- INCOME COMPUTATION ----------
        public void ComputeBasicIncome(TextBox hrsBox, TextBox rateBox, TextBox outputBox)
        {
            if (double.TryParse(hrsBox.Text, out double hrs))
            {
                BasicIncome = hrs * GetValue(rateBox);
                SetValue(outputBox, BasicIncome);
            }
        }

        public void ComputeHonorarium(TextBox hrsBox, TextBox rateBox, TextBox outputBox)
        {
            if (double.TryParse(hrsBox.Text, out double hrs))
            {
                HonorariumIncome = hrs * GetValue(rateBox);
                SetValue(outputBox, HonorariumIncome);
            }
        }

        public void ComputeOtherIncome(TextBox hrsBox, TextBox rateBox, TextBox outputBox, TextBox grossBox)
        {
            try
            {
                OtherIncome = GetValue(hrsBox) * GetValue(rateBox);
                SetValue(outputBox, OtherIncome);

                GrossIncome = BasicIncome + HonorariumIncome + OtherIncome;
                SetValue(grossBox, GrossIncome);
            }
            catch
            {
                MessageBox.Show("Invalid data entry");
                hrsBox.Clear();
                hrsBox.Focus();
            }
        }

        // ---------- CONTRIBUTION COMPUTATION ----------
        public void UpdateContributions(double gross, TextBox sssBox, TextBox pagibigBox, TextBox philBox, TextBox taxBox)
        {
            // Simplified PhilHealth range logic
            double philhealth = Math.Min(Math.Max((gross / 10000) * 137.5, 137.5), 550.0);
            SetValue(philBox, philhealth);

            // SSS & Pagibig simplified
            SetValue(pagibigBox, 100);
            SetValue(sssBox, Math.Min((gross / 1000) * 36.3, 581.3));

            // Simplified tax
            double annual = gross * 24;
            double tax = 0;
            if (annual <= 250000) tax = 0;
            else if (annual <= 400000) tax = ((annual - 250000) * 0.2) / 24;
            else if (annual <= 800000) tax = ((annual - 400000) * 0.25 + 30000) / 24;
            else if (annual <= 2000000) tax = ((annual - 800000) * 0.3 + 130000) / 24;
            else tax = ((annual - 8000000) * 0.35 + 2410000) / 24;

            SetValue(taxBox, tax);
        }

        // ---------- DEDUCTION COMPUTATION ----------
        public void ComputeDeductions(
            TextBox sss, TextBox pagibig, TextBox phil, TextBox tax,
            TextBox sssLoan, TextBox pagibigLoan, TextBox salaryLoan, TextBox facultyLoan, TextBox facultyDep, TextBox others,
            TextBox totalDeductionsBox, TextBox netBox)
        {
            TotalContrib = GetValue(sss) + GetValue(pagibig) + GetValue(phil) + GetValue(tax);
            TotalLoan = GetValue(sssLoan) + GetValue(pagibigLoan) + GetValue(salaryLoan) + GetValue(facultyLoan) +
                        GetValue(facultyDep) + GetValue(others);

            TotalDeduction = TotalContrib + TotalLoan;
            SetValue(totalDeductionsBox, TotalDeduction);

            NetIncome = GrossIncome - TotalDeduction;
            SetValue(netBox, NetIncome);
        }

        // ---------- PAYSLIP PREVIEW ----------
        public void PreviewPayslip(ListBox listbox, TextBox empNum, TextBox first, TextBox middle, TextBox last, TextBox status,
                                   DateTimePicker date, TextBox gross, TextBox deductions, TextBox net)
        {
            listbox.Items.Clear();
            listbox.Items.Add($"Employee Number: {empNum.Text}");
            listbox.Items.Add($"Name: {first.Text} {middle.Text} {last.Text}");
            listbox.Items.Add($"Status: {status.Text}");
            listbox.Items.Add($"Pay Date: {date.Text}");
            listbox.Items.Add("--------------------------------------------------");
            listbox.Items.Add($"Gross Income: P{gross.Text}");
            listbox.Items.Add($"Total Deductions: P{deductions.Text}");
            listbox.Items.Add($"Net Income: P{net.Text}");
        }

        // ---------- CLEARING & EXIT ----------
        public void ClearAllTextboxes(Form form)
        {
            foreach (Control c in form.Controls)
                if (c is TextBox) ((TextBox)c).Clear();
        }

        public void ExitApp(Form form)
        {
            form.Close();
        }

        // ---------- IMAGE HANDLING ----------
        public void BrowseImage(PictureBox pictureBox, TextBox pathBox)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif";
                ofd.Title = "Select Employee Picture";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PicturePath = ofd.FileName;
                    pathBox.Text = PicturePath;
                    pictureBox.Image = Image.FromFile(PicturePath);
                }
            }
        }


    }
}
