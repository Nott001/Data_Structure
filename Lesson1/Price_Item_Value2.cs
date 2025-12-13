using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lesson2
{
    internal class Price_Item_Value2
    { // COMMON VARIABLES
        public int TotalQty { get; private set; } = 0;
        public double TotalAmount { get; private set; } = 0;
        public double Price { get; set; } = 0;
        public double Discount { get; set; } = 0;
        public double DiscountedAmount { get; set; } = 0;

        // Apply discount to current item
        public void ApplyDiscount(double rate, int qty)
        {
            Discount = (Price * qty) * rate;
            DiscountedAmount = (Price * qty) - Discount;
        }

        // Add current item to cart (accumulate totals)
        public void AddItemToCart(
            TextBox itemNameBox,
            TextBox priceBox,
            TextBox qtyBox,
            TextBox discountBox,
            TextBox discountedBox,
            TextBox qtyTotalBox,
            TextBox discountTotalBox,
            TextBox discountedTotalBox,
            RadioButton seniorRbtn,
            RadioButton regularRbtn,
            RadioButton employeeRbtn,
            RadioButton notaxRbtn)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(qtyBox.Text) || qtyBox.Text == "0")
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(priceBox.Text) || priceBox.Text == "0")
                {
                    MessageBox.Show("Please select an item first.");
                    return;
                }

                int qty = Convert.ToInt32(qtyBox.Text);
                double price = Convert.ToDouble(priceBox.Text);
                double discount = 0;
                double discountedAmount = 0;

                // Check if discount is applied
                if (!string.IsNullOrWhiteSpace(discountBox.Text) && discountBox.Text != "0")
                {
                    discount = Convert.ToDouble(discountBox.Text.Replace(",", ""));
                }

                if (!string.IsNullOrWhiteSpace(discountedBox.Text) && discountedBox.Text != "0")
                {
                    discountedAmount = Convert.ToDouble(discountedBox.Text.Replace(",", ""));
                }
                else
                {
                    // No discount applied, calculate full price
                    discountedAmount = price * qty;
                }

                // Get current totals
                int currentTotalQty = 0;
                double currentTotalDiscount = 0;
                double currentTotalAmount = 0;

                if (!string.IsNullOrWhiteSpace(qtyTotalBox.Text))
                {
                    currentTotalQty = Convert.ToInt32(qtyTotalBox.Text);
                }

                if (!string.IsNullOrWhiteSpace(discountTotalBox.Text))
                {
                    currentTotalDiscount = Convert.ToDouble(discountTotalBox.Text.Replace(",", ""));
                }

                if (!string.IsNullOrWhiteSpace(discountedTotalBox.Text))
                {
                    currentTotalAmount = Convert.ToDouble(discountedTotalBox.Text.Replace(",", ""));
                }

                // Add current item to totals
                currentTotalQty += qty;
                currentTotalDiscount += discount;
                currentTotalAmount += discountedAmount;

                // Update class properties
                TotalQty = currentTotalQty;
                Discount = currentTotalDiscount;
                TotalAmount = currentTotalAmount;

                // Update total boxes
                qtyTotalBox.Text = currentTotalQty.ToString();
                discountTotalBox.Text = currentTotalDiscount.ToString("N2");
                discountedTotalBox.Text = currentTotalAmount.ToString("N2");

                // Clear current item fields for next item
                itemNameBox.Clear();
                priceBox.Text = "0";
                qtyBox.Text = "0";
                discountBox.Text = "0";
                discountedBox.Text = "0";

                // Uncheck all discount radio buttons
                seniorRbtn.Checked = false;
                regularRbtn.Checked = false;
                employeeRbtn.Checked = false;
                notaxRbtn.Checked = false;

                MessageBox.Show("Item added to cart!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
            }
        }

        // Clear current item only (for selecting a new item)
        public void ClearCurrentItem(
            TextBox itemNameBox,
            TextBox priceBox,
            TextBox qtyBox,
            TextBox discountedBox,
            TextBox discountBox,
            RadioButton seniorRbtn,
            RadioButton regularRbtn,
            RadioButton employeeRbtn,
            RadioButton notaxRbtn)
        {
            itemNameBox.Clear();
            priceBox.Text = "0";
            qtyBox.Text = "0";
            discountBox.Text = "0";
            discountedBox.Text = "0";

            // Uncheck all discount radio buttons
            seniorRbtn.Checked = false;
            regularRbtn.Checked = false;
            employeeRbtn.Checked = false;
            notaxRbtn.Checked = false;
        }

        // Compute payment summary (calculate change)
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
                double cash = Convert.ToDouble(cashBox.Text);
                double totalAmount = Convert.ToDouble(discountedTotalBox.Text.Replace(",", ""));

                // Compute change
                double change = cash - totalAmount;

                // Display to UI
                changeBox.Text = change.ToString("N2");

                if (change < 0)
                {
                    MessageBox.Show("Insufficient cash rendered!");
                }
            }
            catch
            {
                MessageBox.Show("Invalid input in payment fields.");
            }
        }

        // Clear all entry fields
        public void ClearEntryFields(params TextBox[] boxes)
        {
            foreach (var box in boxes)
                box.Clear();
        }

        // Resets transaction totals
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

        // Load picture with error handling
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