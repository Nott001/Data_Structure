using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lesson2
{
    public partial class POS1_shortened : Form
    {
        int qty = 0;
        double price = 0.00;
        double discount_amt = 0.00;
        double discounted_amt = 0.00;

        Price_Item_Value helper = new Price_Item_Value();

        public POS1_shortened()
        {
            InitializeComponent();
        }

        //Helper to clear and focus
        private void quantityTxtbox()
        {
            qty_box.Clear();
            qty_box.Focus();
        }

        public void price_item_TextValue(string itemname, string itemprice)
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = itemprice;
        }

        private void POS1_shortened_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

            qty_box.Text = "0";
            pricetextbox.Text = "0";
            discounttxtbox.Text = "0";
            discountedtxtbox.Text = "0";
            cashrenderedtxtbox.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name1lbl.Text, "101.50");
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name2lbl.Text, "100.50");
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name3lbl.Text, "111.50");
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name4lbl.Text, "120.50");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name5lbl.Text, "90.50");
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name6lbl.Text, "101.50");
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name7lbl.Text, "123.50");
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name8lbl.Text, "188.50");
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name9lbl.Text, "680.50");
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name10lbl.Text, "199.50");
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name11lbl.Text, "99.00");
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name12lbl.Text, "190.50");
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name13lbl.Text, "121.50");
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name14lbl.Text, "599.50");
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name15lbl.Text, "91.50");
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name16lbl.Text, "81.50");
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name17lbl.Text, "71.50");
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name18lbl.Text, "211.50");
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name19lbl.Text, "200.50");
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name20lbl.Text, "576.00");
            quantityTxtbox();
        }

        // Codes for senior discount
        private void seniorRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (seniorRbtn.Checked)
            {
                try
                {
                    int qty = Convert.ToInt32(qty_box.Text);
                    helper.Price = Convert.ToDouble(pricetextbox.Text);

                    helper.ApplyDiscount(0.30, qty);

                    discounttxtbox.Text = helper.Discount.ToString("n");
                    discountedtxtbox.Text = helper.DiscountedAmount.ToString("n");

                    regularRbtn.Checked = false;
                    employeeRbtn.Checked = false;
                    notaxRbtn.Checked = false;
                }
                catch
                {
                    MessageBox.Show("Invalid input in quantity.");
                }
            }
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (regularRbtn.Checked)
            {
                try
                {
                    int qty = Convert.ToInt32(qty_box.Text);
                    helper.Price = Convert.ToDouble(pricetextbox.Text);

                    helper.ApplyDiscount(0.10, qty);

                    discounttxtbox.Text = helper.Discount.ToString("n");
                    discountedtxtbox.Text = helper.DiscountedAmount.ToString("n");

                    seniorRbtn.Checked = false;
                    employeeRbtn.Checked = false;
                    notaxRbtn.Checked = false;
                }
                catch
                {
                    MessageBox.Show("Invalid input in quantity.");
                }
            }
        }

        private void employeeRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeRbtn.Checked)
            {
                try
                {
                    int qty = Convert.ToInt32(qty_box.Text);
                    helper.Price = Convert.ToDouble(pricetextbox.Text);

                    helper.ApplyDiscount(0.15, qty);

                    discounttxtbox.Text = helper.Discount.ToString("n");
                    discountedtxtbox.Text = helper.DiscountedAmount.ToString("n");

                    seniorRbtn.Checked = false;
                    regularRbtn.Checked = false;
                    notaxRbtn.Checked = false;
                }
                catch
                {
                    MessageBox.Show("Invalid input in quantity.");
                }
            }
        }

        private void notaxRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (notaxRbtn.Checked)
            {
                try
                {
                    int qty = Convert.ToInt32(qty_box.Text);
                    helper.Price = Convert.ToDouble(pricetextbox.Text);

                    helper.ApplyDiscount(0.00, qty);

                    discounttxtbox.Text = helper.Discount.ToString("n");
                    discountedtxtbox.Text = helper.DiscountedAmount.ToString("n");

                    seniorRbtn.Checked = false;
                    regularRbtn.Checked = false;
                    employeeRbtn.Checked = false;
                }
                catch
                {
                    MessageBox.Show("Invalid input in quantity.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            helper.ComputePaymentSummary(
                qty_box,
                discounttxtbox,
                discountedtxtbox,
                cashrenderedtxtbox,
                qty_totaltxtbox,
                discount_totaltxtbox,
                discounted_totaltxtbox,
                changetxtbox
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helper.ClearEntryFields( itemnametxtbox, pricetextbox, qty_box, discountedtxtbox, discounttxtbox, changetxtbox, cashrenderedtxtbox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            helper.ClearEntryFields(itemnametxtbox, pricetextbox, qty_box, discounttxtbox, changetxtbox, cashrenderedtxtbox);

            helper.ResetTotals(qty_totaltxtbox, discount_totaltxtbox, discounted_totaltxtbox);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helper.ExitApp(this);
        }

        private void name1lbl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
