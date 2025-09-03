using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
        }

        private void Activity_Load(object sender, EventArgs e)
        {
            total_num_units_box1.Enabled = false;
            total_tuition_box1.Enabled = false;
            credit_units_box.Enabled = false;
            total_misc_box1.Enabled = false;
            total_fee_box1.Enabled = false;

            //Code for manually adding each program into the combobox
            comboBox1.Items.Add("Bachelor of Science in Civil Engineering");
            comboBox1.Items.Add("Bachelor of Science in Mechanical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Electrical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Electronics Engineering");
            comboBox1.Items.Add("Bachelor of Science in Computer Engineering");
            comboBox1.Items.Add("Bachelor of Science in Industrial Engineering");
            comboBox1.Items.Add("Bachelor of Science in Aeronautical Engineering");

            

        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            // Code to browse file explorer using browse button
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Code to allow only images
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select a Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the picturebox image to the selected photo
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Using iteration to clear all textboxes including comboboxes
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                else if (ctrl is ListBox)
                    ((ListBox)ctrl).Items.Clear();
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).Items.RemoveAt(comboBox1.SelectedIndex);

            }
            // Code for clearing the picturebox as well
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code for saving texts in textbox into listboxes
            listBox1.Items.Add(course_num_box.Text);
            listBox2.Items.Add(course_code_box.Text);
            listBox3.Items.Add(course_desc_box.Text);
            listBox4.Items.Add(unit_lecture_box.Text);
            listBox5.Items.Add(unit_lab_box.Text);
            listBox6.Items.Add(credit_units_box.Text);
            listBox7.Items.Add(time_box.Text);
            listBox8.Items.Add(day_box.Text);

            total_num_units_box2.Text = total_num_units_box1.Text;
            comp_lab_fee_box2.Text = lab_fee_box1.Text;
            total_tuition_box2.Text = total_tuition_box1.Text;
            total_misc_box2.Text = total_misc_box1.Text;
            cisco_box2.Text = cisco_box1.Text;
            booklet_box2.Text = booklet_box1.Text;
            total_fee_box2.Text = total_fee_box1.Text;

            int total_units = 0;
            int lec_unit, lab_unit;

            lec_unit = Convert.ToInt32(unit_lecture_box.Text);
            lab_unit = Convert.ToInt32(unit_lab_box.Text);

            total_units += lec_unit + lab_unit;

            credit_units_box.Text = total_units.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            int total_units = 0;

            //Adding values of credit list boxes 
            foreach (var item in listBox4.Items)
            {
                if (int.TryParse(item.ToString(), out int units))
                {
                    total_units += units;
                }
            }

            foreach (var item in listBox2.Items)
            {
                if (int.TryParse(item.ToString(), out int units))
                {
                    total_units += units;
                }
            }

            total_num_units_box1.Text = total_units.ToString();


            double Miscellanous_fee = 0;
            double exam_booklet, cisco_lab, computer_lab;

            exam_booklet = Convert.ToDouble(booklet_box1.Text);
            cisco_lab = Convert.ToDouble(cisco_box1.Text);
            computer_lab = Convert.ToDouble(comp_lab_fee_box2.Text);

            Miscellanous_fee += exam_booklet + cisco_lab + computer_lab;


            total_misc_box1.Text = Miscellanous_fee.ToString();





        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}