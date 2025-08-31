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
            pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\Default_pfp.jpg");

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
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
            }
            // Code for clearing the picturebox as well
            pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\Default_pfp.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code for saving texts in textbox into listboxes
            listBox1.Items.Add(textBox11.Text);
            listBox2.Items.Add(textBox10.Text);
            listBox3.Items.Add(textBox9.Text);
            listBox4.Items.Add(textBox8.Text);
            listBox5.Items.Add(textBox7.Text);
            listBox6.Items.Add(textBox18.Text);
            listBox7.Items.Add(textBox12.Text);
            listBox8.Items.Add(textBox13.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}