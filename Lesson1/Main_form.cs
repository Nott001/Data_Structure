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
    public partial class Main_form : Form
    {
        public Main_form() // Initializes the form
        {
            InitializeComponent();
        }

        private void pOS1ToolStripMenuItem_Click(object sender, EventArgs e) // When POS 1 is clicked
        {
            POS1_shortened newMDIChild = new POS1_shortened();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();

        }

        private void pOS2OrderingToolStripMenuItem_Click(object sender, EventArgs e) // When POS 2 is clicked
        {
            POS2_shortened newMDIChild = new POS2_shortened();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) // When log out is clicked
        {
            this.Close();
        }

        private void pOSAdminToolStripMenuItem_Click(object sender, EventArgs e) // When POS Admin is clicked
        {
            POS_Admin newMDIChild = new POS_Admin();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeePayrollToolStripMenuItem_Click(object sender, EventArgs e) // When employee payroll is clicked
        {
            Payroll_shortened newMDIChild = new Payroll_shortened();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e) // When employee registration is clicked
        {
            Employee_registration newMDIChild = new Employee_registration();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeAccountToolStripMenuItem_Click(object sender, EventArgs e) // When employee account is clicked
        {
            user_account newMDIChild = new user_account();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // When employee reports is clicked
        private void employeeReportsToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            employee_reports newMDIChild = new employee_reports();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payrol_report newMDIChild = new payrol_report();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void accountReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            useraccount_reports newMDIChild = new useraccount_reports();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void salesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_reports newMDIChild = new sales_reports();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1_lesson2 newMDIChild = new Activity1_lesson2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void studentEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_lesson2 newMDIChild = new Activity_lesson2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void otherPayrollFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_lesson5 newMDIChild = new Activity_lesson5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // For window layout
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
