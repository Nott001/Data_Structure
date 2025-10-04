using System.Drawing;
using System.Windows.Forms;

namespace Lesson2
{
    partial class Activity_lesson5_Print
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.paydate_box = new System.Windows.Forms.TextBox();
            this.cut_off_box = new System.Windows.Forms.TextBox();
            this.department_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employee_name_box = new System.Windows.Forms.TextBox();
            this.emp_num_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.company_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.basic_hrs_box = new System.Windows.Forms.TextBox();
            this.basic_income_box = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.other_hrs_box = new System.Windows.Forms.TextBox();
            this.other_income_box = new System.Windows.Forms.TextBox();
            this.honorarium_hrs_box = new System.Windows.Forms.TextBox();
            this.honorarium_income_box = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.gross_income_box = new System.Windows.Forms.TextBox();
            this.tax_contri_box = new System.Windows.Forms.TextBox();
            this.sss_contri_box = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.pagibig_contri_box = new System.Windows.Forms.TextBox();
            this.philhealth_contri_box = new System.Windows.Forms.TextBox();
            this.sss_wisp_box = new System.Windows.Forms.TextBox();
            this.total_deduction_box = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.gross_box_2 = new System.Windows.Forms.TextBox();
            this.deductions_box_2 = new System.Windows.Forms.TextBox();
            this.net_income_box = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Company:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.paydate_box, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cut_off_box, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.department_box, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.employee_name_box, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.emp_num_box, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.company_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 141);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // paydate_box
            // 
            this.paydate_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paydate_box.BackColor = System.Drawing.SystemColors.Menu;
            this.paydate_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paydate_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paydate_box.Location = new System.Drawing.Point(778, 108);
            this.paydate_box.Name = "paydate_box";
            this.paydate_box.Size = new System.Drawing.Size(253, 16);
            this.paydate_box.TabIndex = 78;
            this.paydate_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cut_off_box
            // 
            this.cut_off_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cut_off_box.BackColor = System.Drawing.SystemColors.Menu;
            this.cut_off_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cut_off_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cut_off_box.Location = new System.Drawing.Point(778, 61);
            this.cut_off_box.Name = "cut_off_box";
            this.cut_off_box.Size = new System.Drawing.Size(253, 16);
            this.cut_off_box.TabIndex = 78;
            this.cut_off_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // department_box
            // 
            this.department_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.department_box.BackColor = System.Drawing.SystemColors.Menu;
            this.department_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.department_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.department_box.Location = new System.Drawing.Point(778, 15);
            this.department_box.Name = "department_box";
            this.department_box.Size = new System.Drawing.Size(253, 16);
            this.department_box.TabIndex = 78;
            this.department_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(520, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pay Period:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(520, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cut-Off:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(520, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employee_name_box
            // 
            this.employee_name_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_name_box.BackColor = System.Drawing.SystemColors.Menu;
            this.employee_name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employee_name_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.employee_name_box.Location = new System.Drawing.Point(262, 108);
            this.employee_name_box.Name = "employee_name_box";
            this.employee_name_box.Size = new System.Drawing.Size(251, 16);
            this.employee_name_box.TabIndex = 78;
            this.employee_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emp_num_box
            // 
            this.emp_num_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emp_num_box.BackColor = System.Drawing.SystemColors.Menu;
            this.emp_num_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emp_num_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emp_num_box.Location = new System.Drawing.Point(262, 61);
            this.emp_num_box.Name = "emp_num_box";
            this.emp_num_box.Size = new System.Drawing.Size(251, 16);
            this.emp_num_box.TabIndex = 78;
            this.emp_num_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // company_box
            // 
            this.company_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.company_box.BackColor = System.Drawing.SystemColors.Menu;
            this.company_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.company_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.company_box.Location = new System.Drawing.Point(262, 15);
            this.company_box.Name = "company_box";
            this.company_box.Size = new System.Drawing.Size(251, 16);
            this.company_box.TabIndex = 77;
            this.company_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(159, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "EARNINGS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(27, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Basic Pay:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(27, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Overtime:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(27, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Honorarium:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(27, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Honorarium Adjustment:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.Location = new System.Drawing.Point(27, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Substitution (LAB):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(27, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tardy:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(27, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "EARNINGS:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(172, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "Day/Hrs";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(238, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "Taxable";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(301, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 15);
            this.label17.TabIndex = 15;
            this.label17.Text = "Non Taxable";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(509, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 19);
            this.label18.TabIndex = 16;
            this.label18.Text = "DEDUCTIONS";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label19.Location = new System.Drawing.Point(423, 278);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 15);
            this.label19.TabIndex = 17;
            this.label19.Text = "Withholding Tax:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label20.Location = new System.Drawing.Point(423, 302);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 15);
            this.label20.TabIndex = 18;
            this.label20.Text = "SSS - Contribution:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label21.Location = new System.Drawing.Point(423, 328);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 15);
            this.label21.TabIndex = 19;
            this.label21.Text = "HDMF - Contribution:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label22.Location = new System.Drawing.Point(423, 356);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 15);
            this.label22.TabIndex = 20;
            this.label22.Text = "Philhealth - Contribution:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label23.Location = new System.Drawing.Point(423, 386);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 15);
            this.label23.TabIndex = 21;
            this.label23.Text = "SSS WISP - Contribution";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(423, 448);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 15);
            this.label24.TabIndex = 22;
            this.label24.Text = "DEDUCTIONS:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(795, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(230, 19);
            this.label25.TabIndex = 23;
            this.label25.Text = "OVERTIME / NIGHT DIFFERENTIAL";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(746, 448);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 15);
            this.label26.TabIndex = 24;
            this.label26.Text = "OVERTIME:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // basic_hrs_box
            // 
            this.basic_hrs_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.basic_hrs_box.BackColor = System.Drawing.SystemColors.Control;
            this.basic_hrs_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.basic_hrs_box.Location = new System.Drawing.Point(172, 268);
            this.basic_hrs_box.Name = "basic_hrs_box";
            this.basic_hrs_box.Size = new System.Drawing.Size(61, 22);
            this.basic_hrs_box.TabIndex = 25;
            // 
            // basic_income_box
            // 
            this.basic_income_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.basic_income_box.BackColor = System.Drawing.SystemColors.Control;
            this.basic_income_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.basic_income_box.Location = new System.Drawing.Point(238, 268);
            this.basic_income_box.Name = "basic_income_box";
            this.basic_income_box.Size = new System.Drawing.Size(59, 22);
            this.basic_income_box.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox1.Location = new System.Drawing.Point(301, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 22);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox2.Location = new System.Drawing.Point(301, 292);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 22);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox3.Location = new System.Drawing.Point(301, 316);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 22);
            this.textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox4.Location = new System.Drawing.Point(301, 346);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(59, 22);
            this.textBox4.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox5.Location = new System.Drawing.Point(301, 375);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(59, 22);
            this.textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox6.Location = new System.Drawing.Point(301, 401);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(59, 22);
            this.textBox6.TabIndex = 32;
            // 
            // other_hrs_box
            // 
            this.other_hrs_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.other_hrs_box.BackColor = System.Drawing.SystemColors.Control;
            this.other_hrs_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.other_hrs_box.Location = new System.Drawing.Point(172, 292);
            this.other_hrs_box.Name = "other_hrs_box";
            this.other_hrs_box.Size = new System.Drawing.Size(61, 22);
            this.other_hrs_box.TabIndex = 33;
            // 
            // other_income_box
            // 
            this.other_income_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.other_income_box.BackColor = System.Drawing.SystemColors.Control;
            this.other_income_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.other_income_box.Location = new System.Drawing.Point(238, 292);
            this.other_income_box.Name = "other_income_box";
            this.other_income_box.Size = new System.Drawing.Size(58, 22);
            this.other_income_box.TabIndex = 34;
            // 
            // honorarium_hrs_box
            // 
            this.honorarium_hrs_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.honorarium_hrs_box.BackColor = System.Drawing.SystemColors.Control;
            this.honorarium_hrs_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.honorarium_hrs_box.Location = new System.Drawing.Point(172, 318);
            this.honorarium_hrs_box.Name = "honorarium_hrs_box";
            this.honorarium_hrs_box.Size = new System.Drawing.Size(61, 22);
            this.honorarium_hrs_box.TabIndex = 35;
            // 
            // honorarium_income_box
            // 
            this.honorarium_income_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.honorarium_income_box.BackColor = System.Drawing.SystemColors.Control;
            this.honorarium_income_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.honorarium_income_box.Location = new System.Drawing.Point(238, 318);
            this.honorarium_income_box.Name = "honorarium_income_box";
            this.honorarium_income_box.Size = new System.Drawing.Size(59, 22);
            this.honorarium_income_box.TabIndex = 36;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox7.Location = new System.Drawing.Point(172, 346);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(61, 22);
            this.textBox7.TabIndex = 37;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox8.Location = new System.Drawing.Point(238, 346);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(59, 22);
            this.textBox8.TabIndex = 38;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox9.Location = new System.Drawing.Point(172, 375);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(61, 22);
            this.textBox9.TabIndex = 39;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox10.Location = new System.Drawing.Point(237, 375);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(59, 22);
            this.textBox10.TabIndex = 40;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox11.BackColor = System.Drawing.SystemColors.Control;
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox11.Location = new System.Drawing.Point(237, 401);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(59, 22);
            this.textBox11.TabIndex = 41;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox12.Location = new System.Drawing.Point(172, 401);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(61, 22);
            this.textBox12.TabIndex = 42;
            // 
            // gross_income_box
            // 
            this.gross_income_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gross_income_box.BackColor = System.Drawing.SystemColors.Control;
            this.gross_income_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gross_income_box.Location = new System.Drawing.Point(172, 442);
            this.gross_income_box.Name = "gross_income_box";
            this.gross_income_box.Size = new System.Drawing.Size(187, 22);
            this.gross_income_box.TabIndex = 52;
            // 
            // tax_contri_box
            // 
            this.tax_contri_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tax_contri_box.BackColor = System.Drawing.SystemColors.Control;
            this.tax_contri_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tax_contri_box.Location = new System.Drawing.Point(567, 268);
            this.tax_contri_box.Name = "tax_contri_box";
            this.tax_contri_box.Size = new System.Drawing.Size(119, 22);
            this.tax_contri_box.TabIndex = 64;
            // 
            // sss_contri_box
            // 
            this.sss_contri_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sss_contri_box.BackColor = System.Drawing.SystemColors.Control;
            this.sss_contri_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sss_contri_box.Location = new System.Drawing.Point(567, 292);
            this.sss_contri_box.Name = "sss_contri_box";
            this.sss_contri_box.Size = new System.Drawing.Size(119, 22);
            this.sss_contri_box.TabIndex = 65;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(597, 239);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 15);
            this.label27.TabIndex = 66;
            this.label27.Text = "Amount";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagibig_contri_box
            // 
            this.pagibig_contri_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pagibig_contri_box.BackColor = System.Drawing.SystemColors.Control;
            this.pagibig_contri_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.pagibig_contri_box.Location = new System.Drawing.Point(567, 318);
            this.pagibig_contri_box.Name = "pagibig_contri_box";
            this.pagibig_contri_box.Size = new System.Drawing.Size(119, 22);
            this.pagibig_contri_box.TabIndex = 67;
            // 
            // philhealth_contri_box
            // 
            this.philhealth_contri_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.philhealth_contri_box.BackColor = System.Drawing.SystemColors.Control;
            this.philhealth_contri_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.philhealth_contri_box.Location = new System.Drawing.Point(567, 346);
            this.philhealth_contri_box.Name = "philhealth_contri_box";
            this.philhealth_contri_box.Size = new System.Drawing.Size(119, 22);
            this.philhealth_contri_box.TabIndex = 68;
            // 
            // sss_wisp_box
            // 
            this.sss_wisp_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sss_wisp_box.BackColor = System.Drawing.SystemColors.Control;
            this.sss_wisp_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sss_wisp_box.Location = new System.Drawing.Point(567, 375);
            this.sss_wisp_box.Name = "sss_wisp_box";
            this.sss_wisp_box.Size = new System.Drawing.Size(119, 22);
            this.sss_wisp_box.TabIndex = 69;
            // 
            // total_deduction_box
            // 
            this.total_deduction_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.total_deduction_box.BackColor = System.Drawing.SystemColors.Control;
            this.total_deduction_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.total_deduction_box.Location = new System.Drawing.Point(567, 442);
            this.total_deduction_box.Name = "total_deduction_box";
            this.total_deduction_box.Size = new System.Drawing.Size(119, 22);
            this.total_deduction_box.TabIndex = 71;
            // 
            // textBox13
            // 
            this.textBox13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
            this.textBox13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox13.Location = new System.Drawing.Point(854, 442);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(131, 22);
            this.textBox13.TabIndex = 72;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(746, 476);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(113, 15);
            this.label28.TabIndex = 73;
            this.label28.Text = "GROSS EARNINGS:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(746, 504);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 15);
            this.label29.TabIndex = 74;
            this.label29.Text = "DEDUCTIONS:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label30.Location = new System.Drawing.Point(746, 531);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 15);
            this.label30.TabIndex = 75;
            this.label30.Text = "NET PAY:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gross_box_2
            // 
            this.gross_box_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gross_box_2.BackColor = System.Drawing.SystemColors.Control;
            this.gross_box_2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gross_box_2.Location = new System.Drawing.Point(854, 470);
            this.gross_box_2.Name = "gross_box_2";
            this.gross_box_2.Size = new System.Drawing.Size(131, 22);
            this.gross_box_2.TabIndex = 76;
            // 
            // deductions_box_2
            // 
            this.deductions_box_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deductions_box_2.BackColor = System.Drawing.SystemColors.Control;
            this.deductions_box_2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.deductions_box_2.Location = new System.Drawing.Point(854, 498);
            this.deductions_box_2.Name = "deductions_box_2";
            this.deductions_box_2.Size = new System.Drawing.Size(131, 22);
            this.deductions_box_2.TabIndex = 77;
            // 
            // net_income_box
            // 
            this.net_income_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.net_income_box.BackColor = System.Drawing.SystemColors.Control;
            this.net_income_box.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.net_income_box.Location = new System.Drawing.Point(854, 525);
            this.net_income_box.Name = "net_income_box";
            this.net_income_box.Size = new System.Drawing.Size(131, 22);
            this.net_income_box.TabIndex = 78;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(-77, 177);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(1286, 2);
            this.label31.TabIndex = 79;
            this.label31.Text = "a";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label32.Location = new System.Drawing.Point(-77, 222);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(1286, 2);
            this.label32.TabIndex = 80;
            this.label32.Text = "a";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label33.Location = new System.Drawing.Point(-77, 432);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(1286, 2);
            this.label33.TabIndex = 81;
            this.label33.Text = "a";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label34.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label34.Location = new System.Drawing.Point(51, 185);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(283, 30);
            this.label34.TabIndex = 82;
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label35.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label35.Location = new System.Drawing.Point(423, 185);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(257, 30);
            this.label35.TabIndex = 83;
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label36.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label36.Location = new System.Drawing.Point(762, 185);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(257, 30);
            this.label36.TabIndex = 84;
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Activity_lesson5_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 558);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.net_income_box);
            this.Controls.Add(this.deductions_box_2);
            this.Controls.Add(this.gross_box_2);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.total_deduction_box);
            this.Controls.Add(this.sss_wisp_box);
            this.Controls.Add(this.philhealth_contri_box);
            this.Controls.Add(this.pagibig_contri_box);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.sss_contri_box);
            this.Controls.Add(this.tax_contri_box);
            this.Controls.Add(this.gross_income_box);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.honorarium_income_box);
            this.Controls.Add(this.honorarium_hrs_box);
            this.Controls.Add(this.other_income_box);
            this.Controls.Add(this.other_hrs_box);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.basic_income_box);
            this.Controls.Add(this.basic_hrs_box);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Activity_lesson5_Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Activity_save_print";
            this.Load += new System.EventHandler(this.Activity_save_print_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        public TextBox company_box;
        public TextBox paydate_box;
        public TextBox cut_off_box;
        public TextBox department_box;
        private Label label6;
        private Label label5;
        private Label label4;
        public TextBox employee_name_box;
        public TextBox emp_num_box;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        public TextBox basic_hrs_box;
        public TextBox basic_income_box;
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
        public TextBox textBox4;
        public TextBox textBox5;
        public TextBox textBox6;
        public TextBox other_hrs_box;
        public TextBox other_income_box;
        public TextBox honorarium_hrs_box;
        public TextBox honorarium_income_box;
        public TextBox textBox7;
        public TextBox textBox8;
        public TextBox textBox9;
        public TextBox textBox10;
        public TextBox textBox11;
        public TextBox textBox12;
        public TextBox gross_income_box;
        public TextBox tax_contri_box;
        public TextBox sss_contri_box;
        private Label label27;
        public TextBox pagibig_contri_box;
        public TextBox philhealth_contri_box;
        public TextBox sss_wisp_box;
        public TextBox total_deduction_box;
        public TextBox textBox13;
        private Label label28;
        private Label label29;
        private Label label30;
        public TextBox gross_box_2;
        public TextBox deductions_box_2;
        public TextBox net_income_box;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
    }
}