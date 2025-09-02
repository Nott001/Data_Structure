using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Activity2 : Form
    {
        // Initializes the components
        public Activity2()
        {
            InitializeComponent();
        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            // Disable textboxes for item details and totals.
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

            // Codes for inserting picture or image inside the picturebox tool
            pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\jollibee_sausage_pancake.jpg");
            pictureBox2.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\Corned-Beef-With-Drink.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\pandesal egg.jpg");
            pictureBox4.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\1-pc.-Chickenjoy-With-Coke-Float.png");
            pictureBox5.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\1 meal.jpg");
            pictureBox6.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\double meal.jpg");
            pictureBox7.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\two meal.jpg");
            pictureBox8.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\spag_chicken.jpg");
            pictureBox9.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\Jollibee-Crispy-Flavored-Fries.jpg");
            pictureBox10.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\1 bucket 2 sundae.jpg");
            pictureBox11.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\jabee_spag.jpg");
            pictureBox12.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\jolli_shake.jpg");
            pictureBox13.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\burger large.jpg");
            pictureBox14.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\family double bucket.png");
            pictureBox15.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\kfc_double_bucket.jpg");
            pictureBox16.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\kfc_chick_strips.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\kfc_chaofun.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\chicken_burger.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\kfc_combo.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\karlr\\OneDrive\\Documents\\GitHub\\Data_Structure\\pictures\\kfc_meal.jpg");

            // Codes for inserting picture or image inside the picturebox tool
            name1lbl.Text = "Combo Meal A";
            name2lbl.Text = "Breakfast Meal 1";
            name3lbl.Text = "Breakfast Meal 2";
            name4lbl.Text = "Chicken Meal A";
            name5lbl.Text = "Combo Meal B";
            name6lbl.Text = "Group Meal A";
            name7lbl.Text = "Group Meal B";
            name8lbl.Text = "Chicken Spag Meal A";
            name9lbl.Text = "Twin Fries";
            name10lbl.Text = "Family Meal Meal A";
            name11lbl.Text = "Spag Meal 1";
            name12lbl.Text = "Jolly Shake";
            name13lbl.Text = "KFC Burger Combo Meal 1";
            name14lbl.Text = "Chicken Group Meal";
            name15lbl.Text = "KFC Family Meal A";
            name16lbl.Text = "KFC Chicken Strips Meal";
            name17lbl.Text = "KFC Chaofun Meal";
            name18lbl.Text = "Burger and Chicken Meal C";
            name19lbl.Text = "KFC Combo Meal A";
            name20lbl.Text = "KFC Family Meal B";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "95.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "110.30";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "121.30";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "130.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "165.45";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "280.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "280.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "190.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "110.60";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "495.90";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "99.99";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "45.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "365.50";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "465.50";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "767.50";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "230.30";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "85.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "285.60";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "185.60";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = "599.99";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaration of the variables with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            double qty_total = 0;
            double discount_totalgiven = 0;
            double discounted_total = 0;    

            qty = Convert.ToInt32(qty_box.Text);
            discount_amt = Convert.ToDouble(discounttxtbox.Text);
            discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);

            //Codes to accumulate the total quantity, total discount, and total discounted amount from one transaction to another
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            //Convert string data from textboxes to numeric and place it as value of the variable
            qty_totaltxtbox.Text = qty_total.ToString();
            discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
            discounted_totaltxtbox.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrenderedtxtbox.Text = cash_rendered.ToString("n");

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void itemnametxtbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void qty_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of the variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            //Convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(qty_box.Text);
            price = Convert.ToInt32(pricetextbox.Text);
            //Create a formula needed for computation
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;
            //Converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            //Codes for unchecking the other radio buttons in the interface once the senior citizen method is executed
            regularRbtn.Checked = false;
            employeeRbtn.Checked = false;   
            notaxRbtn.Checked = false;  

        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of the variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            //Convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(qty_box.Text);
            price = Convert.ToInt32(pricetextbox.Text);
            //Create a formula needed for computation
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            //Converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            //Codes for unchecking the other radio buttons in the interface once the regular method is executed
            seniorRbtn.Checked = false;
            employeeRbtn.Checked = false;
            notaxRbtn.Checked = false;
        }

        private void employeeRbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of the variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            //Convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(qty_box.Text);
            price = Convert.ToInt32(pricetextbox.Text);
            //Create a formula needed for computation
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;
            //Converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            //Codes for unchecking the other radio buttons in the interface 
            seniorRbtn.Checked = false;
            regularRbtn.Checked = false;
            notaxRbtn.Checked = false;
        }

        private void notaxRbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of the variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            //Convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(qty_box.Text);
            price = Convert.ToInt32(pricetextbox.Text);
            //Create a formula needed for computation
            discount_amt = (qty * price) * 0.00;
            discounted_amt = (qty * price) - discount_amt;
            //Converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            //Codes for unchecking the other radio buttons in the interface 
            seniorRbtn.Checked = false;
            regularRbtn.Checked = false;
            employeeRbtn.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Code for closing the form application once the button clicked
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Codes fro clearing specific pointed textboxes
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            qty_box.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashrenderedtxtbox.Clear();
        }
    }
}
