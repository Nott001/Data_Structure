using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Activity3 : Form
    {
        public Activity3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code for changing the form background
            this.BackColor = Color.LightGoldenrodYellow;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Code for changing the form background
            this.BackColor = Color.LightCyan;
            // Code for food bundle B to not be selected
            radioButton_bundleB.Checked = false;
            // Inserting image inside the picture box
            pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\10_chicken.jpeg");

            // Codes to check the checkboxes
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;

            // Codes to uncheck the checkboxes
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;

            // Codes for displaying data inside the textboxes
            priceTxtbox.Text = "P1,000.00";
            discountTxtbox.Text = " P200.00 (20% of the Price)";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Code for changing the form background
            this.BackColor = Color.LightBlue;
            // Code for food bundle B to not be selected
            radioButton_bundleA.Checked = false;
            // Inserting image inside the picture box
            pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\carbonara.jpg");

            // Codes to check the checkboxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            // Codes to uncheck the checkboxes
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;

            // Codes for displaying data inside the textboxes
            priceTxtbox.Text = "P1,299.00";
            discountTxtbox.Text = " P194.85 (15% of the Price)";
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            // Code for food bundle A & B to not be selected
            radioButton_bundleA.Checked = false;
            radioButton_bundleB.Checked = false;

            // Inserting default image inside the picture box
            pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\default.png");

            // Codes to uncheck all of the checkboxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;

            // Codes for clearing the textboxes
            priceTxtbox.Clear();
            discountTxtbox.Clear();

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
