using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson2
{

    public partial class Activity : Form
    {
        double tuition_fee = 1700.00;
        double total_tuition_fee = 0;
        double total_tuition = 0;
        int total_units = 0;

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
            other_fees_box.Enabled = false;

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
                    ((ComboBox)ctrl).Items.Clear();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total_credit = 0;
            int lec_unit, lab_unit;

            lec_unit = Convert.ToInt32(unit_lecture_box.Text);
            lab_unit = Convert.ToInt32(unit_lab_box.Text);

            total_credit += lec_unit + lab_unit;
            total_units += total_credit;

            credit_units_box.Text = total_credit.ToString();
            total_num_units_box1.Text = total_units.ToString();

            // Code for saving texts in textbox into listboxes
            listBox1.Items.Add(course_num_box.Text);
            listBox2.Items.Add(course_code_box.Text);
            listBox3.Items.Add(course_desc_box.Text);
            listBox4.Items.Add(unit_lecture_box.Text);
            listBox5.Items.Add(unit_lab_box.Text);
            listBox6.Items.Add(credit_units_box.Text);
            listBox7.Items.Add(time_box.Text);
            listBox8.Items.Add(day_box.Text);

            //
            Activity_Print print = new Activity_Print();

            print.course_num_box.Text = this.course_num_box.Text;
            print.course_code_box.Text = this.course_code_box.Text;
            print.course_desc_box.Text = this.course_desc_box.Text;
            print.unit_lecture_box.Text = this.unit_lecture_box.Text;
            print.unit_lab_box.Text = this.unit_lab_box.Text;
            print.credit_units_box.Text = this.credit_units_box.Text;
            print.time_box.Text = this.time_box.Text;
            print.day_box.Text = this.day_box.Text;


            print.listBox1.Items.AddRange(this.listBox1.Items);
            print.listBox2.Items.AddRange(this.listBox2.Items);
            print.listBox3.Items.AddRange(this.listBox3.Items);
            print.listBox4.Items.AddRange(this.listBox4.Items);
            print.listBox5.Items.AddRange(this.listBox5.Items);
            print.listBox6.Items.AddRange(this.listBox6.Items);
            print.listBox6.Items.AddRange(this.listBox6.Items);
            print.listBox8.Items.AddRange(this.listBox8.Items);

            print.Show();


        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            //Initialization
            double total_miscellanous_fee = 0;
            double cisco_lab, exam_booklet, comp_lab;

            // Code for calculating tuition

            total_tuition += total_units * tuition_fee;

            total_tuition_box1.Text = total_tuition.ToString();

            // Code for calculating miscellanous fee

            cisco_lab = Convert.ToDouble(cisco_box1.Text);
            exam_booklet = Convert.ToDouble(booklet_box1.Text);
            comp_lab = Convert.ToDouble(lab_fee_box1.Text);

            total_miscellanous_fee += cisco_lab + exam_booklet + comp_lab;

            total_misc_box1.Text = total_miscellanous_fee.ToString("n");

            // Code for calculating total tuition and fees

            total_tuition_fee += total_tuition + total_miscellanous_fee;

            total_fee_box1.Text = total_tuition_fee.ToString("n");

            // Display calculations
            total_num_units_box2.Text = total_num_units_box1.Text;
            lab_fee_box2.Text = lab_fee_box1.Text;
            total_tuition_box2.Text = total_tuition_box1.Text;
            total_misc_box2.Text = total_misc_box1.Text;
            cisco_box2.Text = cisco_box1.Text;
            booklet_box2.Text = booklet_box1.Text;
            total_fee_box2.Text = total_fee_box1.Text;
            other_fees_box = total_misc_box1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
