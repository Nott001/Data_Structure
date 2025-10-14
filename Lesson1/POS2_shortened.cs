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
    public partial class POS2_shortened : Form
    {

        Price_Item_Value helper = new Price_Item_Value();

        private void SetFoodItem(CheckBox checkbox, double price)
        {
            discountTxtbox.Text = "0.00";
            priceTxtbox.Text = price.ToString("n");
            listBox1.Items.Add($"{checkbox.Text} {priceTxtbox.Text}");
            quantity_box.Text = "0";
            quantity_box.Focus();
        }

        public POS2_shortened()
        {
            InitializeComponent();
            radioButton_bundleA.CheckedChanged += radioButton_bundleA_CheckedChanged;
            radioButton_bundleB.CheckedChanged += RadioButton_bundleB_CheckedChanged;
        }

        private void RadioButton_bundleB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bundleB.Checked)
                helper.SetBundle(
                    this,
                    display_picturebox,
                    Color.LightYellow,               
                    "C:\\Users\\karlr\\source\\repos\\Data_Structure\\Lesson1\\pictures\\family bucket.png",
                    radioButton_bundleB.Text, 
                    1299.00, 194.85, 
                    priceTxtbox, discountTxtbox,quantity_box, listBox1);
        }



        private void radioButton_bundleA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bundleA.Checked)
                helper.SetBundle(this, display_picturebox, Color.LightCyan,
                    "C:\\Users\\karlr\\source\\repos\\Data_Structure\\Lesson1\\pictures\\family double bucket.png",
                    radioButton_bundleA.Text, 1000.00, 200.00,
                    priceTxtbox, discountTxtbox, quantity_box, listBox1);
        }

        private void radioButton_bundleB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!radioButton_bundleA.Checked) return;

            this.BackColor = Color.LightCyan;
            radioButton_bundleB.Checked = false;
            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\source\\repos\\Data_Structure\\Lesson1\\pictures\\family double bucket.png");

            priceTxtbox.Text = "1000.00";
            discountTxtbox.Text = "200.00";

            listBox1.Items.Add($"{radioButton_bundleA.Text} {priceTxtbox.Text}");
            listBox1.Items.Add($"Discount: {discountTxtbox.Text}");

            quantity_box.Text = "0";
            quantity_box.Focus();
        }

        // Codes for buttons
        private void button1_Click(object sender, EventArgs e)
        {
            helper.ShowPaymentSummary(cash_given_box, total_bills_box, change_box,
                          total_quantity_box, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var print = new Activity_4_lesson2_Print();
            print.listBox1.Items.AddRange(listBox1.Items);
            print.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helper.ResetAll(this, display_picturebox,
            "C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png",
            listBox1);
        }


        private void button6_Click(object sender, EventArgs e) => this.Close();


        private void button3_Click(object sender, EventArgs e)
        {
            //Codes to remove selected data inside the listbox
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked) SetFoodItem(checkBox11, 550.00);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked) SetFoodItem(checkBox12, 550.00);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked) SetFoodItem(checkBox13, 550.00);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked) SetFoodItem(checkBox14, 550.00);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked) SetFoodItem(checkBox15, 550.00);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked) SetFoodItem(checkBox16, 550.00);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked) SetFoodItem(checkBox17, 550.00);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked) SetFoodItem(checkBox18, 550.00);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked) SetFoodItem(checkBox19, 550.00);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked) SetFoodItem(checkBox20, 550.00);
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked) SetFoodItem(checkBox21, 550.00);
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked) SetFoodItem(checkBox22, 550.00);
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked) SetFoodItem(checkBox23, 550.00);
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked) SetFoodItem(checkBox24, 550.00);
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked) SetFoodItem(checkBox25, 550.00);
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked) SetFoodItem(checkBox26, 550.00);
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked) SetFoodItem(checkBox27, 550.00);
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked) SetFoodItem(checkBox28, 550.00);
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked) SetFoodItem(checkBox29, 550.00);
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked) SetFoodItem(checkBox30, 550.00);
        }

        private void POS2_shortened_Load(object sender, EventArgs e)
        {
            // Disable textboxes
            priceTxtbox.Enabled = discounted_amount_box.Enabled = change_box.Enabled =
                total_bills_box.Enabled = discountTxtbox.Enabled = total_quantity_box.Enabled = false;

            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png");
        }

        private void quantity_box_TextChanged(object sender, EventArgs e)
        {
            helper.ComputeTotals(quantity_box, priceTxtbox, discountTxtbox,
                     discounted_amount_box, total_bills_box, total_quantity_box);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
