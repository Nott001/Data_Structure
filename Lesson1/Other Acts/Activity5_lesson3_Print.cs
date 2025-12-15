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
    public partial class Activity5_lesson3_Print : Form
    {
        public Activity5_lesson3_Print()
        {
            InitializeComponent();
            Payslip_view_listbox.Items.AddRange(Payslip_view_listbox.Items);
        }

        private void Activity5_lesson3_Print_Load(object sender, EventArgs e)
        {

        }
    }
}
