using System;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Activity_Print : Form
    {

        public Activity_Print()
        {
            InitializeComponent();

            listBox1.Items.AddRange(listBox1.Items);
            listBox2.Items.AddRange(listBox2.Items);
            listBox3.Items.AddRange(listBox3.Items);
            listBox4.Items.AddRange(listBox4.Items);
            listBox5.Items.AddRange(listBox5.Items);
            listBox6.Items.AddRange(listBox6.Items);
            listBox7.Items.AddRange(listBox7.Items);
            listBox8.Items.AddRange(listBox8.Items);
        }

        private void Activity_Print_Load(object sender, EventArgs e)
        {



        }

        private void course_num_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
