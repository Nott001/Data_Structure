using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Activity4_lesson2 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        private double total_price = 0;
        public Activity4_lesson2()
        {
            InitializeComponent();
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

            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png");
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
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void New_button_Click(object sender, EventArgs e)
        {
            //Codes to uncheck all given checkboxes
            radioButton_bundleA.Checked = false;
            radioButton_bundleB.Checked = false;
            //Code for inserting default image inside the picturebox
            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png");

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

            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "550.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox11.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "600.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox12.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "530.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox13.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "525.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox14.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "200.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox15.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "150.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox16.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "165.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox17.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "125.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox18.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "99.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox19.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "699.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox20.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "450.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox21.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "899.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox22.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "799.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox23.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }
        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "699.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox20.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "2099.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox25.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "1099.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox26.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "399.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox27.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "249.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox28.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "99.99";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox29.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            //Codes to declare variable
            double price;
            //Codes for putting text property value of the textbox
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = "79.00";
            //Codes to convert string data
            price = Convert.ToDouble(priceTxtbox.Text);
            //Code to insert text property value
            listBox1.Items.Add(checkBox30.Text + " " + priceTxtbox.Text);
            //Codes for putting text property value of the textbox
            quantity_box.Text = "0";
            //Codes for the cursor to focus
            quantity_box.Focus();
        }

        private void quantity_box_TextChanged(object sender, EventArgs e)
        {
            double discounted_amount, discount_amount = 0;
            int qty;
            total_price = Convert.ToDouble(priceTxtbox.Text);
            qty = Convert.ToInt32(quantity_box.Text);
            discount_amount = Convert.ToDouble(discountTxtbox.Text);

            //Calculations
            discounted_amount = (total_price* qty) - discount_amount;
            total_qty += qty;
            total_quantity_box.Text = total_qty.ToString();
            total_amount += discounted_amount;

            total_bills_box.Text = total_amount.ToString("n");
            discounted_amount_box.Text = discounted_amount.ToString("n");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Initialization of variables
            double cash_given, change, total_amount_paid;

            cash_given = Convert.ToDouble(cash_given_box.Text);
            total_amount_paid = Convert.ToDouble(total_bills_box.Text);
            change = cash_given - total_amount_paid;
            change_box.Text = change.ToString("n");

            //Codes for displaying
            listBox1.Items.Add("Total Bills: " + " " + total_bills_box.Text);
            listBox1.Items.Add("Cash Given: " + " " + cash_given_box.Text);
            listBox1.Items.Add("Change: " + " " + change_box.Text);
            listBox1.Items.Add("Total No. of Items: " + " " + total_quantity_box.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Codes to uncheck all given checkboxes
            radioButton_bundleA.Checked = false;
            radioButton_bundleB.Checked = false;
            //Code for inserting default image inside the picturebox
            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png");

            //Codes for clearing all the check boxes and radio button and textboxes
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

            cash_given_box.Clear();
            total_amount = 0;
            total_qty = 0;
            total_price = 0;
       
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;

            //Removing all items from the listbox
            listBox1.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Codes to remove selected data inside the listbox
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Code for printing in anotehr form
            Activity_4_lesson2_Print print = new Activity_4_lesson2_Print();
            print.listBox1.Items.AddRange(this.listBox1.Items);

            //Code for displaying the other form
            print.Show();
        }

        private void display_picturebox_Click(object sender, EventArgs e)
        {

        }

        private void Activity4_lesson2_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}