using Lesson2;
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
        public Main_form()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void pOS1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2_lesson2 pos = new Activity2_lesson2();
            pos.MdiParent = this;
            pos.Show();
        }

        private void pOS2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4_lesson2 pos2 = new Activity4_lesson2();
            pos2.MdiParent = this;
          pos2.Show();
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void payroll1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_lesson5 payroll = new Activity_lesson5();
            payroll.MdiParent = this;
            payroll.Show();
        }

        private void payroll2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity5_lesson3 payroll2 = new Activity5_lesson3();
            payroll2.MdiParent = this;
            payroll2.Show();
        }

        private void humanResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOSCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pOSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_Admin posAdmin = new POS_Admin();
            posAdmin.MdiParent = this;
            posAdmin.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tile all child forms in vertical display
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tile all child forms horizontally
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tile all child forms in cascade display
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
