using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Activity1.cs;

namespace Lesson2
{
    public partial class Activity4_lesson2 : Form
    {
        public Activity4_lesson2()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Activity4_lesson2_Load(object sender, EventArgs e)
        {
            //Codes for disabling some textboxes
            priceTxtbox.Enabled = false;
            discounted_amount_box.Enabled = false;
            change_box.Enabled = false;
            total_bills_box.Enabled = false;
            discountTxtbox.Enabled = false;
            total_quantity_box.Enabled = false;

            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\source\\repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png\\");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_bundleA_CheckedChanged(object sender, EventArgs e)
        {
            double price = 0;
            //Code for changing the form background
            this.BackColor = Color.LightCyan;
            //Code for food bundle B not to be selected
            radioButton_bundleB.Checked = false;
            //Inserting image inside the picturebox
            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\source\\repos\\Data_Structure\\Lesson1\\pictures\\family double bucket.png");
            //Codes to check the checkboxes
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            //Codes to uncheck checkboxes
            checkBox6.Checked = false;   
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            //Codes for displaying data inside the textboxes
            priceTxtbox.Text = "1000.00";
            discountTxtbox.Text = "200.00";
            price = Convert.ToDouble(priceTxtbox.Text);
            //Codes for inserting data inside the textboxes
            listBox1.Items.Add(radioButton_bundleA.Text + "            " + priceTxtbox.Text);
            listBox1.Items.Add("        Discount Amount:" + "            " + discountTxtbox.Text);
            quantity_box.Text = "0";
            quantity_box.Focus();
        }

        private void radioButton_bundleB_CheckedChanged(object sender, EventArgs e)
        {
            //Code for changing the form background
            this.BackColor = Color.LightBlue;
            //Code for food bundle B not to be selected
            radioButton_bundleA.Checked = false;
            //Inserting image inside the picturebox
            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\source\\repos\\Data_Structure\\Lesson1\\pictures\\family double bucket.png");
            //Codes to check the checkboxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            //Codes to uncheck checkboxes
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            //Codes for displaying price
            priceTxtbox.Text = "1299.00";
            discountTxtbox.Text = "(15% of the price) 194.85";
            listBox1.Items.Add(radioButton_bundleB.Text);
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            // Initialization of variables
            double cash_given, change, total_amount_paid;

            cash_given = Convert.ToDouble(cash_given_box.Text);
            total_amount_paid = Convert.ToDouble(total_bills_box.Text);
            change = cash_given - total_amount_paid;
            change_box.Text = change.ToString("n");

            //Codes for displaying
            listBox1.Items.Add("Total Bills: " + "            " + total_bills_box.Text);
            listBox1.Items.Add("Cash Given: " + "            " + cash_given_box.Text);
            listBox1.Items.Add("Total No. of Items: " + "            " + total_quantity_box.Text);
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
                        //Code for printing in anotehr form
            Activity_4_lesson2_Print print = new Activity_4_lesson2_Print();
            print.listBox1.Items.AddRange(this.listBox1.Items);

            //Code for displaying the other form
            print.Show();
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            //Codes to remove selected data inside the listbox
            listBox1.Items.RemoveAt (listBox1.SelectedIndex);
        }

        private void New_button_Click(object sender, EventArgs e)
        {
            //Codes to uncheck all given checkboxes
            radioButton_bundleA.Checked = false;
            radioButton_bundleB.Checked = false;
            //Code for inserting default image inside the picturebox
            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\source\\repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png\\");

            //Codes for clearing all the check boxes and radio button
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

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;

        }   
    }
}
