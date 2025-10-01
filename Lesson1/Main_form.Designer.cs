namespace Lesson2
{
    partial class Main_form
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
            this.cashier_strip = new System.Windows.Forms.MenuStrip();
            this.pOSCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.user_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payroll1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payroll2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashier_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashier_strip
            // 
            this.cashier_strip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cashier_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSCashierToolStripMenuItem,
            this.admin_strip,
            this.user_strip,
            this.payrollToolStripMenuItem,
            this.employeeInformationToolStripMenuItem,
            this.humanResourcesToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.cashier_strip.Location = new System.Drawing.Point(0, 0);
            this.cashier_strip.Name = "cashier_strip";
            this.cashier_strip.Size = new System.Drawing.Size(1924, 27);
            this.cashier_strip.TabIndex = 1;
            this.cashier_strip.Text = "POS Cashier";
            // 
            // pOSCashierToolStripMenuItem
            // 
            this.pOSCashierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOS1ToolStripMenuItem,
            this.pOS2ToolStripMenuItem});
            this.pOSCashierToolStripMenuItem.Name = "pOSCashierToolStripMenuItem";
            this.pOSCashierToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.pOSCashierToolStripMenuItem.Text = "POS Cashier";
            // 
            // pOS1ToolStripMenuItem
            // 
            this.pOS1ToolStripMenuItem.Name = "pOS1ToolStripMenuItem";
            this.pOS1ToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.pOS1ToolStripMenuItem.Text = "POS 1";
            this.pOS1ToolStripMenuItem.Click += new System.EventHandler(this.pOS1ToolStripMenuItem_Click);
            // 
            // pOS2ToolStripMenuItem
            // 
            this.pOS2ToolStripMenuItem.Name = "pOS2ToolStripMenuItem";
            this.pOS2ToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.pOS2ToolStripMenuItem.Text = "POS 2";
            this.pOS2ToolStripMenuItem.Click += new System.EventHandler(this.pOS2ToolStripMenuItem_Click);
            // 
            // admin_strip
            // 
            this.admin_strip.Name = "admin_strip";
            this.admin_strip.Size = new System.Drawing.Size(135, 23);
            this.admin_strip.Text = "POS Administrator";
            // 
            // user_strip
            // 
            this.user_strip.Name = "user_strip";
            this.user_strip.Size = new System.Drawing.Size(109, 23);
            this.user_strip.Text = "User Acccount";
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payroll1ToolStripMenuItem,
            this.payroll2ToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.payrollToolStripMenuItem.Text = "Payroll";
            this.payrollToolStripMenuItem.Click += new System.EventHandler(this.payrollToolStripMenuItem_Click);
            // 
            // payroll1ToolStripMenuItem
            // 
            this.payroll1ToolStripMenuItem.Name = "payroll1ToolStripMenuItem";
            this.payroll1ToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.payroll1ToolStripMenuItem.Text = "Payroll 1";
            this.payroll1ToolStripMenuItem.Click += new System.EventHandler(this.payroll1ToolStripMenuItem_Click);
            // 
            // payroll2ToolStripMenuItem
            // 
            this.payroll2ToolStripMenuItem.Name = "payroll2ToolStripMenuItem";
            this.payroll2ToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.payroll2ToolStripMenuItem.Text = "Payroll 2";
            this.payroll2ToolStripMenuItem.Click += new System.EventHandler(this.payroll2ToolStripMenuItem_Click);
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(156, 23);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            // 
            // humanResourcesToolStripMenuItem
            // 
            this.humanResourcesToolStripMenuItem.Name = "humanResourcesToolStripMenuItem";
            this.humanResourcesToolStripMenuItem.Size = new System.Drawing.Size(131, 23);
            this.humanResourcesToolStripMenuItem.Text = "Human Resources";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.cashier_strip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.cashier_strip;
            this.Name = "Main_form";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.cashier_strip.ResumeLayout(false);
            this.cashier_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip cashier_strip;
        private System.Windows.Forms.ToolStripMenuItem pOSCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOS1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOS2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admin_strip;
        private System.Windows.Forms.ToolStripMenuItem user_strip;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payroll1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payroll2ToolStripMenuItem;
    }
}