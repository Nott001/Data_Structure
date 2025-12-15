using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lesson2
{
    public class Price_Item_Value
    {
        // COMMON VARIABLES
        public int TotalQty { get; private set; } = 0;
        public double TotalAmount { get; private set; } = 0;
        public double Price { get; set; } = 0;
        public double Discount { get; set; } = 0;
        public double DiscountedAmount { get; set; } = 0;
        public double total_Discount { get; private set; } = 0;

        // BASIC ACTIONS

        // Reset all fields, checkboxes, and totals
        public void ResetAll(Form form, PictureBox pictureBox, string defaultImagePath, ListBox listBox)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox tb) tb.Clear();
                if (control is CheckBox cb) cb.Checked = false;
                if (control is RadioButton rb) rb.Checked = false;
            }

            listBox.Items.Clear();
            pictureBox.Image = Image.FromFile(defaultImagePath);
            form.BackColor = SystemColors.Control;

            TotalQty = 0;
            TotalAmount = 0;
        }

        // Compute totals after quantity is entered
        public void ComputeTotals(TextBox qtyBox, TextBox priceBox, TextBox discountBox,
                                  TextBox discountedBox, TextBox totalBillsBox, TextBox totalQtyBox)
        {
            if (string.IsNullOrWhiteSpace(qtyBox.Text)) return;

            int qty = Convert.ToInt32(qtyBox.Text);
            double price = Convert.ToDouble(priceBox.Text);
            double discount = Convert.ToDouble(discountBox.Text);

            DiscountedAmount = (price * qty) - discount;
            TotalQty += qty;
            TotalAmount += DiscountedAmount;

            discountedBox.Text = DiscountedAmount.ToString("n");
            totalBillsBox.Text = TotalAmount.ToString("n");
            totalQtyBox.Text = TotalQty.ToString();
        }

        // Display payment summary
        public void ShowPaymentSummary(TextBox cashBox, TextBox totalBillsBox,
                                       TextBox changeBox, TextBox totalQtyBox, ListBox listBox)
        {
            double cash = Convert.ToDouble(cashBox.Text);
            double total = Convert.ToDouble(totalBillsBox.Text);
            double change = cash - total;

            changeBox.Text = change.ToString("n");

            listBox.Items.Add("------------------------------------");
            listBox.Items.Add($"Total Bills: {totalBillsBox.Text}");
            listBox.Items.Add($"Cash Given: {cashBox.Text}");
            listBox.Items.Add($"Change: {changeBox.Text}");
            listBox.Items.Add($"Total Items: {totalQtyBox.Text}");
        }

        // Apply background and picture when a radio button is selected
        public void SetBundle(Form form, PictureBox pictureBox, Color bgColor,
                              string imagePath, string itemName, double price, double discount,
                              TextBox priceBox, TextBox discountBox, TextBox qtyBox, ListBox listBox)
        {
            form.BackColor = bgColor;
            pictureBox.Image = Image.FromFile(imagePath);
            Price = price;
            Discount = discount;

            priceBox.Text = price.ToString("n");
            discountBox.Text = discount.ToString("n");

            listBox.Items.Add($"{itemName}   P{priceBox.Text}");
            listBox.Items.Add($"Discount: P{discountBox.Text}");
            qtyBox.Clear();
            qtyBox.Focus();
        }

        public void ApplyDiscount(double rate, int qty)
        {
            Discount = (Price * qty) * rate;
            DiscountedAmount = (Price * qty) - Discount;
        }

        public void ComputePaymentSummary(
            TextBox qtyBox,
            TextBox discountBox,
            TextBox discountedBox,
            TextBox cashBox,
            TextBox qtyTotalBox,
            TextBox discountTotalBox,
            TextBox discountedTotalBox,
            TextBox changeBox)
        {
            try
            {

                int qty = Convert.ToInt32(qtyBox.Text);
                double discount = Convert.ToDouble(discountBox.Text);
                double discounted = Convert.ToDouble(discountedBox.Text);
                double cash = Convert.ToDouble(cashBox.Text);

                // Accumulate totals
                total_Discount += discount;
                TotalQty += qty;
                TotalAmount += discounted;

                // Compute change
                double change = cash - discounted;

                // Display to UI
                qtyTotalBox.Text = TotalQty.ToString();
                discountTotalBox.Text = total_Discount.ToString("n");
                discountedTotalBox.Text = TotalAmount.ToString("n");
                changeBox.Text = change.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid input in payment fields.");
            }
        }

        public void ClearEntryFields(params TextBox[] boxes)
        {
            foreach (var box in boxes)
                box.Clear();
        }

        // Resets transaction totals (optional for button3)
        public void ResetTotals(TextBox qtyTotalBox, TextBox discountTotalBox, TextBox discountedTotalBox)
        {
            TotalQty = 0;
            Discount = 0;
            TotalAmount = 0;

            qtyTotalBox.Clear();
            discountTotalBox.Clear();
            discountedTotalBox.Clear();
        }

        // Closes the POS form
        public void ExitApp(Form form)
        {
            form.Close();
        }

        public void LoadPictureBox(PictureBox pictureBox, TextBox pathTextBox, string imagePath)
        {
            try
            {
                pathTextBox.Text = imagePath;

                // Check if path is valid and not empty
                if (!string.IsNullOrWhiteSpace(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Load default "no image" picture
                    string defaultPath = "C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\no_image.jpg";
                    if (System.IO.File.Exists(defaultPath))
                    {
                        pictureBox.Image = Image.FromFile(defaultPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {imagePath}\nError: {ex.Message}");
                // Load default image on error
                try
                {
                    string defaultPath = "C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\no_image.jpg";
                    if (System.IO.File.Exists(defaultPath))
                    {
                        pictureBox.Image = Image.FromFile(defaultPath);
                    }
                }
                catch { }
            }
        }
    }

}



