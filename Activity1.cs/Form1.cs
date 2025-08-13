using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "121.30";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Friend Meal A";
            priceTxtbox.Text = "391.90";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Double Value Meal A";
            priceTxtbox.Text = "191.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Family Combo Meal B";
            priceTxtbox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
