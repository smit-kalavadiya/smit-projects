using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCalculator
{
    /*
     
    Smit kalavadiya
    5047957
    IT-PA-2021
     */
    public partial class Form1 : Form
    {
        const decimal TAX = 0.15m;
        decimal totalTax;
        decimal subTotal,deliveryCharge;
        decimal grandTotal;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                int len = email.Length;
                int posOfatSign = email.IndexOf("@");
                int periodsPos = email.LastIndexOf(".");
                int pos = periodsPos - posOfatSign;
                string msg = $"Your order is on the way!{ Environment.NewLine}" +
                $"Total: {grandTotal:c}";

                if (len >= 5 && email.Contains("@") && email.Contains(".") && pos >= 2)
                {
                    MessageBox.Show(msg,"Enjoy!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address","Invalid Data",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, Ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button_Press(object sender, EventArgs e)
        {
            try
            {
                CheckBox cb;
                string type = sender.GetType().ToString();

                if (type == "System.Windows.Forms.CheckBox")
                {
                    cb = (CheckBox)sender;

                    if (cb.Checked)
                    {
                        if (cb.Text == "Extra Cheese")
                        {
                            subTotal += 2;
                            lblSubtotal.Text = subTotal.ToString("c");
                        }
                        else
                        {
                            subTotal += 1;
                            lblSubtotal.Text = subTotal.ToString("c");
                        }
                    }
                    else
                    {
                        if (cb.Text == "Extra Cheese")
                        {
                            subTotal -= 2;
                            lblSubtotal.Text = subTotal.ToString("c");
                            return;
                        }
                        subTotal -= 1;
                        lblSubtotal.Text = subTotal.ToString("c");
                    }
                }
                else
                {
                    RadioButton rb = (RadioButton)sender;

                    if (rb.Name == "rdoSmall")
                    {
                        subTotal = 8;
                        lblSubtotal.Text = subTotal.ToString("c");

                    }
                    if (rb.Name == "rdoMedium")
                    {
                        subTotal = 11;
                        lblSubtotal.Text = subTotal.ToString("c");
                    }
                    if (rb.Name == "rdoLarge")
                    {
                        subTotal = 13;
                        lblSubtotal.Text = subTotal.ToString("c");
                    }
                    if (rb.Name == "rdoExtraLarge")
                    {
                        subTotal = 18;
                        lblSubtotal.Text = subTotal.ToString("c");
                    }
                }

                if (subTotal < 15)
                {
                    deliveryCharge = 5;
                }
                else
                {
                    deliveryCharge = 3;
                }

                lblDeliveryCharge.Text = deliveryCharge.ToString("c");
                totalTax = (subTotal + deliveryCharge) * TAX;
                lblTax.Text = totalTax.ToString("c");
                grandTotal = subTotal + totalTax + deliveryCharge;
                lblGrandTotal.Text = grandTotal.ToString("c");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, Ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rdoSmall.Checked = true;
        }
    }
}
