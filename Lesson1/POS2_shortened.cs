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
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value helper = new Price_Item_Value();

        // Store prices from database
        private string[] prices = new string[20];
        private string currentPosId = "1";
        private bool isCalculated = false;

        private void SetFoodItem(CheckBox checkbox, string priceString)
        {
            // Perform the conversion (parsing) inside the helper method
            if (double.TryParse(priceString, out double price))
            {
                discountTxtbox.Text = "0.00";
                // Use the parsed double 'price' for formatting
                priceTxtbox.Text = price.ToString("n");
                listBox1.Items.Add($"{checkbox.Text} {priceTxtbox.Text}");
                quantity_box.Text = "0";
                quantity_box.Focus();
            }
        }

        public POS2_shortened()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
            radioButton_bundleA.CheckedChanged += radioButton_bundleA_CheckedChanged;
            radioButton_bundleB.CheckedChanged += RadioButton_bundleB_CheckedChanged;
        }

        private void RadioButton_bundleB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bundleB.Checked)
                helper.SetBundle(this, display_picturebox, Color.LightYellow,
                    "C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\kfc_double_bucket.jpg",
                    radioButton_bundleB.Text, 1299.00, 194.85,
                    priceTxtbox, discountTxtbox, quantity_box, listBox1);

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
        }



        private void radioButton_bundleA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bundleA.Checked)
                helper.SetBundle(this, display_picturebox, Color.LightCyan,
                    "C:\\Users\\karlr\\source\\repos\\Data_Structure\\Lesson1\\pictures\\family double bucket.png",
                    radioButton_bundleA.Text, 1000.00, 200.00,
                    priceTxtbox, discountTxtbox, quantity_box, listBox1);

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
        }


        // Codes for buttons
        private void button1_Click(object sender, EventArgs e)
        {
            helper.ShowPaymentSummary(cash_given_box, total_bills_box, change_box,
                          total_quantity_box, listBox1);
            isCalculated = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var print = new POS2_print();
            print.listBox1.Items.AddRange(listBox1.Items);
            print.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helper.ResetAll(this, display_picturebox,
            "C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png",
            listBox1);

            // Uncheck radio buttons
            radioButton_bundleA.Checked = false;
            radioButton_bundleB.Checked = false;

            //Codes to check the checkboxes
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
            isCalculated = false;
        }


        private void button6_Click(object sender, EventArgs e) => this.Close();


        private void button3_Click(object sender, EventArgs e)
        {
            //Codes to remove selected data inside the listbox
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void POS2_shortened_Load(object sender, EventArgs e)
        {
            // Disable textboxes
            priceTxtbox.Enabled = discounted_amount_box.Enabled = change_box.Enabled =
                total_bills_box.Enabled = discountTxtbox.Enabled = total_quantity_box.Enabled = false;

            display_picturebox.Image = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_food.png");
            LoadPOSData(currentPosId);
        }

        private void Example2_DatabaseApp_Load(object sender, EventArgs e)
        {
            try
            {

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
                checkBox11.Text = row["name1"].ToString();
                checkBox12.Text = row["name2"].ToString();
                checkBox13.Text = row["name3"].ToString();
                checkBox14.Text = row["name4"].ToString();
                checkBox15.Text = row["name5"].ToString();
                checkBox16.Text = row["name6"].ToString();
                checkBox17.Text = row["name7"].ToString();
                checkBox18.Text = row["name8"].ToString();
                checkBox19.Text = row["name9"].ToString();
                checkBox20.Text = row["name10"].ToString();
                checkBox21.Text = row["name11"].ToString();
                checkBox22.Text = row["name12"].ToString();
                checkBox23.Text = row["name13"].ToString();
                checkBox24.Text = row["name14"].ToString();
                checkBox25.Text = row["name15"].ToString();
                checkBox26.Text = row["name16"].ToString();
                checkBox27.Text = row["name17"].ToString();
                checkBox28.Text = row["name18"].ToString();
                checkBox29.Text = row["name19"].ToString();
                checkBox30.Text = row["name20"].ToString();

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

        public void LoadPOSData(string posId)
        {
            try
            {
                currentPosId = posId;

                posdb_connect.pos_sql = "SELECT pos_nameTbl.pos_id, " +
                      "pos_nameTbl.name1, pos_nameTbl.name2, pos_nameTbl.name3, pos_nameTbl.name4, pos_nameTbl.name5, " +
                      "pos_nameTbl.name6, pos_nameTbl.name7, pos_nameTbl.name8, pos_nameTbl.name9, pos_nameTbl.name10, " +
                      "pos_nameTbl.name11, pos_nameTbl.name12, pos_nameTbl.name13, pos_nameTbl.name14, pos_nameTbl.name15, " +
                      "pos_nameTbl.name16, pos_nameTbl.name17, pos_nameTbl.name18, pos_nameTbl.name19, pos_nameTbl.name20, " +
                      "pos_picTbl.pic1, pos_picTbl.pic2, pos_picTbl.pic3, pos_picTbl.pic4, pos_picTbl.pic5, " +
                      "pos_picTbl.pic6, pos_picTbl.pic7, pos_picTbl.pic8, pos_picTbl.pic9, pos_picTbl.pic10, " +
                      "pos_picTbl.pic11, pos_picTbl.pic12, pos_picTbl.pic13, pos_picTbl.pic14, pos_picTbl.pic15, " +
                      "pos_picTbl.pic16, pos_picTbl.pic17, pos_picTbl.pic18, pos_picTbl.pic19, pos_picTbl.pic20, " +
                      "pos_priceTbl.price1, pos_priceTbl.price2, pos_priceTbl.price3, pos_priceTbl.price4, pos_priceTbl.price5, " +
                      "pos_priceTbl.price6, pos_priceTbl.price7, pos_priceTbl.price8, pos_priceTbl.price9, pos_priceTbl.price10, " +
                      "pos_priceTbl.price11, pos_priceTbl.price12, pos_priceTbl.price13, pos_priceTbl.price14, pos_priceTbl.price15, " +
                      "pos_priceTbl.price16, pos_priceTbl.price17, pos_priceTbl.price18, pos_priceTbl.price19, pos_priceTbl.price20 " +
                      "FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                      "WHERE pos_nameTbl.pos_id = '" + posId + "'";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                Example2_DatabaseApp_Load(null, null); // Reload all data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading POS data: " + ex.Message);
            }
        }


        private void quantity_box_TextChanged(object sender, EventArgs e)
        {
            helper.ComputeTotals(quantity_box, priceTxtbox, discountTxtbox,
                     discounted_amount_box, total_bills_box, total_quantity_box);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked) SetFoodItem(checkBox11, prices[0]);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked) SetFoodItem(checkBox12, prices[1]);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked) SetFoodItem(checkBox13, prices[2]);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked) SetFoodItem(checkBox14, prices[3]);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked) SetFoodItem(checkBox15, prices[4]);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked) SetFoodItem(checkBox16, prices[5]);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked) SetFoodItem(checkBox17, prices[6]);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked) SetFoodItem(checkBox18, prices[7]);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked) SetFoodItem(checkBox19, prices[8]);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked) SetFoodItem(checkBox20, prices[9]);
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked) SetFoodItem(checkBox21, prices[10]);
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked) SetFoodItem(checkBox22, prices[11]);
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked) SetFoodItem(checkBox23, prices[12]);
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked) SetFoodItem(checkBox24, prices[13]);
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked) SetFoodItem(checkBox25, prices[14]);
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked) SetFoodItem(checkBox26, prices[15]);
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked) SetFoodItem(checkBox27, prices[16]);
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked) SetFoodItem(checkBox28, prices[17]);
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked) SetFoodItem(checkBox29, prices[18]);
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked) SetFoodItem(checkBox30, prices[19]);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            // Must calculate first
            if (!isCalculated)
            {
                MessageBox.Show("Please click CALCULATE BILLS before saving the transaction.");
                return;
            }

            // Required fields check
            if (string.IsNullOrWhiteSpace(emp_id_TxtBox.Text) ||
                string.IsNullOrWhiteSpace(terminal_no_TxtBox.Text))
            {
                MessageBox.Show("Employee ID and Terminal Number are required.");
                return;
            }

            // Check if there are items in the listbox
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No items to save. Please add items to your order.");
                return;
            }

            try
            {
                // Get all selected items from listbox (excluding summary lines)
                string allItems = "";
                foreach (var item in listBox1.Items)
                {
                    string itemStr = item.ToString();
                    // Skip separator lines and summary lines
                    if (!itemStr.Contains("----") &&
                        !itemStr.StartsWith("Total Bills:") &&
                        !itemStr.StartsWith("Cash Given:") &&
                        !itemStr.StartsWith("Change:") &&
                        !itemStr.StartsWith("Total Items:"))
                    {
                        allItems += itemStr + "; ";
                    }
                }

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

                // Item details - using all items from listbox
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@product_name", allItems.TrimEnd(' ', ';'));
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@product_price", priceTxtbox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@qty", quantity_box.Text);

                // Discount info
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@discount_option", "Bundle Discount");
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@discount_amt", discountTxtbox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@discounted_amt", discounted_amount_box.Text);

                // Summary totals
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@total_qty", total_quantity_box.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@total_disc", discountTxtbox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@total_discounted", total_bills_box.Text);

                // Terminal and employee info
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@terminal_no", terminal_no_TxtBox.Text);
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@time_date", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                posdb_connect.pos_sql_command.Parameters.AddWithValue("@emp_id", emp_id_TxtBox.Text);

                posdb_connect.pos_sqladapterInsert();

                MessageBox.Show("Transaction saved successfully!");

                // Reset flag for next transaction
                isCalculated = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transaction:\n" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}