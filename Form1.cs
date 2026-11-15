using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {

        private void UpdatePrice()
        {
            decimal Price = 0;


            if(rdSmall.Checked)
            {
                Price = 50;
                lblSize.Text = "Small";
            }
            else if(rdMedium.Checked)
            {
                Price = 60;
            }
            else if(rdLarge.Checked)
            {
                Price = 70;
            }

            if (chbChees.Checked)
                Price += 10;

            if (chbOnion.Checked)
                Price += 5;

            if (chbMushrooms.Checked)
                Price += 5;

            if (chbOlives.Checked)
                Price += 5;

            if (chbTomatoes.Checked)
                Price += 5;

            if (chbPeppers.Checked)
                Price += 5;

            if (rdThick.Checked)
                Price += 10;






            lblPrice.Text = Price.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Confirmed.", "Order Statue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Options_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = false;
            gbCrust.Enabled = false;
            gbToppings.Enabled = false;
            gbWhere.Enabled = false;
        }

        
    }
}
