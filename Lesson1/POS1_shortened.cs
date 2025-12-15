using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class POS1_shortened : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value helper = new Price_Item_Value();
        int qty = 0;
        double price = 0.00;
        double discount_amt = 0.00;
        double discounted_amt = 0.00;
        bool isCalculated = false;

        // Store prices from database
        private string[] prices = new string[20];
        private string currentPosId = "1"; 

        public POS1_shortened()
        {
            posdb_connect.pos_connString();
            InitializeComponent();

            // Number buttons → cash textbox
            button8.Click += CashNumButton_Click; 
            button19.Click += CashNumButton_Click; 
            button15.Click += CashNumButton_Click; 
            button11.Click += CashNumButton_Click; 
            button6.Click += CashNumButton_Click; 
            button18.Click += CashNumButton_Click; 
            button14.Click += CashNumButton_Click; 
            button10.Click += CashNumButton_Click; 
            button7.Click += CashNumButton_Click; 
            button20.Click += CashNumButton_Click; 
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

            // Load initial data for POS ID 1
            LoadPOSIds();

            if (POS_comboBox.SelectedItem != null)
            {
                LoadPOSItems(POS_comboBox.SelectedItem.ToString());
            }
        }

        private void CashNumButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // If starting fresh or zero, replace
            if (cashrenderedtxtbox.Text == "0")
                cashrenderedtxtbox.Text = btn.Text;
            else
                cashrenderedtxtbox.Text += btn.Text;
        }


        private void LoadPOSIds() // Method to dynamically load data based on pos_id
        {
            picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide(); picpathTxtbox4.Hide(); picpathTxtbox5.Hide();
            picpathTxtbox6.Hide(); picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide(); picpathTxtbox10.Hide();
            picpathTxtbox11.Hide(); picpathTxtbox12.Hide(); picpathTxtbox13.Hide(); picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
            picpathTxtbox16.Hide(); picpathTxtbox17.Hide(); picpathTxtbox18.Hide(); picpathTxtbox19.Hide(); picpathTxtbox20.Hide();

            POS_comboBox.Items.Clear();

            posdb_connect.pos_sql = "SELECT pos_id FROM pos_nameTbl";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            foreach (DataRow row in posdb_connect.pos_sql_dataset.Tables[0].Rows)
            {
                POS_comboBox.Items.Add(row["pos_id"].ToString());
            }

            if (POS_comboBox.Items.Count > 0)
                POS_comboBox.SelectedIndex = 0;
        }

        private void LoadPOSItems(string posId)
        {
            try
            {
                posdb_connect.pos_sql =
                    "SELECT * FROM pos_nameTbl " +
                    "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                    "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                    "WHERE pos_nameTbl.pos_id = @pos_id";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sql_command.Parameters.Clear();
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@pos_id", posId);

                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                if (posdb_connect.pos_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No data found for this POS ID.");
                    return;
                }

                DataRow row = posdb_connect.pos_sql_dataset.Tables[0].Rows[0];

                // Names
                name1lbl.Text = row["name1"].ToString();
                name2lbl.Text = row["name2"].ToString();
                name3lbl.Text = row["name3"].ToString();
                name4lbl.Text = row["name4"].ToString();
                name5lbl.Text = row["name5"].ToString();
                name6lbl.Text = row["name6"].ToString();
                name7lbl.Text = row["name7"].ToString();
                name8lbl.Text = row["name8"].ToString();
                name9lbl.Text = row["name9"].ToString();
                name10lbl.Text = row["name10"].ToString();
                name11lbl.Text = row["name11"].ToString();
                name12lbl.Text = row["name12"].ToString();
                name13lbl.Text = row["name13"].ToString();
                name14lbl.Text = row["name14"].ToString();
                name15lbl.Text = row["name15"].ToString();
                name16lbl.Text = row["name16"].ToString();
                name17lbl.Text = row["name17"].ToString();
                name18lbl.Text = row["name18"].ToString();
                name19lbl.Text = row["name19"].ToString();
                name20lbl.Text = row["name20"].ToString();

                // Pictures
                helper.LoadPictureBox(pictureBox1, picpathTxtbox1, row["pic1"].ToString());
                helper.LoadPictureBox(pictureBox2, picpathTxtbox2, row["pic2"].ToString());
                helper.LoadPictureBox(pictureBox3, picpathTxtbox3, row["pic3"].ToString());
                helper.LoadPictureBox(pictureBox4, picpathTxtbox4, row["pic4"].ToString());
                helper.LoadPictureBox(pictureBox5, picpathTxtbox5, row["pic5"].ToString());
                helper.LoadPictureBox(pictureBox6, picpathTxtbox6, row["pic6"].ToString());
                helper.LoadPictureBox(pictureBox7, picpathTxtbox7, row["pic7"].ToString());
                helper.LoadPictureBox(pictureBox8, picpathTxtbox8, row["pic8"].ToString());
                helper.LoadPictureBox(pictureBox9, picpathTxtbox9, row["pic9"].ToString());
                helper.LoadPictureBox(pictureBox10, picpathTxtbox10, row["pic10"].ToString());
                helper.LoadPictureBox(pictureBox11, picpathTxtbox11, row["pic11"].ToString());
                helper.LoadPictureBox(pictureBox12, picpathTxtbox12, row["pic12"].ToString());
                helper.LoadPictureBox(pictureBox13, picpathTxtbox13, row["pic13"].ToString());
                helper.LoadPictureBox(pictureBox14, picpathTxtbox14, row["pic14"].ToString());
                helper.LoadPictureBox(pictureBox15, picpathTxtbox15, row["pic15"].ToString());
                helper.LoadPictureBox(pictureBox16, picpathTxtbox16, row["pic16"].ToString());
                helper.LoadPictureBox(pictureBox17, picpathTxtbox17, row["pic17"].ToString());
                helper.LoadPictureBox(pictureBox18, picpathTxtbox18, row["pic18"].ToString());
                helper.LoadPictureBox(pictureBox19, picpathTxtbox19, row["pic19"].ToString());
                helper.LoadPictureBox(pictureBox20, picpathTxtbox20, row["pic20"].ToString());

                // Prices
                prices[0] = row["price1"].ToString();
                prices[1] = row["price2"].ToString();
                prices[2] = row["price3"].ToString();
                prices[3] = row["price4"].ToString();
                prices[4] = row["price5"].ToString();
                prices[5] = row["price6"].ToString();
                prices[6] = row["price7"].ToString();
                prices[7] = row["price8"].ToString();
                prices[8] = row["price9"].ToString();
                prices[9] = row["price10"].ToString();
                prices[10] = row["price11"].ToString();
                prices[11] = row["price12"].ToString();
                prices[12] = row["price13"].ToString();
                prices[13] = row["price14"].ToString();
                prices[14] = row["price15"].ToString();
                prices[15] = row["price16"].ToString();
                prices[16] = row["price17"].ToString();
                prices[17] = row["price18"].ToString();
                prices[18] = row["price19"].ToString();
                prices[19] = row["price20"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading POS data: " + ex.Message);
            }
        }


        private void Example2_DatabaseApp_Load(object sender, EventArgs e)
        {
            try
            {
                itemnametxtbox.Enabled = false;
                pricetextbox.Enabled = false;
                discountedtxtbox.Enabled = false;
                qty_totaltxtbox.Enabled = false;
                discount_totaltxtbox.Enabled = false;
                discounted_totaltxtbox.Enabled = false;
                changetxtbox.Enabled = false;
                discounttxtbox.Enabled = false;

                picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide(); picpathTxtbox4.Hide(); picpathTxtbox5.Hide();
                picpathTxtbox6.Hide(); picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide(); picpathTxtbox10.Hide();
                picpathTxtbox11.Hide(); picpathTxtbox12.Hide(); picpathTxtbox13.Hide(); picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
                picpathTxtbox16.Hide(); picpathTxtbox17.Hide(); picpathTxtbox18.Hide(); picpathTxtbox19.Hide(); picpathTxtbox20.Hide();

                // Check if dataset has data
                if (posdb_connect.pos_sql_dataset == null || 
                    posdb_connect.pos_sql_dataset.Tables.Count == 0 || 
                    posdb_connect.pos_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the selected POS ID.");
                    return;
                }

                // Load data from database
                DataRow row = posdb_connect.pos_sql_dataset.Tables[0].Rows[0];

                // Load names
                name1lbl.Text = row["name1"].ToString();
                name2lbl.Text = row["name2"].ToString();
                name3lbl.Text = row["name3"].ToString();
                name4lbl.Text = row["name4"].ToString();
                name5lbl.Text = row["name5"].ToString();
                name6lbl.Text = row["name6"].ToString();
                name7lbl.Text = row["name7"].ToString();
                name8lbl.Text = row["name8"].ToString();
                name9lbl.Text = row["name9"].ToString();
                name10lbl.Text = row["name10"].ToString();
                name11lbl.Text = row["name11"].ToString();
                name12lbl.Text = row["name12"].ToString();
                name13lbl.Text = row["name13"].ToString();
                name14lbl.Text = row["name14"].ToString();
                name15lbl.Text = row["name15"].ToString();
                name16lbl.Text = row["name16"].ToString();
                name17lbl.Text = row["name17"].ToString();
                name18lbl.Text = row["name18"].ToString();
                name19lbl.Text = row["name19"].ToString();
                name20lbl.Text = row["name20"].ToString();

                // Load pictures
                helper.LoadPictureBox(pictureBox1, picpathTxtbox1, row["pic1"].ToString());
                helper.LoadPictureBox(pictureBox2, picpathTxtbox2, row["pic2"].ToString());
                helper.LoadPictureBox(pictureBox3, picpathTxtbox3, row["pic3"].ToString());
                helper.LoadPictureBox(pictureBox4, picpathTxtbox4, row["pic4"].ToString());
                helper.LoadPictureBox(pictureBox5, picpathTxtbox5, row["pic5"].ToString());
                helper.LoadPictureBox(pictureBox6, picpathTxtbox6, row["pic6"].ToString());
                helper.LoadPictureBox(pictureBox7, picpathTxtbox7, row["pic7"].ToString());
                helper.LoadPictureBox(pictureBox8, picpathTxtbox8, row["pic8"].ToString());
                helper.LoadPictureBox(pictureBox9, picpathTxtbox9, row["pic9"].ToString());
                helper.LoadPictureBox(pictureBox10, picpathTxtbox10, row["pic10"].ToString());
                helper.LoadPictureBox(pictureBox11, picpathTxtbox11, row["pic11"].ToString());
                helper.LoadPictureBox(pictureBox12, picpathTxtbox12, row["pic12"].ToString());
                helper.LoadPictureBox(pictureBox13, picpathTxtbox13, row["pic13"].ToString());
                helper.LoadPictureBox(pictureBox14, picpathTxtbox14, row["pic14"].ToString());
                helper.LoadPictureBox(pictureBox15, picpathTxtbox15, row["pic15"].ToString());
                helper.LoadPictureBox(pictureBox16, picpathTxtbox16, row["pic16"].ToString());
                helper.LoadPictureBox(pictureBox17, picpathTxtbox17, row["pic17"].ToString());
                helper.LoadPictureBox(pictureBox18, picpathTxtbox18, row["pic18"].ToString());
                helper.LoadPictureBox(pictureBox19, picpathTxtbox19, row["pic19"].ToString());
                helper.LoadPictureBox(pictureBox20, picpathTxtbox20, row["pic20"].ToString());

                // Store prices from database
                prices[0] = row["price1"].ToString();
                prices[1] = row["price2"].ToString();
                prices[2] = row["price3"].ToString();
                prices[3] = row["price4"].ToString();
                prices[4] = row["price5"].ToString();
                prices[5] = row["price6"].ToString();
                prices[6] = row["price7"].ToString();
                prices[7] = row["price8"].ToString();
                prices[8] = row["price9"].ToString();
                prices[9] = row["price10"].ToString();
                prices[10] = row["price11"].ToString();
                prices[11] = row["price12"].ToString();
                prices[12] = row["price13"].ToString();
                prices[13] = row["price14"].ToString();
                prices[14] = row["price15"].ToString();
                prices[15] = row["price16"].ToString();
                prices[16] = row["price17"].ToString();
                prices[17] = row["price18"].ToString();
                prices[18] = row["price19"].ToString();
                prices[19] = row["price20"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name1lbl.Text, prices[0]);
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name2lbl.Text, prices[1]);
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name3lbl.Text, prices[2]);
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name4lbl.Text, prices[3]);
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name5lbl.Text, prices[4]);
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name6lbl.Text, prices[5]);
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name7lbl.Text, prices[6]);
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name8lbl.Text, prices[7]);
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name9lbl.Text, prices[8]);
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name10lbl.Text, prices[9]);
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name11lbl.Text, prices[10]);
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name12lbl.Text, prices[11]);
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name13lbl.Text, prices[12]);
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name14lbl.Text, prices[13]);
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name15lbl.Text, prices[14]);
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name16lbl.Text, prices[15]);
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name17lbl.Text, prices[16]);
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name18lbl.Text, prices[17]);
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name19lbl.Text, prices[18]);
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name20lbl.Text, prices[19]);
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
            isCalculated = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            helper.ClearEntryFields(itemnametxtbox, pricetextbox, qty_box, discountedtxtbox, discounttxtbox, changetxtbox, cashrenderedtxtbox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            helper.ClearEntryFields(itemnametxtbox, pricetextbox, qty_box, discounttxtbox, changetxtbox, cashrenderedtxtbox, discountedtxtbox);
            helper.ResetTotals(qty_totaltxtbox, discount_totaltxtbox, discounted_totaltxtbox);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helper.ExitApp(this);
        }

        private void name1lbl_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void picpathTxtbox1_TextChanged(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            // Must calculate first
            if (!isCalculated)
            {
                MessageBox.Show("Please click CALCULATE before saving the transaction.");
                return;
            }

            try
            {
                posdb_connect.pos_sql =
                "INSERT INTO salesTbl (" +
                "product_name, product_price, product_quantity_per_transaction, " +
                "discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, " +
                "summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, " +
                "terminal_no, time_date, emp_id" +
                ") VALUES (" +
                "@product_name, @product_price, @qty, " +
                "@discount_option, @discount_amt, @discounted_amt, " +
                "@total_qty, @total_disc, @total_discounted, " +
                "@terminal_no, @time_date, @emp_id" +
                ")";

                posdb_connect.pos_cmd();

                // Item details
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@product_name", itemnametxtbox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@product_price", pricetextbox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@qty", qty_box.Text);

                // Discount type
                string discountOption =
                    seniorRbtn.Checked ? "Senior" :
                    regularRbtn.Checked ? "Regular" :
                    employeeRbtn.Checked ? "Employee" :
                    "No Discount";

                posdb_connect.pos_sql_command.Parameters.AddWithValue("@discount_option", discountOption);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@discount_amt", discounttxtbox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@discounted_amt", discountedtxtbox.Text);

                // Summary
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@total_qty", qty_totaltxtbox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@total_disc", discount_totaltxtbox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@total_discounted", discounted_totaltxtbox.Text);

                // NEW FIELDS
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@terminal_no", terminal_no_TxtBox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@time_date", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@emp_id", emp_id_TxtBox.Text);

                posdb_connect.pos_sqladapterInsert();

                MessageBox.Show("Transaction saved successfully.");

                // Reset flag for next transaction
                isCalculated = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transaction:\n" + ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // Optional: block if not calculated
            if (!isCalculated)
            {
                MessageBox.Show("Please calculate the transaction first.");
                return;
            }

            POS1_print receipt = new POS1_print(
                terminal_no_TxtBox.Text,
                emp_name_TxtBox.Text,
                emp_id_TxtBox.Text,
                dateTimePicker1.Value,
                itemnametxtbox.Text,
                pricetextbox.Text,
                qty_box.Text,
                discounttxtbox.Text,
                discounted_totaltxtbox.Text,
                cashrenderedtxtbox.Text,
                changetxtbox.Text
            );

            receipt.ShowDialog(); // modal (POS waits)
        }

        private void change_pos_button_Click(object sender, EventArgs e)
        {
            if (POS_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a POS ID.");
                return;
            }

            string selectedPosId = POS_comboBox.SelectedItem.ToString();

            LoadPOSItems(selectedPosId);

            // Optional safety reset
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            qty_box.Clear();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            cashrenderedtxtbox.Text = "0";
        }
    }
}