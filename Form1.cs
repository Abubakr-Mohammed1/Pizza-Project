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

        public Form1()
        {
            InitializeComponent();
        }

        float CalculateToppingsPrice()
        {
            float Price = 0;

            if (chkChees.Checked)
                Price += Convert.ToSingle(chkChees.Tag);

            if (chkOnion.Checked)
                Price += Convert.ToSingle(chkOnion.Tag);

            if (chkMushrooms.Checked)
                Price += Convert.ToSingle(chkMushrooms.Tag);

            if (chkOlives.Checked)
                Price += Convert.ToSingle(chkOlives.Tag);

            if (chkTomatoes.Checked)
                Price += Convert.ToSingle(chkTomatoes.Tag);

            if (chkPeppers.Checked)
                Price += Convert.ToSingle(chkPeppers.Tag);

            return Price;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);

            else
                return Convert.ToSingle(rbThinCrust.Tag);
        }

        float GetSelectedSizePrice()
        {

            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);


        }

        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice() + GetSelectedSizePrice() + CalculateToppingsPrice();
        }

        void UpdateTotalPrice()
        {

            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();

        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrust.Text = "Thin Crust";
                return;
            }
            else
            {
                lblCrust.Text = "Thick Crust";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkChees.Checked)
                sToppings = "Extra Chees, ";

            if (chkOnion.Checked)
                sToppings += "Onion, ";

            if (chkMushrooms.Checked)
                sToppings += "Mushrooms, ";

            if (chkOlives.Checked)
                sToppings += "Olives, ";

            if (chkTomatoes.Checked)
                sToppings += "Tomatoes, ";

            if (chkPeppers.Checked)
                sToppings += "Green Papers, ";

            if (sToppings.EndsWith(", "))
            {
                sToppings = sToppings.Substring(0, sToppings.Length - 2).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
                lblWhereToEat.Text = "Eat In";
            else
                lblWhereToEat.Text = "Take Out";
        }

        void ResetForm()
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhere.Enabled = true;

            rbSmall.Checked = true;

            chkChees.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkPeppers.Checked = false;
            chkTomatoes.Checked = false;

            rbThinCrust.Checked = true;

            rbTakeOut.Checked = true;

            btnOrder.Enabled = true;
        }

        void UpdateOrderSummary()
        {
            UpdateCrust();
            UpdateSize();
            UpdateTotalPrice();
            UpdateToppings();
            UpdateWhereToEat();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirm Order.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrder.Enabled = false;
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhere.Enabled = false;
            }
            else
            {
                MessageBox.Show("Order Not Placed", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SizeOptions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void CrustOptions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void ToppingsOptions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void WhereToEatOptions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
    }
}
