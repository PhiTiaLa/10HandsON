using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();
            this.Hide();
        } 
            public frmPurchaseDiscountedItem()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                string itemName = item.Text;
                double price = Convert.ToDouble(this.price.Text);
                double discount = Convert.ToDouble(this.discount.Text) * 0.01;
                int quantity = Convert.ToInt32(this.quantity.Text);


                double discountedPrice = price * (1 - discount);
                double totalAmount = discountedPrice * quantity;


                amount.Text = Convert.ToString(totalAmount);
            }

            private void button2_Click(object sender, EventArgs e)
            {
                double totalAmount = Convert.ToDouble(amount.Text);

                double payment = Convert.ToDouble(this.payment.Text);


                double change = payment - totalAmount;


                this.change.Text = Convert.ToString(change);
            }


        private void exitApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();
            this.Hide();
        }
    }
    }

namespace ItemNamespace {
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
    public class DiscountedItem : Item
    {
        public double Discount { get; set; }

        public double GetDiscountedPrice()
        {
            return Price * (1 - Discount * 0.01);
        }
    }
}
