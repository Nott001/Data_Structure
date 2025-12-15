using System;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class POS1_print : Form
    {
        public POS1_print(
            string terminalNo,
            string empName,
            string empId,
            DateTime transDate,
            string itemName,
            string price,
            string qty,
            string discount,
            string total,
            string cash,
            string change)
        {
            InitializeComponent();

            lblStoreName.Text = "Villa FOODS";
            lblTerminal.Text = "Terminal: " + terminalNo;
            lblEmployee.Text = $"Cashier: {empName} ({empId})";
            lblDate.Text = transDate.ToString("yyyy-MM-dd HH:mm");

            lblItem.Text = "Item: " + itemName;
            lblPrice.Text = "Price: " + price;
            lblQty.Text = "Qty: " + qty;
            lblDiscount.Text = "Discount: " + discount;
            lblTotal.Text = "Total: " + total;
            lblCash.Text = "Cash: " + cash;
            lblChange.Text = "Change: " + change;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}